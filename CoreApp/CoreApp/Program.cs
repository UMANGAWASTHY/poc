using System;
using StandardLibrary;

namespace CoreApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            IMathOperationService mathService = new MathOperationService(20, 10);
            Console.WriteLine($"Add - {mathService.Add()}");
            Console.WriteLine($"Sub - {mathService.Sub()}");
            Console.WriteLine($"Div - {mathService.Div()}");
            Console.WriteLine($"Mul - {mathService.Mul()}");
            Console.ReadLine();
        }
    }
}
 