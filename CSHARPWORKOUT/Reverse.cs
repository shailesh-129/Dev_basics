using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPWORKOUT
{
    class Reverse
    {
        public void reverse()
        {
            int n1;
            Console.WriteLine("enter the reverse value from the number mentioned is");
            n1 = int.Parse(Console.ReadLine());
            for(int i=n1;i>=1;--i)
            {
                Console.WriteLine(i);
                //i--;
            }
            Console.ReadLine();
        }
        
    }
}
