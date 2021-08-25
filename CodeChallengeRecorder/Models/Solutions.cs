using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeRecorder.Models
{
    [Table("Solutions")]
    public class Solutions
    {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; }
        
        public  int? ParentID { get; set; }
        public string Title { get; set; }
        public string Solution { get; set; }

    }
}
