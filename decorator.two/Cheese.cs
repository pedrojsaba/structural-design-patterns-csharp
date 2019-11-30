using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.two
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            this.description = "Cheese";
        }

        public override String getDescription()
        {
            return String.Format("{0},{1}", pizza.getDescription(), this.description);
        }

        public override double calculateCost()
        {
            return this.pizza.calculateCost() + 1.25;
        }
    }
}
