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

			// 3. Grade system

            Console.WriteLine("Enter your test score:");
			double userScore = double.Parse(Console.ReadLine());

            if (userScore >= 90 && userScore <= 100)
			{
                Console.WriteLine("A");
            }
            else if (userScore >= 80 && userScore <= 89)
            {
                Console.WriteLine("B");
            }
			else if (userScore >= 70 && userScore <= 79)
			{
				Console.WriteLine("C");
			}
			else if (userScore >= 60 && userScore <= 69)
			{
				Console.WriteLine("D");
			}
			else if (userScore < 60 )
			{
				Console.WriteLine("F");
			}
			else
			{
				Console.WriteLine("invalid score");
			}
            Console.ReadKey();


		}
	}
}
