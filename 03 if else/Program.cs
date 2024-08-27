namespace _03_if_else
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1. Even or Odd:

			double userInput;
			Console.WriteLine("Enter a number:");
			userInput = double.Parse(Console.ReadLine());

			if (userInput %2 == 0)
			{
                Console.WriteLine("Number is even");
            }
			else
			{
				Console.WriteLine("Number is odd");
			}
			
            //2. Age Bracket

            Console.WriteLine("Enter your age.");
			int userAge = int.Parse(Console.ReadLine());

			if (userAge < 13)
			{
                Console.WriteLine("You are a child.");
            }
			else if (userAge >= 13 &&  userAge <= 19)
			{
                Console.WriteLine("You're a teenager");
            }
			else
			{
                Console.WriteLine("You are an adult.");
            }
			Console.ReadKey();


		}
	}
}
