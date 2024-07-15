using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
   class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = Divide(num1, num2);

                Console.WriteLine($"The result of {num1} divided by {num2} is: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a valid number.");
                Console.WriteLine($"Details: {ex.Message}");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Details: {ex.Message}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("Thank you for using our program.");
                
                Console.ReadKey();
            }
             int Divide(int numerator, int denominator)
            {
                return numerator / denominator;
            }
        }
    }
}
