using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int Add = calculator.Add(6, 6);
            int Subs = calculator.subs(10, 5);
            int Mul = calculator.Mul(10, 5);
            float div= calculator.div(10, 5);
            Console.WriteLine(Add);
            Console.WriteLine(Subs);
            Console.WriteLine(Mul);
            Console.WriteLine(div);
            Console.ReadLine();
        }
    }
}
