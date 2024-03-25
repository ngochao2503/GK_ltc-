using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_ltc_
{
    public class Bao : TaiLieu
    {
        public DateTime NgayPhatHanh { get; set; }

        public override string LoaiTaiLieu => "B";
    }
}
