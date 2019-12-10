using System.ComponentModel.DataAnnotations;

namespace TINTUCTAYNGUYEN.Models
{
    public class KhuVuc
    {
        [ScaffoldColumn(false)]
        public int KhuVucID { get; set; }
        [Required, StringLength(100), Display(Name = "Tên Khu Vực")]
        public string TenKhuVuc { get; set; }
        [Required, StringLength(1000), Display(Name = "Miêu Tả Khu Vực"),
        DataType(DataType.MultilineText)]
        public string MieuTa { get; set; }
        public string HinhAnh { get; set; }
        [Display(Name = "Price")]
        public float? Gia { get; set; }
        public int? TinhID { get; set; }
        public virtual Tinh Tinh { get; set; }
    }
}