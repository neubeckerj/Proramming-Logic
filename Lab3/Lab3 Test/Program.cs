using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of Adults         : ");
            int adultCount = int.Parse(Console.ReadLine());
            Console.Write("Number of Children       : ");
            int childCount = int.Parse(Console.ReadLine());
            Console.Write("Number of Seniors        : ");
            int seniorCount = int.Parse(Console.ReadLine());
            int totalPeople = childCount + adultCount + seniorCount;
            Console.Write("Is this a Matinee? (y/n) : ");
            bool isMatinee = Console.ReadLine().ToLower().StartsWith("y");
            double totalTicketPrice = 0;
            totalTicketPrice += adultCount * (isMatinee ? 5.99 : 10.99);
            totalTicketPrice += childCount * (isMatinee ? 3.99 : 6.99);
            totalTicketPrice += seniorCount * (isMatinee ? 4.50 : 8.50);

            Console.Write("How Many Small Sodas?    : ");
            totalTicketPrice += int.Parse(Console.ReadLine()) * 3.5;
            Console.Write("How Many Large Sodas?    : ");
            totalTicketPrice += int.Parse(Console.ReadLine()) * 5.99;
            Console.Write("How Many Hot Dogs?       : ");
            totalTicketPrice += int.Parse(Console.ReadLine()) * 3.99;
            Console.Write("How Many Popcorns?       : ");
            int popcorn = int.Parse(Console.ReadLine());
            totalTicketPrice += popcorn * 4.5;
            Console.Write("How Many Candies?        : ");
            int Candy = int.Parse(Console.ReadLine());
            totalTicketPrice += Candy * 1.99;

            Console.Write("How Many With Both Popcorn & Large Soda? : ");
            totalTicketPrice -= int.Parse(Console.ReadLine()) * 2;
            if (totalPeople >= 3 && popcorn >= 1)
            {
                totalTicketPrice -= 4.5;
            }
            while (Candy >= 4)
            {
                totalTicketPrice -= 1.99;
                Candy -= 4; 
            }
            Console.Write("Total Price = " + "$" + totalTicketPrice );
            Console.ReadKey();
        }
    }
}
