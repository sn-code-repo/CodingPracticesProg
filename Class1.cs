using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProg
{
    class A
    {
        public void Show()
        {
            Console.WriteLine("Hello: Base Class!");
            Console.ReadLine();
        }
    }
    class B : A
    {
        public void Show()
        {
            Console.WriteLine("Hello: Derived Class!");
            Console.ReadLine();
        }
    }
     
    class Class1
    {
        public void Show()
        {
            A a = new A();
            a.Show();
            B b = new B();
            b.Show();
        }
    }    
}
