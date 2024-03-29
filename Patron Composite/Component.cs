﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Composite
{

    abstract class Component

    {
        protected string name;

        // Constructor

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }



}
