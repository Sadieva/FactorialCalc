using System;

namespace FactorialCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            { 

                Console.WriteLine("MENUE");
            Console.WriteLine("1. start program");
            Console.WriteLine("2. exit program");

            string option = Console.ReadLine();

            switch (option)
            {

                case "1":
                    Console.Write("enter a number: ");
                    int f = Convert.ToInt32(Console.ReadLine());

                    int result = 1;
                    int i = 1;

                    while (f >= i)
                    {
                        result = result * i;
                        i++;
                    }
                    Console.WriteLine("the factorial of " + f + " is " + result);
                    break;




                case "2":
                    running = false;
                    break;





                default:
                    Console.WriteLine("error, please pick a number");
                    break;
            }
            }







        }
    }
}
