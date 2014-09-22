using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Test
    {
        static void Main()
        {
            Derived test = new Derived();
            test.i = 1;
            Console.WriteLine(test.i);          // prints 1
            Console.WriteLine(((Base)test).i);  // prints 1
            Console.WriteLine();

            // Derived der = new Base(); 
            // Cannot implicitly convert type 'Inheritance.Base' to 'Inheritance.Derived'. 
            // An explicit conversion exists (are you missing a cast?)

            Base mix = new Derived();
            mix.print(); // prints base (calls base's print) if new
                         // prints derived if virtual-override

            Derived der = new Derived();
            der.print(); // prints derived

            Base bas = new Base();
            bas.print(); // prints base

            ((Base)der).print(); // prints derived if virtual, base if new
            //((Derived)bas).print(); // exception ivalid cast

            Base bas2;
            bas2 = der;

            Derived der2;
            //der2 = bas; // Cannot implicitly convert type 'Inheritance.Base' to 'Inheritance.Derived'.
            //der2 = (Derived)bas; // exception invalid cast
        }
    }

    public class Derived : Base
    {
        public new void print()
        {
            Console.WriteLine("Derived");
        }
    }

    public class Base
    {
        public int i;

        public  void print()
        {
            Console.WriteLine("Base");
        }
    }
}
