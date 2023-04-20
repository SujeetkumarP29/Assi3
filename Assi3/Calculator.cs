using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            int Add = a+b;
            return Add;
        }
        public int subs(int a, int b)
        {
            int subs = a - b;
            return subs;
        }
        public int Mul(int a, int b)
        {
            int Mul = a * b;
            return Mul;
        }
        public float div(int a, int b)
        {
            float div = a / b;
            return div;
        }

    }
}
