﻿using System.ComponentModel.DataAnnotations;

namespace NCKH_Laptop.Areas.Admin.Models
{
    public class InventoriesModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string? MaKho { get; set; }
        public int ProductId { get; set; } // Required foreign key property
        public ProductModel product { get; set; } = null!;
        public DateTime? NgayNhap { get; set; }
        public int SoLuong { get; set; }
    }
}
