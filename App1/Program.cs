using System.Xml.Linq;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("input number:");
            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                Console.WriteLine("input number");
                number = int.Parse(Console.ReadLine());
            }

            if(number == 0)
            {
                Console.WriteLine("pozostaly 2 proby");
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    Console.WriteLine("pozostala 1 proba");
                    number = int.Parse(Console.ReadLine());
                    if (number == 0)
                    {
                        Console.WriteLine("Program zakonczony");
                    }
                }
            }

        }
    }
}