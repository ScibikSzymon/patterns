using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract factory 1");
            CreateProducts(new AbstractFactory1());

            Console.WriteLine("Abstract factory 2");
            CreateProducts(new AbstractFactory2());

            Console.ReadKey();
        }

        private static void CreateProducts(IAbstractFactory abstractFactory)
        {
            var p1 = abstractFactory.CreateA();
            var p2 = abstractFactory.CreateB();

            Console.WriteLine(p1.DoSomethingWithA());
            Console.WriteLine(p2.DoSomethingWithCollaborator(p1));
        }
    }
}
