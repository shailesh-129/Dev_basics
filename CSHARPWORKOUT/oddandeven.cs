using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPWORKOUT
{
    public class oddandeven
    {
        public oddandeven()
        {
            Console.WriteLine("Please enter until which number you need to the even numbers");
        }
        public void even()
        {
            int n1;
           // Console.WriteLine("Please enter the first number:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("the even values are");
            for (int i=0;i<n1;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.WriteLine("the odd values are");
            for (int i=0;i<n1;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
