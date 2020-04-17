using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPlusProj
{
    class createrandom
    {
        public double createrandomnumber()
        {
            double h;
            Random a = new Random();
            h = a.NextDouble() * (21.1) + 0.1;
            return h;
        }
    }
}
