using SQLite;
using System;
using System.Collections.Generic;


using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeRecorder.Models
{
    [Table("Languages")]
    public class Languages
    {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; }
       
        public string Title { get; set; }


    }
}
