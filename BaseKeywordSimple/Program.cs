using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeywordSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("asd");
            Console.ReadLine();

            // B b=new B();
            B b = new B(10, 15, 20, 25);

            Console.ReadLine();
        }
    }


    class A
    {
        public A(int a, int b)
        {
            Console.WriteLine("A yapılandırıcısı çalıştı. Parametreler {0},{1}", a, b);
        }
    }

    class B : A
    {
        public B(int a, int b, int c, int d) : base(a, b) // base : A(10,15) demektir
        {
            Console.WriteLine("B yapılandırıcı çalıştı. Parametreler {0},{1}", c, d);
        }
    }



}
