using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Models
{
    public class CotThep
    {
        public CotThep() { }

        public CotThep(string loai, double rs)
        {
            Loai = loai;
            Rs = rs;
        }

        public string Loai { get; set; }
        public double Rs { get; set; }
    }
}
