using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class AmstrongNumber
    {
        public void Check(int num)
        {
            int sum = 0;
            for(int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (num == sum)
                Console.WriteLine("Number Provided is an PerfectNumber");
            else
                Console.WriteLine("Not an PerfectNumber");
        }
    }
}
