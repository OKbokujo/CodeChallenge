using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeRecorder.Models
{
    [Table("Problems")]
    public class Problems
    {
       
            [PrimaryKey, AutoIncrement]
            public int? Id { get; set; }
            public int ParentID { get; set; }
            public string Title { get; set; }
            public string Problem { get; set; }
            public DateTime DateTime { get; set; }
            
             public string WebAddress { get; set; }
        
    }
}
