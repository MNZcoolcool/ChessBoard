using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Mata in en siffra: "); // Asks the user to enter a number
            int number = Int32.Parse(Console.ReadLine()); //Converts the input from a string to an integer 

            for (int row = 0; row < number; row++) // Loops through each row   
            {
                for (int column = 0; column < number; column++) // Loops through each column
                {
                    if ((row + column) % 2 == 0) // Checks if the sum of the row and column is even. Since even numbers are divisible by 2
                    {
                        Console.Write("□"); //Prints black square if the sum is even
                    }
                    else
                    {
                        Console.Write("■"); //Prints white square if the sum is odd
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

