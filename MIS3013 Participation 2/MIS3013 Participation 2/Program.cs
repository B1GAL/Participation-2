using System;

namespace MIS3013_Participation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            double gpa;


            Console.WriteLine("Please enter your first name >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your lastname >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your gpa >>");
            string gpaAsString = Console.ReadLine();
            gpa = Convert.ToDouble(gpaAsString);

            gpa = gpa + .5; // i would really love it if they bumped my gpa up by .5

            string output = "Hello " + firstName + " " + lastName + " " + " we boosted your gpa to " + gpa.ToString("N3");
            //output = $"Hello {firstName} {lastName}! we boosted your gpa to {gpa.ToString("N3")}

            Console.WriteLine(output);
        }
    }
}
