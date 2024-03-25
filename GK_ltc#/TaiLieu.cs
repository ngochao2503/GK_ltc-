using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_ltc_
{
    public class TaiLieu
    {
        public string MaXuatBan { get; set; }
        public string TenTaiLieu { get; set; }
        public string NhaPhatHanh { get; set; }
        public int DanhMucId { get; set; }

        public virtual string LoaiTaiLieu { get; }
    }
}
