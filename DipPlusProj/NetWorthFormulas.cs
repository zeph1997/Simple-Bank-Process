using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipPlusProj
{
    class NetWorthFormulas
    {

        private double coe1, coe2, coe3, coe4;
        private double cpf1, cpf2, cpf3;
        private double pua1, pua2, pua3;
        private double ia1, ia2, ia3;
        private double lia1, lia2, lia3, lia4, lia5;

        public NetWorthFormulas(double coe1, double coe2, double coe3, double coe4, double cpf1, double cpf2, double cpf3, double pua1, double pua2, double pua3, double ia1, double ia2, double ia3, double lia1, double lia2, double lia3, double lia4, double lia5)
        {
            this.coe1 = coe1;
            this.coe2 = coe2;
            this.coe3 = coe3;
            this.coe4 = coe4;
            this.cpf1 = cpf1;
            this.cpf2 = cpf2;
            this.cpf3 = cpf3;
            this.pua1 = pua1;
            this.pua2 = pua2;
            this.pua3 = pua3;
            this.ia1 = ia1;
            this.ia2 = ia2;
            this.ia3 = ia3;
            this.lia1 = lia1;
            this.lia2 = lia2;
            this.lia3 = lia3;
            this.lia4 = lia4;
            this.lia5 = lia5;
        }

        public double totalcoe()
        {
            double totalcoe;
            totalcoe = coe1 + coe2 + coe3 + coe4;
            return totalcoe;
        }

        public double totalcpf()
        {
            double totalcpf;
            totalcpf = cpf1 + cpf2 + cpf3;
            return totalcpf;
        }

        public double totalpua()
        {
            double totalpua;
            totalpua = pua1 + pua2 + pua3;
            return totalpua;
        }

        public double totalia()
        {
            double totalia;
            totalia = ia1 + ia2 + ia3;
            return totalia;
        }

        public double totallia()
        {
            double totallia;
            totallia = lia1 + lia2 + lia3 + lia4 + lia5;
            return totallia;
        }

        public double totalassets()
        {
            double totalassets;
            totalassets = coe1 + coe2 + coe3 + coe4 + cpf1 + cpf2 + cpf3 + pua1 + pua2 + pua3 + ia1 + ia2 + ia3;
            return totalassets;
        }

        public double networth()
        {
            double networth;
            networth = coe1 + coe2 + coe3 + coe4 + cpf1 + cpf2 + cpf3 + pua1 + pua2 + pua3 + ia1 + ia2 + ia3 - (lia1 + lia2 + lia3 + lia4 + lia5);
            return networth;
        }

    }
}
