using SQLite;
using System;
using System.Collections.Generic;


using System.Text;
using System.Threading.Tasks;

namespace CodeChallengeRecorder.Models
{
    [Table("Method")]
    public class Method
    {
        [PrimaryKey, AutoIncrement]
        public int? Id { get; set; }
  
        public int? ParentID { get; set; }
        public string Title { get; set; }

        public string SolutionsID { get; set; }
    }
}
