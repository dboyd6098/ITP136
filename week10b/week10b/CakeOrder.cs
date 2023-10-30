using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10b
{
    class CakeOrder
    {
        public CakeOrder(string n, string des, string dec)
        {
            OrderName = n;
            OrderDesign = dec;
            OrderDecoration = des;
        }

        public string OrderName { get; set; }
        public string OrderDesign { get; set; }
        public string OrderDecoration { get; set; }


    }
}
