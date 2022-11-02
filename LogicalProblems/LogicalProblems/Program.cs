namespace LogicalProblems
{
    public class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Logical Prolem Solution");

            //FibonacciSeries series = new FibonacciSeries();
            //series.Print(8);

            AmstrongNumber amstrongNumber = new AmstrongNumber();
            amstrongNumber.Check(5);
        }
    }
}
