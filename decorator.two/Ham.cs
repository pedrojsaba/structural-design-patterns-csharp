using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.two
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza)
        {
            this.description = "Ham";
        }

        public override String getDescription()
        {
            return String.Format("{0},{1}", pizza.getDescription(), this.description);
        }

        public override double calculateCost()
        {
            return this.pizza.calculateCost() + 1.00;
        }

    }
}
