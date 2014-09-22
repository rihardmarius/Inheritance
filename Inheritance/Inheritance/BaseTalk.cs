using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    using System;

    public class Parent
    {
        string parentString;

        public Parent()
        {
            Console.WriteLine("Parent Constructor.");
        }
        
        public Parent(string passedString)
        {
            parentString = passedString;
            Console.WriteLine(parentString);
        }
        
        public void print()
        {
            Console.WriteLine("I'm a Parent Class.");
        }
    }


    public class Child : Parent
    {
        public Child() : base("From Derived")
        {
            Console.WriteLine("Child Constructor.");
        }
        
        public new void print()
        {
            base.print();
            Console.WriteLine("I'm a Child Class.");
        }

        public void print2()
        {
            Console.WriteLine("I'm a Child method.");
        }

        public static void Main()
        {
            Child child = new Child();
            child.print2();
            ((Parent)child).print(); // print2 no es parte de parent
            Console.WriteLine();
        }
    }
}
