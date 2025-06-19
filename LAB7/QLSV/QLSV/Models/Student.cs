using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace QLSV.Models
{
    public class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int classId { get; set; }
        public Class Class { get; set; }
    }
}