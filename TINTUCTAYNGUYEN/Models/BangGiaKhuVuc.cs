using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace TINTUCTAYNGUYEN.Models
{
    public class BangGiaKhuVuc : DropCreateDatabaseAlways<LKgiaCF>
    {
        protected override void Seed(LKgiaCF context)
        {
            GetTinhs().ForEach(c => context.Tinhs.Add(c));
            GetBooks().ForEach(p => context.KhuVucs.Add(p));
        }
        private static List<Tinh> GetTinhs()
        {
            var Tinhs = new List<Tinh>
            {
                new Tinh
                {
                    TinhID = 1,
                    TenTinh = "Đăk Lăk"
                },
                new Tinh
                {
                    TinhID = 2,
                    TenTinh = "Đăk Nông"
                },
                new Tinh
                {
                    TinhID = 3,
                    TenTinh = "Lâm Đồng"
                },
                new Tinh
                {
                    TinhID = 4,
                    TenTinh = "Gia Lai"
                },
                new Tinh
                {
                    TinhID = 5,
                    TenTinh = "Kon Tum"
                }
            };
            return Tinhs;
        }
        private static List<KhuVuc> GetBooks()
        {
            var KhuVucs = new List<KhuVuc> {
                new KhuVuc
                {
                    KhuVucID = 1,
                    TenKhuVuc = "Lâm Hà",
                    MieuTa = "Diện tích tự nhiên Lâm Hà là 97.852,49 ha (978,52 km²). Dân số 133.679 người, vào thời điểm điều chỉnh địa giới hành chính tỉnh Lâm Đồng tháng 4 năm 2009",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33200,
                    TinhID = 3
                    },
                new KhuVuc
                {
                    KhuVucID = 2,
                    TenKhuVuc = "Bảo Lộc",
                    MieuTa = "Bảo Lộc có diện tích 23.256 ha, chiếm 2,38% diện tích toàn tỉnh Lâm Đồng. Phía tây nam giáp huyện Đạ Huoai, các phía còn lại giáp huyện Bảo Lâm.",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 3
                },
                new KhuVuc
                {
                    KhuVucID = 3,
                    TenKhuVuc = "Di Linh",
                    MieuTa = "Cách thành phố Hồ Chí Minh 222 km về hướng đông bắc và cách thành phố Đà Lạt 78 km về phía nam.",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 3
                },
                new KhuVuc
                {
                    KhuVucID = 4,
                    TenKhuVuc = "Cư M'gar ",
                    MieuTa = "dân số toàn huyện trên 162.000 người.",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 1
                },
                new KhuVuc
                {
                    KhuVucID = 5,
                    TenKhuVuc = "Ea H'leo",
                    MieuTa = "Ea H'leo là đất miền trung cao nguyên có nhiều tài nguyên về rừng và đất. Cao su và cà phê là hai loại cây công nghiệp chủ đạo, mang lại thu nhập đáng kể cho người dân.",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 1
                },
                new KhuVuc
                {
                    KhuVucID = 6,
                    TenKhuVuc = "Buôn Hồ",
                    MieuTa = "Thị xã Buôn Hồ nằm ở phía bắc của tỉnh Đắk Lắk, cách thành phố Buôn Ma Thuột 40 km về phía đông bắc dọc theo Quốc lộ 14.",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 1
                },
                new KhuVuc
                {
                    KhuVucID = 7,
                    TenKhuVuc = "Pleiku",
                    MieuTa = "hành phố Pleiku là đô thị phía bắc Tây Nguyên, nằm trên trục giao thông giữa quốc lộ 14, quốc lộ 19 nối thông suốt cả nước, gần ngã ba Đông Dương",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 4
                },
                new KhuVuc
                {
                    KhuVucID = 8,
                    TenKhuVuc = "Ia Grai ",
                    MieuTa = "Ia Grai rộng 1.157,3 km² và có dân số là 112.500 người (theo kết quả điều tra năm 2019)",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 4
                },
                new KhuVuc
                {
                    KhuVucID = 9,
                    TenKhuVuc = "Gia Nghĩa",
                    MieuTa = "Thị xã Gia Nghĩa là tỉnh lỵ tỉnh Đắk Nông, là trung tâm hành chính - chính trị, trung tâm kinh tế, văn hóa xã hội và trung tâm khoa học chuyển giao công nghệ của tỉnh Đắk Nông ",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 2
                },
                new KhuVuc
                {
                    KhuVucID = 10,
                    TenKhuVuc = "Đắk R'lấp",
                    MieuTa = "Đăk R’lấp là huyện nằm về phía Tây Nam của tỉnh Đăk Nông với diện tích tự nhiên 63.420 ha, dân số 89.666 người",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 2
                },
                new KhuVuc
                {
                    KhuVucID = 11,
                    TenKhuVuc = "Kon Tum",
                    MieuTa = "Địa giới tỉnh Kon Tum nằm trong vùng từ 10702015 đến 108032'30 kinh độ Đông và từ 13055'12 đến 15027'15 vĩ độ Bắc.",
                    HinhAnh ="arabicacoffee.jpg",
                    Gia = 33100,
                    TinhID = 5
                },


            };
            return KhuVucs;
        }
    }
}