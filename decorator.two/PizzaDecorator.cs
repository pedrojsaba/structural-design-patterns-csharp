using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.two
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override String getDescription()
        {
            return pizza.description;
        }

        public override double calculateCost()
        {
            return pizza.calculateCost();
        }
    }
}
