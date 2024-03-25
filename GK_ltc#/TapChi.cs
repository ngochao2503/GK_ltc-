using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_ltc_
{
    public class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public int TrangPhatHanh { get; set; }

        public override string LoaiTaiLieu => "TC";
    }
}
