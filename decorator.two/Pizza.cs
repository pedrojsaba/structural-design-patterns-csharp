using System;
using System.Collections.Generic;
using System.Text;

namespace decorator.two
{
    public abstract class Pizza
    {
        //
        public String description;
        //protected String description;
        public abstract String getDescription();

        public abstract double calculateCost();
    }
}
