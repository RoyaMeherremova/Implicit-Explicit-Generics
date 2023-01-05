using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class FibonacciService : IFibonacciService
    {
        public void Fibonacci(int n)
        {
            int a = 0; 
            int b=1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b=c;
                Console.WriteLine(c);
            }
            
            
        }
    }
}
