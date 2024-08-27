namespace _03_if_else
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1. Even or Odd:

			double userInput;
			Console.WriteLine("Enter a number");
			userInput = double.Parse(Console.ReadLine());

			if (userInput %2 == 0)
			{
                Console.WriteLine("Number is even");
            }
			else
			{
				Console.WriteLine("Number is odd");
			}
			Console.ReadKey();
		}
	}
}
