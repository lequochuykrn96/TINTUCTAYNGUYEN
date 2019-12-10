

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TINTUCTAYNGUYEN.Models
{
    public class Tinh
    {
        [ScaffoldColumn(false)]
        public int TinhID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string TenTinh { get; set; }
        public virtual ICollection<KhuVuc> KhuVucs { get; set; }
    }
}