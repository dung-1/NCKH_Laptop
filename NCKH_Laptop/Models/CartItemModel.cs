using NCKH_Laptop.Areas.Admin.Models;

namespace NCKH_Laptop.Models
{
    public class CartItemModel
    {
        public int ProductId { get; set; }
        public string ?ProductName { get; set; }

        public int Soluong { set; get; }
        public ProductModel Product { set; get; }
    }
}
