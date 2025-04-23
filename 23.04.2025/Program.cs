using System;
using System.Collections.Generic;

namespace TaskNamespace
{
    public class Task1
    {
        public int check(int number)
        {
            if (number < 1 || number > 100)
            {
                Console.WriteLine("Error.");
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public int task(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
                return 0;
            }
            if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
                return 0;
            }
            if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
                return 0;
            }
            else
            {
                Console.WriteLine(number);
                return 0;
            }
        }

        public class Task2
        {
            public void task(int number, int percent)
            {
                double newNumber = number * percent / 100;
                Console.WriteLine($"{percent}% of {number} = {newNumber}");
            }
        }

        public class Task3
        {
            public void task()
            {
                Console.WriteLine("Enter four digits one at a time:");

                int d1 = Convert.ToInt32(Console.ReadLine());
                int d2 = Convert.ToInt32(Console.ReadLine());
                int d3 = Convert.ToInt32(Console.ReadLine());
                int d4 = Convert.ToInt32(Console.ReadLine());

                if (d1 < 0 || d1 > 9 || d2 < 0 || d2 > 9 || d3 < 0 || d3 > 9 || d4 < 0 || d4 > 9)
                {
                    Console.WriteLine("Error.");
                    return;
                }

                int result = d1 * 1000 + d2 * 100 + d3 * 10 + d4;

                Console.WriteLine($"Result: {result}");
            }
        }

        public class Task4
        {

            public int сheck1()
            {
                int number;

                do
                {
                    Console.WriteLine("Enter a six-digit number:");
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number < 100000 || number > 999999)
                    {
                        Console.WriteLine("Error. Number must be six digits.");
                    }

                } while (number < 100000 || number > 999999);

                return number;
            }


            public (int, int) indexes()
            {
                Console.WriteLine("Enter first index (1-6):");
                int index1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second index (1-6):");
                int index2 = Convert.ToInt32(Console.ReadLine());

                return (index1, index2);
            }

            public (int, int) check2()
            {
                int index1, index2;

                do
                {
                    var result = indexes();
                    index1 = result.Item1;
                    index2 = result.Item2;

                    if (index1 < 1 || index1 > 6 || index2 < 1 || index2 > 6)
                    {
                        Console.WriteLine("Error. Indexes must be between 1 and 6.");
                    }

                } while (index1 < 1 || index1 > 6 || index2 < 1 || index2 > 6);

                return (index1, index2);
            }


            public void task()
            {
                int number = сheck1();
                var (index1, index2) = check2(); 

                List<int> digits = new List<int>
                {
                    number / 100000 % 10,
                    number / 10000 % 10,
                    number / 1000 % 10,
                    number / 100 % 10,
                    number / 10 % 10,
                    number % 10
                };

                (digits[index1 - 1], digits[index2 - 1]) = (digits[index2 - 1], digits[index1 - 1]);

     
                int newNumber = digits[0] * 100000 + digits[1] * 10000 + digits[2] * 1000 + digits[3] * 100 + digits[4] * 10 + digits[5];

                Console.WriteLine($"New number after swapping: {newNumber}");
            }
        }
        public class Task5
        {
            public void task()
            {
                Console.WriteLine("Enter a date (dd.mm.yyyy):");
                string input = Console.ReadLine();

                DateTime date;
                try
                {
                    date = DateTime.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Error: Invalid date format.");
                    return;
                }

                string dayOfWeek = date.DayOfWeek.ToString();
                int day = date.Day;
                int month = date.Month;

                string season = "";

                switch (month)
                {
                    case 12:
                        season = (day < 21) ? "Autumn" : "Winter";
                        break;
                    case 1:
                    case 2:
                        season = "Winter";
                        break;
                    case 3:
                        season = (day < 20) ? "Winter" : "Spring";
                        break;
                    case 4:
                    case 5:
                        season = "Spring";
                        break;
                    case 6:
                        season = (day < 21) ? "Spring" : "Summer";
                        break;
                    case 7:
                    case 8:
                        season = "Summer";
                        break;
                    case 9:
                        season = (day < 23) ? "Summer" : "Autumn";
                        break;
                    case 10:
                    case 11:
                        season = "Autumn";
                        break;
                    default:
                        Console.WriteLine("Error: Invalid month.");
                        return;
                }

                Console.WriteLine(season + " " + dayOfWeek);
            }
        }

        public class Task6
        {
            public void task()
            {
                Console.WriteLine("Enter the temperature:");
                string tempInput = Console.ReadLine();

                double temperature;
                if (!double.TryParse(tempInput, out temperature))
                {
                    Console.WriteLine("Invalid temperature value.");
                    return;
                }

                Console.WriteLine("Choose conversion:");
                Console.WriteLine("1 - Fahrenheit to Celsius");
                Console.WriteLine("2 - Celsius to Fahrenheit");

                string choiceInput = Console.ReadLine();
                int choice;
                if (!int.TryParse(choiceInput, out choice))
                {
                    Console.WriteLine("Invalid choice.");
                    return;
                }

                double result;

                switch (choice)
                {
                    case 1:
                        result = (temperature - 32) * 5 / 9;
                        Console.WriteLine("Result: " + result + " °C");
                        break;
                    case 2:
                        result = (temperature * 9 / 5) + 32;
                        Console.WriteLine("Result: " + result + " °F");
                        break;
                    default:
                        Console.WriteLine("Unknown option.");
                        break;
                }
            }
        }

        public class Task7
        {
            public void task()
            {
                Console.WriteLine("Enter the first number:");
                string input1 = Console.ReadLine();

                Console.WriteLine("Enter the second number:");
                string input2 = Console.ReadLine();

                int number1, number2;

                if (!int.TryParse(input1, out number1) || !int.TryParse(input2, out number2))
                {
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                    return;
                }

                int start = number1;
                int end = number2;

                if (number1 > number2)
                {
                    start = number2;
                    end = number1;
                }

                Console.WriteLine("Even numbers in the range:");
                for (int i = start; i <= end; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                // for 1 and 2 tasks
                //int number;
                //Console.WriteLine("Enter a number:");
                //number = Convert.ToInt32(Console.ReadLine());

                // for 2 task
                //int percent;
                //Console.WriteLine("Enter a percent:");
                //percent = Convert.ToInt32(Console.ReadLine());


                // task 1

                //Task1 task1 = new Task1();
                //task1.check(number);
                //task1.task(number);

                // task 2

                //Task2 task2 = new Task2();
                //task2.task(number, percent);

                // task 3

                //Task3 task3 = new Task3();
                //task3.task();

                // task 4

                //Task4 task4 = new Task4();
                //task4.task();

                // task 5
                //Task5 task5 = new Task5();
                //task5.task();

                // task 6
                //Task6 task6 = new Task6();
                //task6.task();

                // task 7
                Task7 task7 = new Task7();
                task7.task();
            }
        }
    }
}