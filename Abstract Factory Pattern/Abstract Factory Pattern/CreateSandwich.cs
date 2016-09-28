using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class CreateSandwich : CreateDish   // Concrete Factory
    {
        private string substance;
        private string bread;
        private string cheese;
        private string toppings;
        private string side;

        public CreateSandwich(string substance, string bread, string cheese, string toppings, string side)
        {
            this.substance = substance;
            this.bread = bread;
            this.cheese = cheese;
            this.toppings = toppings;
            this.side = side;
        }

        public Dish createDish()
        {
            return new Sandwich(substance, bread, cheese, toppings, side);
        }
    }
}
