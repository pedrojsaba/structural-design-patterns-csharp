using System;
using System.Collections.Generic;

namespace Patron_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patron Conposite hecho por Mario Puma");

            Composite root = new Composite("raíz");
            root.Add(new Leaf("Hoja A"));
            root.Add(new Leaf("Hoja B"));

            Composite comp = new Composite("X Compuesto");
            comp.Add(new Leaf("Hoja XA"));
            comp.Add(new Leaf("Hoja XB"));

            root.Add(comp);
            root.Add(new Leaf("Hoja C"));

            // Add and remove a leaf

            Leaf leaf = new Leaf("Hoja D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree

            root.Display(1);

            // Wait for user

            Console.ReadKey();
        }
    }






}


