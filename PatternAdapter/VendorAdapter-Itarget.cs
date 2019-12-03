﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{


    class VendorAdapter : ITarget
    {
        public List<string> GetProducts()
        {
            VendorAdaptee adaptee = new VendorAdaptee();
            return adaptee.GetListOfProducts();
        }
    }



}
