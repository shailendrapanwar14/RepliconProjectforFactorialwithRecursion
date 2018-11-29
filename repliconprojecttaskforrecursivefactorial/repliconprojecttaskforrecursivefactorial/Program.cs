using System;

namespace repliconprojecttask
{
    class FactorialRecursion
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a Positive integer to calculate factorial :->");

            string line = Console.ReadLine();

            int num;

            if (int.TryParse(line, out num))
            {
                if (num == 0)
                {
                    Console.WriteLine("Factorial of " + num + " is 1");
                }
                else if (num >= 1)
                {
                    Console.WriteLine("Factorial of "
                    + num + " is " + factorial(num));
                }

                else
                {
                    Console.WriteLine("Invalid Input ! \nplease Provide an Positive Integer");
                }
            }
            else

                Console.WriteLine("Invalid Input ! \nplease Provide an Positive Integer");

        }

        static int factorial(int n)
        {
            if (n == 0)
                return 1;

            return n * factorial(n - 1);
        }

    }
}
