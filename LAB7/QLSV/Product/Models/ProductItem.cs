using System.ComponentModel.DataAnnotations;

namespace Product.Models
{
    public class ProductItem
    {
        public int Id { get; set; }  // Khóa chính

        [Required]
        [StringLength(100)]
        public string Name { get; set; }  // Tên sản phẩm

        [Range(0, double.MaxValue, ErrorMessage = "Giá phải là một số dương.")]
        public decimal Price { get; set; }  // Giá sản phẩm

        [Range(0, int.MaxValue, ErrorMessage = "Số lượng tồn kho phải là một số dương.")]
        public int Stock { get; set; }  // Số lượng tồn kho
    }
}
