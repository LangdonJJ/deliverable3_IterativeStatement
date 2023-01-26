using System.Diagnostics.Metrics;

namespace deliverable3_IterativeStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int number = 0;
            string type = "";
            try
            {
                while ( (number < 1) || (number > 100) ) // Number is not between 1 and 100 so keep asking until it is
                {
                    Console.WriteLine("Please enter an integer between 1 to 100: ");
                    number = int.Parse(Console.ReadLine());
                }
                while (type != "even" && type != "odd") // The string type is not equal to even AND odd so keep asking until it is
                {
                    Console.WriteLine("Do you want to see odd or an even numbers? ");
                    type = Console.ReadLine().ToLower();
                }

                for (i = 0; i <= number; i++)
                {
                    if (type == "even" && i % 2 == 0)
                    {
                        Console.WriteLine(i);

                    }
                    else if (type == "odd" && i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Please follow instructions");
            }
        }
    }
}