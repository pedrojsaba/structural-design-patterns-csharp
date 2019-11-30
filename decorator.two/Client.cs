using System; 

namespace decorator.two
{
    class Client
    {
        static void Main(string[] args)
        {
            //Pizza largePizza = new LargePizza();
            Pizza smallPizza = new SmallPizza();
            smallPizza = new Cheese(smallPizza);
            smallPizza = new Ham(smallPizza);
            smallPizza = new Peppers(smallPizza);

            Console.WriteLine(smallPizza.getDescription());
            Console.WriteLine(round(smallPizza.calculateCost()));
        }

        public static double round(double value)
        { 
            return value;
        }
    }
}
