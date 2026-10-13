using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          

            Stack<string> myStack = new Stack<string>();
            string choice;

            Console.WriteLine("Welcome to my STACK PROGRAM");

            do
            {
                Console.WriteLine("Choose what you want to do?");
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
                        myStack.Push(inputData);
                        Console.WriteLine("New data has been added!\n");
                        break;

                    case "2":
                        Console.Write("Enter how many data you want to pop: ");
                        int countToPop;
                        if (int.TryParse(Console.ReadLine(), out countToPop))
                        {
                            if (countToPop > myStack.Count || countToPop <= 0)
                            {
                                Console.WriteLine("Operation not accepted.\n");
                            }
                            else
                            {
                                for (int i = 0; i < countToPop; i++)
                                {
                                    myStack.Pop();
                                }
                                Console.WriteLine($"{countToPop} item(s) popped successfully!\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input number.\n");
                        }
                        break;

                    case "3":
                        Console.Write("Enter data to search: ");
                        string searchData = Console.ReadLine();
                        if (myStack.Contains(searchData))
                        {
                            Console.WriteLine($"Data '{searchData}' was found in the stack.\n");
                        }
                        else
                        {
                            Console.WriteLine($"Data '{searchData}' was not found in the stack.\n");
                        }
                        break;

                    case "4":
                        if (myStack.Count > 0)
                        {
                            Console.WriteLine($"Top element (Peek): {myStack.Peek()}\n");
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty.\n");
                        }
                        break;

                    case "5":
                        if (myStack.Count > 0)
                        {
                            Console.WriteLine("Elements in the stack:");
                            foreach (var item in myStack)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("The stack is empty.\n");
                        }
                        break;

                    case "6":
                        Console.WriteLine($"Number of items in stack: {myStack.Count}\n");
                        break;

                    case "7":
                        Console.WriteLine("Exiting program... Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.\n");
                        break;
                }

            } while (choice != "7");
        }
    }
}