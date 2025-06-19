using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable
namespace QLSV.Models
{
    public partial class Class
    {
        [Display(Name = "Mã lớp")]
        public int ClassId { get; set; }
        [Required]
        [Display(Name = "Tên lớp")]
        public string ClassName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}