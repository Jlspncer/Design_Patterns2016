using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public interface Dish  // Abstract Product
    {
        string getSubstance();
        string getToppings();
        string getSide();
        string getOrder();
    }
}
