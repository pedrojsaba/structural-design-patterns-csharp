using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    class ShoppingPortalClient
    {
        static void Main(string[] args)
        {
            ITarget adapter = new VendorAdapter();
            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}
