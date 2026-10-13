using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
          

            Stack<string> myBag = new Stack<string>();
            string choice;

            Console.WriteLine("Welcome to my STACK PROGRAM");

            do
            {
                Console.WriteLine("Choose what you want to do: ");
                Console.WriteLine("1 – PUSH");
                Console.WriteLine("2 – POP");
                Console.WriteLine("3 – SEARCH");
                Console.WriteLine("4 – PEEK");
                Console.WriteLine("5 – DISPLAY");
                Console.WriteLine("6 – COUNT");
                Console.WriteLine("7 – EXIT");
                Console.Write("Enter code: ");

                choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter new data to push: ");
                        string inputData = Console.ReadLine();
                        myBag.Push(inputData);
                        Console.WriteLine("New data added\n");
                        break;

                    case "2":
                        Console.Write("Enter how many data you want to pop: ");
                        int countToPop;
                        if (int.TryParse(Console.ReadLine(), out countToPop))
                        {
                            if (countToPop > myBag.Count || countToPop <= 0)
                            {

                            }
                            else
                            {
                                for (int i = 0; i < countToPop; i++)
                                {
                                    myBag.Pop();
                                }
                                Console.WriteLine($"{countToPop} item(s) popped successfully!\n");
                            }
                        }
                        else
                        {

                        }
                        break;

                    case "3":
                        Console.Write("Enter data to search: ");
                        string searchData = Console.ReadLine();
                        if (myBag.Contains(searchData))
                        {
                            Console.WriteLine($"Data '{searchData}' was found in the stack.\n");
                        }
                        else
                        {
                            Console.WriteLine($"Data '{searchData}' was not found in the stack.\n");
                        }
                        break;

                    case "4":
                        if (myBag.Count > 0)
                        {
                            Console.WriteLine($"Top element (Peek): {myBag.Peek()}\n");
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty.\n");
                        }
                        break;

                    case "5":
                        if (myBag.Count > 0)
                        {
                            Console.WriteLine("Elements in the stack:");
                            foreach (var item in myBag)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Walang laman.\n");
                        }
                        break;

                    case "6":
                        Console.WriteLine($"Number of items in stack: {myBag.Count}\n");
                        break;

                    case "7":
                        Console.WriteLine("Salamat ya!");
                        break;

                    default:

                        break;
                }

            } while (choice != "7");
        }
    }
}