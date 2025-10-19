using System.Numerics;
using System.Security.Principal;
using System.Xml;

namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charge = 15;
            Console.WriteLine("Enter number of people in the group");
            int people = Convert.ToInt32(Console.ReadLine());
            if (people >= 6)
            {
                int total = (charge * people) - 15;
                Console.WriteLine("Your total is £" + total);
            }
            else
            {
                int total = charge * people;
                Console.WriteLine("Your total is £" + total);
            }

        }
    }
}