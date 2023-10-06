using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass.Model;

namespace MyClass.Model
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên loại SP")]
        public string Name { get; set; }
        [Display(Name = "Tên loại rút gọn")]
        public string Slug { get; set; }
        public int ParentID { get; set; }
        [Display(Name = "Tên loại SP")]
        public int? Order { get; set; }
        [Required]
        [Display(Name = "Tên loại SP")]
        public string MetaDesc { get; set; }
        [Required]
        [Display(Name = "Tên loại SP")]
        public string MetaKey { get; set; }
        [Display(Name = "Tên loại SP")]
        public DateTime CreateAt { get; set; }
        [Display(Name = "Tên loại SP")]
        public int CreateBy { get; set; }
        [Display(Name = "Ngày cập nhật bởi ")]
        public DateTime UpdateAt { get; set; }
        [Display(Name = "Ngày cập nhật")]
        public int UpdateBy { get; set; }
        [Display(Name = "Trạng thái")]
        public int Status { get; set; }
    }

}

