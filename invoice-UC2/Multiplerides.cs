using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice_UC2
{
    public class Multiplerides
    {
        public program[] distance { get; private set; }
        public object time { get; private set; }

        public double totalcost(program[] distance, object time)
        {
            double totalFare = 0;
            foreach (program Program in distance)
            {
                totalFare += this.totalcost(distance,time);
            }
            return totalFare;
        }
    }
}
