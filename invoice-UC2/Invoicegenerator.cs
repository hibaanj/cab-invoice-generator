using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice_UC2
{
    public class Invoicegenerator
    {
        public int Costptime = 1;
        public int costpkm = 10;
        public int minfare = 5;

        public double totalcost(double distance, double time)
        {
            double totalFare = distance * costpkm + time * Costptime;
            if (totalFare < minfare)
            {
                return minfare;
            }
            return totalFare;
        }

    }
}
