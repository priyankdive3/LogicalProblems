using System;
namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
           
                Console.WriteLine("Select program\n 1. fibonacci series\n 2. perfect number\n 3. prime number\n 4. reverse number\n 5. temperature conversion \n6.Stop Watch \n7.Monthly Payment. \n8.Vending Machine \n9.Days of Week. \n10.Square root");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.Series();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Number();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.PrimeNumCheck();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Number();
                        break;
                    case 5:
                        TemperatureConversion temperatureConversion = new TemperatureConversion();
                        temperatureConversion.Conversion();
                        break;
                    case 6:
                        Stopwatch watch = new Stopwatch();
                        Stopwatch.Watch();
                        break;
                    case 7:
                        MonthlyPayment.Payment();
                        break;
                    case 8:
                        VendingMachine machine = new VendingMachine();
                        machine.amount();
                        break;
                    
                    case 9:
                        DaysOfWeek.Days();
                        break;
                    case 10:
                        SquareRoot.Sqrroot();
                        break;
                    default:
                            Console.WriteLine("Select correct option");
                            break;
                }
            
        }
    }
}
