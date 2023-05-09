using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers amount : ");
            int n = int.Parse(Console.ReadLine());
           
            SquareRoot calculator = new SquareRoot();
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                int number = int.Parse(Console.ReadLine());
                double squareRoot = calculator.FindSquareRoot(number);
                Console.WriteLine(squareRoot);
            }
        }
    }
}
