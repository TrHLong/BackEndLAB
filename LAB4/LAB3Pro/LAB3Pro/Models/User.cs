using System.ComponentModel.DataAnnotations;

namespace LAB3Pro.Models
{
    public class User
    {
        [Required(ErrorMessage = "ID không được để trống")]
        public string id { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        public string username { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string phone { get; set; }
    }
}
