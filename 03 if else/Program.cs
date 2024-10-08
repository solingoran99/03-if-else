﻿using System.Collections.Concurrent;

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

			Console.WriteLine("Enter your test score to find out your grade:");
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
				Console.WriteLine("invalid score.");
			}

			// 4. Leap Year Checker

			Console.WriteLine("Enter a year:");
			int userYear = int.Parse(Console.ReadLine());

            if (userYear %4 == 0 && userYear != 100 || userYear %400 == 0)
			{
				Console.WriteLine($"{userYear} is a leap year.");
			}
			else
			{
				Console.WriteLine($"{userYear} is not leap year.");
			}

			// 5. Maximum of Three

			int num1;
			int num2;
			int num3;
			int max;
            Console.WriteLine("Enter three whole numbers to find out the biggest number.\nEnter the first number:");
			num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
			num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
			num3 = int.Parse(Console.ReadLine());

			if (num1 > num2 && num1 > num3)
			{
				max = num1;
			}
			else if (num2 > num1 && num2 > num3)
			{
				max = num2;
			}
			else
			{
				max = num3;
			}
            Console.WriteLine($"The biggest number is {max}");

			//6. Positive, Negative or Zero
			
			Console.WriteLine("Enter a number to find out if the number is positive, negative or zero:");
			string input =(Console.ReadLine());

			double userNum;

			if(double.TryParse(input, out userNum))
			{
				if (userNum > 0)
				{
                    Console.WriteLine($"{userNum} is positive.");
                }
				else if (userNum < 0)
				{
                    Console.WriteLine($"{userNum} is negative");
                }
				else
				{
                    Console.WriteLine("Number is zero.");
                }
			}
			else
			{
                Console.WriteLine("Invalid. Enter a number.");
            }

			//7. Discount System

			Console.WriteLine("Enter the total amount of your purchase:");
			double totalAmount = double.Parse(Console.ReadLine());

			if (totalAmount > 1000)
			{
				double discount = totalAmount * 0.1;
				double discountPrice = totalAmount - discount;
				
                Console.WriteLine($"Your total with a discount of 10% is: {discountPrice}.");
            }
			else
			{
                Console.WriteLine($"Your total is: {totalAmount}.");
            }
			
			// 8. Weekdays

			Console.WriteLine("Enter a number (1-7) to find out the weekday:");
			int weekNumber = int.Parse(Console.ReadLine());

			if (weekNumber == 1)
			{
                Console.WriteLine("Monday");
            } 
			else if (weekNumber == 2)
			{
                Console.WriteLine("Tuesday");
            }
			else if (weekNumber == 3)
			{
				Console.WriteLine("Wednesday");
			}
			else if (weekNumber == 4)
			{
				Console.WriteLine("Thursday");
			}
			else if (weekNumber == 5)
			{
                Console.WriteLine("Friday");
            }
			else if (weekNumber == 6)
			{
                Console.WriteLine("Saturday");
            }
			else
			{
                Console.WriteLine("Sunday");
            }
			

			// 9. Password Checker

			string correctPassword = "CSharp123";

            Console.WriteLine("Enter your password to log in:");
			string passwordInput = Console.ReadLine();

			if (passwordInput == "CSharp123")
			{
                Console.WriteLine("Acces granted!");
            }
			else
			{
                Console.WriteLine("Acces denied!");
            }
			

			Console.WriteLine("To convert from Fahrenheit to Celsius type FTC, from Celcius to Fahrenheit CTF:");
			string userChoice = Console.ReadLine();

			if (userChoice.ToUpper() == "FTC")
			{
                Console.WriteLine("Enter the temperature:");
				double temperature = double.Parse(Console.ReadLine());
				double convertedTemperaute = temperature / 2 - 30;
                Console.WriteLine($"The temperature is{convertedTemperaute}");
            }
			else if (userChoice.ToUpper() == "CTF")
			{
                Console.WriteLine("Enter the temperature:");
				double temperature = double.Parse(Console.ReadLine());
				double convertedTemperature = temperature * 2 + 30;
                Console.WriteLine($"The temperature is {convertedTemperature}");
            }
            Console.ReadKey();


		}
	}
}
