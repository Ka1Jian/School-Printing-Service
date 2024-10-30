using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignent2
{
    internal class Request
    {
        public double PricePer1 = 0.8;
        public double PricePer2 = 2.5;
        public int PricePer3 = 5;
        public int PricePer4 = 15;
        public int PricePer5 = 3;
        public int PricePer6 = 10;

        public int Quantity1 { get; private set; } = 0;
        public int Quantity2 { get; private set; } = 0;
        public int Quantity3 { get; private set; } = 0;
        public int Quantity4 { get; private set; } = 0;
        public int Quantity5 { get; private set; } = 0;
        public int Quantity6 { get; private set; } = 0;

        public void SetQuantities(int quantity1, int quantity2, int quantity3, int quantity4, int quantity5, int quantity6)
        {
            Quantity1 = quantity1;
            Quantity2 = quantity2;
            Quantity3 = quantity3;
            Quantity4 = quantity4;
            Quantity5 = quantity5;
            Quantity6 = quantity6;
        }



        public double calculation()
        {
            double total = (Quantity1 * PricePer1) +
                        (Quantity2 * PricePer2) +
                        (Quantity3 * PricePer3) +
                        (Quantity4 * PricePer4) +
                        (Quantity5 * PricePer5) +
                        (Quantity6 * PricePer6);

            return total;
        }
    }
}
