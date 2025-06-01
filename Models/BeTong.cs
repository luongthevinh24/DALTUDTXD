using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67TH3_LTUDTXD_HUCE_20_DuongThiDuyen_0257867_67TH3.Models
{
    public class BeTong
    {

        public BeTong() { }

        public BeTong(string mac, double rb, double rbt)
        {
            Mac = mac;
            Rb = rb;
            Rbt = rbt;
        }

        public string Mac { get; set; }
        public double Rb { get; set; }
        public double Rbt { get; set; }
        public double B { get; set; }
        public double H { get; set; }
        public double hf { get; set; }
        public double bf { get; set; }
        public double L { get; set; }

       
    }



}
