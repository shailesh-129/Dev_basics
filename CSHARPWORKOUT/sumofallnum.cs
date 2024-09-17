using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPWORKOUT
{
    class sumofallnum
    {
        public void sum()
        {
            Console.WriteLine("Enter until which value you need to sum");
            int n1 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=0;i<n1;i++)
            {
           
                sum += i;
            }
            Console.WriteLine("the sum of numbers are" + sum);
            Console.ReadLine();
        }
    }
}
