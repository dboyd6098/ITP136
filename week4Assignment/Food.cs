using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4Assignment
{
    public class Food
    {
        int foodId;
        string name, description;
        double cost;

        public int FoodId
        {
            get { return foodId; }
            set { foodId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
