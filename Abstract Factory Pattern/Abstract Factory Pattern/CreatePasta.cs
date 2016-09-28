using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class CreatePasta : CreateDish  // Concrete Factory 
    {
        private string pasta;
        private string sauce;
        private string meat;
        private string extra;
        private string side;

        public CreatePasta(string pasta, string sauce, string meat, string extra, string side)
        {
            this.pasta = pasta;
            this.sauce = sauce;
            this.meat = meat;
            this.extra = extra;
            this.side = side;
        }

        public Dish createDish()
        {
            return new Pasta(pasta, sauce, meat, extra, side);
        }
    }
}
