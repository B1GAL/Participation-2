using System;

namespace participation_2_4_2021
{
    class Program
    {
        static void Main(string[] args)
        {
               const double MAGIC_NUMBER = 7.777;

            //SUPER_NUMBER = 69;

            Console.WriteLine("Please enter the first number");
            string answer = Console.ReadLine();
            double num1 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter the second number");
            answer = Console.ReadLine();
            double num2 = Convert.ToDouble(answer);

            Console.WriteLine("Please enter the third number");
            answer = Console.ReadLine();
            double num3 = Convert.ToDouble(answer);

            Console.WriteLine($"{num1} + {num2} + {num3} = {(num1 + num2 + num3).ToString("N3")}");

            double magicNumberTimesSum = magicNumberTimesSum * SUPER_NUMBER;


            Console.WriteLine($"Your sum multiplied by our super number is {magicNumberTimesSum.ToString}");
        }
    }
}
