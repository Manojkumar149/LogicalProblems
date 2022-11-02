using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class FibonacciSeries
    {
        public void Print(int num)
        {
            int firstNum = 0, seconfNum = 1, thirdNum = 0;
            Console.WriteLine(firstNum + "\n" + seconfNum);
            for (int i = 0; i < num; i++) {
                thirdNum = firstNum + seconfNum;
                firstNum = seconfNum;
                seconfNum = thirdNum;
                Console.WriteLine(thirdNum);
            
            }
        }
    }
}
