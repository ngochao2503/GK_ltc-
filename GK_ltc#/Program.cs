using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_ltc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách dữ liệu
            List<DanhMuc> dsDanhMuc116 = new List<DanhMuc>()
    {
        new DanhMuc { Id = 1, TenDanhMuc = "Sach" },
        new DanhMuc { Id = 2, TenDanhMuc = "Tap chi" },
        new DanhMuc { Id = 3, TenDanhMuc = "Bao" },
    };

            List<TaiLieu> dsTaiLieu116 = new List<TaiLieu>()
    {
        new Sach
        {
            MaXuatBan = "S1",
            TenTaiLieu = "C# cw ban",
            NhaPhatHanh = "NXB Giao duc",
            DanhMucId = 1,
            TenTacGia = "John Doe",
            SoTrang = 300
        },
        new Sach
        {
            MaXuatBan = "S2",
            TenTaiLieu = "C# nang cao",
            NhaPhatHanh = "NXB Giáo dục",
            DanhMucId = 1,
            TenTacGia = "John Do",
            SoTrang = 100
        },
        new Sach
        {
            MaXuatBan = "S3",
            TenTaiLieu = "C# thuc chien",
            NhaPhatHanh = "NXB Giáo dục",
            DanhMucId = 1,
            TenTacGia = "John D",
            SoTrang = 200
        },
        new TapChi
        {
            MaXuatBan = "TC1",
            TenTaiLieu = "Tạp chí khoa học",
            NhaPhatHanh = "NXB Khoa học",
            DanhMucId = 2,
            SoPhatHanh = 10,
            TrangPhatHanh = 50
        },
        new Bao
        {
            MaXuatBan = "B1",
            TenTaiLieu = "Báo Thanh Niên",
            NhaPhatHanh = "NXB Thanh Niên",
            DanhMucId = 3,
            NgayPhatHanh = new DateTime(2024, 1, 15)
        },
        new Bao
        {
            MaXuatBan = "B2",
            TenTaiLieu = "Bao Nien",
            NhaPhatHanh = "NXB Thanh Niên",
            DanhMucId = 3,
            NgayPhatHanh = new DateTime(2024, 3, 15)
        },
        new Bao
        {
            MaXuatBan = "B3",
            TenTaiLieu = "Bao Thanh",
            NhaPhatHanh = "NXB Thanh Niên",
            DanhMucId = 3,
            NgayPhatHanh = new DateTime(2020, 3, 15)
        },
    };

            // Tìm theo loại
            Console.WriteLine("co Sach, Bao, TapChi, tuong duong voi S,B,TC");

            Console.WriteLine("nhap thu ban muon tim theo loai:");
            string loaiTaiLieu116 = Console.ReadLine();
            Console.WriteLine("ds theo loai do la:");
            var dsTaiLieuTheoLoai116 = dsTaiLieu116.Where(t => t.LoaiTaiLieu == loaiTaiLieu116);
            foreach (var taiLieu in dsTaiLieuTheoLoai116)
            {
                Console.WriteLine($"{taiLieu.MaXuatBan} - {taiLieu.TenTaiLieu}");
            }

            // Tìm báo có ngày phát hành trong tháng 3 năm 24
            Console.WriteLine("\n\nTìm bao co ngay phat hanh trong thang 3 nam 24:");
            Console.ReadKey();
            var dsBaoThang3116 = dsTaiLieu116.OfType<Bao>().Where(b => b.NgayPhatHanh.Month == 3 && b.NgayPhatHanh.Year == 2024);
            foreach (var bao in dsBaoThang3116)
            {
                Console.WriteLine($"{bao.MaXuatBan} - {bao.TenTaiLieu} - {bao.NgayPhatHanh}");
            }
        }
    }
}
