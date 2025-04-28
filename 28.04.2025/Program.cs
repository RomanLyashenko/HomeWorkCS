using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._04._2025
{
    public class Task1
    {
        public void Square(char symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
    }

    public class Task2
    {
        public bool isPalindrome(int number)
        {
            string strNumber = number.ToString();
            string reversed = "";

            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                reversed += strNumber[i];
            }

            return strNumber == reversed;
        }
    }

    public class Task3
    {
        public int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            List<int> result = new List<int>();

            foreach (int item in originalArray)
            {
                bool toRemove = false;
                foreach (int filterItem in filterArray)
                {
                    if (item == filterItem)
                    {
                        toRemove = true;
                        break;
                    }
                }

                if (!toRemove)
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }
    }

    public class Website
    {
        // Поля класса
        private string name;
        private string url;
        private string description;
        private string ipAddress;

        public void InputData()
        {
            Console.Write("\nEnter site name: ");
            name = Console.ReadLine();

            Console.Write("Enter URL of the site: ");
            url = Console.ReadLine();

            Console.Write("Enter a site description: ");
            description = Console.ReadLine();

            Console.Write("Enter the IP-address of the site: ");
            ipAddress = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\nSite information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"URL: {url}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"IP-adress: {ipAddress}");
        }
    }

    public class Magazine
    {
        private string name;
        private int yearFounded;
        private string description;
        private string contactPhone;
        private string contactEmail;

        public void InputData()
        {
            Console.Write("Enter name of the magazine: ");
            name = Console.ReadLine();

            Console.Write("Enter the year of the foundetion: ");
            yearFounded = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter magazine description: ");
            description = Console.ReadLine();

            Console.Write("Enter the phone number: ");
            contactPhone = Console.ReadLine();

            Console.Write("Enter the e-mail: ");
            contactEmail = Console.ReadLine();
        }

        // Метод для вывода данных
        public void DisplayData()
        {
            Console.WriteLine("\nMagazine information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Year founded: {yearFounded}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Phone: {contactPhone}");
            Console.WriteLine($"E-mail: {contactEmail}");
        }
    }

    public class Store
    {
        private string name;
        private string address;
        private string profileDescription;
        private string contactPhone;
        private string contactEmail;

        public void InputData()
        {
            Console.Write("Enter the store name: ");
            name = Console.ReadLine();

            Console.Write("Enter the store address: ");
            address = Console.ReadLine();

            Console.Write("Enter the store description: ");
            profileDescription = Console.ReadLine();

            Console.Write("Enter phone number: ");
            contactPhone = Console.ReadLine();

            Console.Write("Enter the e-mail: ");
            contactEmail = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\nStore Information:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Description: {profileDescription}");
            Console.WriteLine($"Phone: {contactPhone}");
            Console.WriteLine($"E-mail: {contactEmail}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Console.Write("Input a symbol: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Input size of a square: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Task1 task = new Task1();
            task.Square(symbol, size);

            // task 2 

            Console.Write("Input a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Task2 task2 = new Task2();
            bool result = task2.isPalindrome(number);

            if (result)
            {
                Console.WriteLine("The number is a palindrome");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome");
            }

            // task 3

            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };

            Task3 task3 = new Task3();
            int[] filteredArray = task3.FilterArray(originalArray, filterArray);

            Console.WriteLine("Result:");
            foreach (int num in filteredArray)
            {
                Console.Write(num + " ");
            }

            // task 4

            Website site = new Website();

            site.InputData();     
            site.DisplayData();

            // task 5

            Magazine magazine = new Magazine();

            magazine.InputData();    
            magazine.DisplayData();

            // task 6

            Store store = new Store();

            store.InputData();     
            store.DisplayData();  
        }
    }
}

