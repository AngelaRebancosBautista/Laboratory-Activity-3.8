using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Filtering Application");
            Console.WriteLine("-");

            List<int> numbers = new List<int>();
            Console.WriteLine("Please enter 10 numbers, one at a time:");

            for (int i = 0; i < 10; i++)
            {
                int input;
                while (true)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out input))
                    {
                        numbers.Add(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
            }
            List<int> filteredNumbers = numbers.Where(num => num > 50).ToList();

            Console.WriteLine("\nResults");
            Console.WriteLine($"Total numbers entered: {numbers.Count}");
            Console.WriteLine($"Numbers greater than 50: {filteredNumbers.Count}");

            Console.WriteLine("\nOriginal numbers:");
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("\nFiltered numbers (>50):");
            Console.WriteLine(string.Join(", ", filteredNumbers));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
        

    

