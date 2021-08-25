using CodeChallengeRecorder.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeRecorder
{
   public class FileManager
    {
        SQLiteAsyncConnection conn;
        public FileManager()
        {
            Init();
        }
        async Task Init()
        {

            var options2 = new SQLiteConnectionString("data", true);

                

            conn = new SQLiteAsyncConnection(options2);
            

            await conn.CreateTableAsync<Languages>();
            await conn.CreateTableAsync<Problems>();
            await conn .CreateTableAsync<Solutions>();
            await conn .CreateTableAsync<Method>();
        }

        public async Task<List<object>> GetEntries(string type)
        {
            List<object> entries = new List<object>();
            if (type == "languages")
            {
                var tables = conn.Table<Languages>() ;
               List<Languages> table = await tables.ToListAsync();
               
                foreach(var x in table)
                {
                    entries.Add(x);
                }
            }
            else if(type == "problems")
            {
                var tables = conn.Table<Problems>();
                List<Problems> table = await tables.ToListAsync();
                foreach (var x in table)
                {
                    entries.Add(x);
                }
            }
            else if( type == "methods")
            {
                var tables = conn.Table<Method>();
                List<Method> table = await tables.ToListAsync();
                foreach (var x in table)
                {
                    entries.Add(x);
                }
            }
            else
            {
                var tables = conn.Table<Solutions>();
                List<Solutions> table = await tables.ToListAsync();
                foreach (var x in table)
                {
                    entries.Add(x);
                }
            }

            return entries;
        }

        public async Task AddUpdate(object entry, string type)
        {
            if(type ==  "languages")
            {
              await conn.InsertOrReplaceAsync((Languages)entry);
            }
            else if(type == "problems")
            {
                conn.InsertOrReplaceAsync((Problems)entry);
            }
            else if(type == "methods")
            {
              await  conn.InsertOrReplaceAsync((Method)entry);
            }
            else
            {
               await conn.InsertOrReplaceAsync((Solutions)entry);
            }
            
            
        }

        public async Task DeleteObjects(object key, string type)
        {
            if (type == "languages")
            {
                await conn.DeleteAsync<Languages>(key);
            }
            else if(type == "problems")
            {
                await conn.DeleteAsync<Problems>(key);
            }
            else if(type == "methods")
            {
                await conn.DeleteAsync<Method>(key);
            }
            else
            {
                await conn.DeleteAsync<Solutions>(key);
            }
        }
       
    }
}
