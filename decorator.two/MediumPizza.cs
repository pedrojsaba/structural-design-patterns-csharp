using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.two
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            this.description = "Medium Pizza";
        }

        public override String getDescription()
        {
            return this.description;
        }

        public override double calculateCost()
        {
            return 6.00;
        }
    }
}
