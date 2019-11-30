using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.two
{
    class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            this.description = "Small Pizza";
        }

        public override String getDescription()
        {
            return this.description;
        }

        public override double calculateCost()
        {
            return 3.00;
        }
    
    }
}
