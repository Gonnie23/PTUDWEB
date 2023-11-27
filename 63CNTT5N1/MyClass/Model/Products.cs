using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Model
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã loại sản phẩm không để trống")]
        [Display(Name = "Mã loại sản phẩm")]
        public int CatId { get; set; }

        [Required(ErrorMessage = "Tên loại sản phẩm không để trống")]
        [Display(Name = "Tên loại sản phẩm")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mã loại nhà cung cấp không để trống")]
        [Display(Name = "Mã loại nhà cung cấp sản phẩm")]
        public int SupplierId { get; set; }

        [Display(Name = "Tên rút gọn")]
        public string Slug { get; set; }

        [Display(Name = "Hình ảnh")]
        public string Img { get; set; }

        [Required(ErrorMessage = "Giá nhập không để trống")]
        [Display(Name = "Giá nhập")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Giá bán không để trống")]
        [Display(Name = "Giá bán")]
        public decimal SalePrice { get; set; }

        [Required(ErrorMessage = "số lượng không để trống")]
        [Display(Name = "Số lượng")]
        public int Qty { get; set; }

        [Required(ErrorMessage = "Mô tả không để trống")]
        [Display(Name = "Mô tả")]
        public string MetaDesc { get; set; }

        [Required(ErrorMessage = "Từ khóa không để trống")]
        [Display(Name = "Từ khóa")]
        public string MetaKey { get; set; }

        [Display(Name = "Người tạo")]
        public int CreateBy { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreateAt { get; set; }

        [Display(Name = "Người cập nhật")]
        public int UpdateBy { get; set; }

        [Display(Name = "Ngày cập nhật")]
        public DateTime UpdateAt { get; set; }

        public int? Status { get; set; }
    }
}
