namespace LogicalProblems
{
    public class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Logical Problem Solution");

            //FibonacciSeries series = new FibonacciSeries();
            //series.Print(8);

            //AmstrongNumber amstrongNumber = new AmstrongNumber();
            //amstrongNumber.Check(5);

            //PrimeNumber primeNumber = new PrimeNumber();
            //primeNumber.CheckPrime(5);

            //ReverseNumber reverseNumber = new ReverseNumber();
            //reverseNumber.Reverse(25);
            //CouponNumber.GenerateCoupons(10);
            bool flag = true;
             Console.WriteLine(" 1.FibonacciSeries \n 2.AmstrongNumber \n 3.PrimeNumber \n 4.ReverseNumber \n 5.CouponNumber \n 6.StopWatch");
             int check = Convert.ToInt32(Console.ReadLine());
             while (flag)
             {
                 switch (check)
                 {
                     case 1:
                         FibonacciSeries series = new FibonacciSeries();
                         series.Print(8);
                         break;
                     case 2:
                         AmstrongNumber amstrongNumber = new AmstrongNumber();
                         amstrongNumber.Check(5);
                         break;
                     case 3:
                         PrimeNumber primeNumber = new PrimeNumber();
                         primeNumber.CheckPrime(5);
                         break;
                     case 4:
                         ReverseNumber reverseNumber = new ReverseNumber();
                         reverseNumber.Reverse(25);
                         break;
                    case 5:
                        CouponNumber.GenerateCoupons(10);
                        break;
                    case 6:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.Start();
                        break;
                    default:
                         break;
                 }
                break;
             }
           
        }
    }
}
