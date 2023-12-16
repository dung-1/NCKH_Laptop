using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NCKH_Laptop.Areas.Admin.Models
{
    public class OrdersModel
    {

        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        [StringLength(10)]
        public string? MaHoaDon { get; set; }
        public DateTime ngayBan { get; set; }
        public float tongTien { get; set; }
        [StringLength(20)]
        public string? trangThai { get; set; }
        [StringLength(20)]
        public string? LoaiHoaDon { get; set; }
        public ICollection<OrderDetaiModel> ctdh { get; } = new List<OrderDetaiModel>();

        public string UserId { get; set; }
        public IdentityUser User { get; set; }

    }
}
