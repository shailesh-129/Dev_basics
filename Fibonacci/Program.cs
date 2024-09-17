using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1=0, n2=1;
            Console.WriteLine("enter the fibonacci");
            int n3,sum=0;
            n3 = int.Parse(Console.ReadLine());
            Console.Write(n1);
            Console.WriteLine(n2);
            for (int i=n1;i<n3;i++)
                
            {
                n1 = n2;
                n2 = i;
                sum += n2;
                
                Console.WriteLine(sum);
            }
            Console.ReadLine();
        }
    }
}
