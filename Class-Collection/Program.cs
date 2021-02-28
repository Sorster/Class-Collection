using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inputs;

namespace Class_Collection
{

    class Program
    {
        static void Main(string[] args)
        {
            SuperObjectManager superObjectManager = new SuperObjectManager();

            do
            {
                ShowMenu();
                Menu choice = InputMenu();

                Console.Clear();

                if (choice == Menu.Exit) break;

                if(superObjectManager.IsEmpty() && choice != Menu.AddElement)
                {
                    Console.WriteLine("Collection is empty!");
                    Console.WriteLine("Refer to elemnts addition...");
                    Console.ReadKey();
                    choice = Menu.AddElement;
                    Console.Clear();
                }

                switch (choice)
                {
                    case Menu.AddElement:
                        superObjectManager.AddElement();
                        break;

                    case Menu.ShowElements:
                        superObjectManager.ShowElements();
                        break;

                    case Menu.Sort:
                        Sort(superObjectManager);
                        break;

                    case Menu.RemoveElement:
                        superObjectManager.RemoveElement();
                        break;

                    case Menu.RemoveAll:
                        superObjectManager.RemoveAll();
                        break;

                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }

                Console.WriteLine("Inout any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }

        static void Sort(SuperObjectManager superObjectManager)
        {
            Console.WriteLine("1 - Sort by name");
            Console.WriteLine("2 - Sort by number");
            Console.Write("Command: ");
            int choice = NumbersInput.Integer("Command");

            if(choice == 1)
            {
                superObjectManager.SortName();
            }
            else if(choice == 2)
            {
                superObjectManager.SortNumber();
            }
            else
            {
                Console.WriteLine("Wrong command!");
            }
        }

        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-----------Menu-----------");
            Console.ResetColor();
            Console.WriteLine("1 - Add element");
            Console.WriteLine("2 - Show elements");
            Console.WriteLine("3 - Sort");
            Console.WriteLine("4 - Remove element (by id)");
            Console.WriteLine("5 - Remove all elements");
            Console.WriteLine("6 - Exit");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Command: ");
        }

        static Menu InputMenu()
        {
            int choice = NumbersInput.Integer("Menu point: ");
            Console.ResetColor();
            return (Menu)choice;
        }

        enum Menu
        {
            AddElement = 1,
            ShowElements,
            Sort,
            RemoveElement,
            RemoveAll,
            Exit
        }
    }
}
