using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.two
{
    public class LargePizza : Pizza
    {

        public LargePizza()
        {
            this.description = "Large Pizza";
        }

        public override String getDescription()
        {
            return this.description;
        }

        public override double calculateCost()
        {
            return 9.00;
        }

    }
}
