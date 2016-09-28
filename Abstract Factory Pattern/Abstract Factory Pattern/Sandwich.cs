using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class Sandwich : Dish    // Concrete Product
    {
        private string substance;
        private string bread;
        private string cheese;
        private string toppings;
        private string side;

        public Sandwich(string substance, string bread, string cheese, string toppings, string side)
        {
            this.substance = substance;
            this.bread = bread;
            this.cheese = cheese;
            this.toppings = toppings;
            this.side = side;
        }
        public string getSubstance()
        {
            return substance;
        }

        public string getBread()
        {
            return bread;
        }

        public string getCheese()
        {
            return cheese;
        }

        public string getToppings()
        {
            return toppings;
        }

        public string getSide()
        {
            return side;
        }

        public string getOrder()
        {
            return "-So your order is a " + getSubstance() + " sandwich on fresh " + getBread() + " with " + getCheese() + " cheese, " + getToppings() + " complimented with a side of " + getSide() + ".";
        }
    }
}
