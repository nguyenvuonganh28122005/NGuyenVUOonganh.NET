using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nva_Lesson12.Models
{
    [Table("Category")]
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "tinyint")]
        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        // Sửa ở đây: Thêm dấu ? để cho phép Null hoặc khởi tạo mặc định bằng new List<ProductModel>()
        public ICollection<ProductModel>? Products { get; set; } = new List<ProductModel>();
    }
}