using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class Pasta : Dish    // Concrete Product
    {
        private string pasta;
        private string sauce;
        private string substance;
        private string toppings;
        private string side;

        public Pasta(string pasta, string sauce, string meat, string extra, string side)
        {
            this.pasta = pasta;
            this.sauce = sauce;
            this.substance = meat;
            this.toppings = extra;
            this.side = side;
        }

        public string getPasta()
        {
            return pasta;
        }

        public string getSauce()
        {
            return sauce;
        }

        public string getSubstance()    //also known as the meat
        {
            return substance;
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
            return "-So your order is a " + getPasta() + " with " + getSauce() + " and " + getSubstance() + " with " + getToppings() + " complimented with a side of " + getSide() + ".";
        }
    }
}
