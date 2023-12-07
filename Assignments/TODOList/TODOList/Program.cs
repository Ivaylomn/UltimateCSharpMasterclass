using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TODOList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine();
            List<string> allTODOs = new List<string>();

            bool isExistValidOption = false;
            while (!isExistValidOption)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[S]ee all TODOs");
                Console.WriteLine("[A]dd a TODO");
                Console.WriteLine("[R]emove a TODO");
                Console.WriteLine("[E]xit");

                string choice = Console.ReadLine().ToUpper();

                if (choice == "A")
                {
                    AddTodoInList(allTODOs);
                }
                else if (choice == "S")
                {
                    PrintAllTODOsOnConsole(allTODOs);
                }
                else if (choice == "R")
                {
                    RemoveFromTodo(allTODOs);
                }
                else if (choice == "E")
                {
                    isExistValidOption = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }

            }
        }

        private static void RemoveFromTodo (List<string> allTODOs)
        {
            bool isExistValidOption = false;
            while (!isExistValidOption)
            {
                Console.WriteLine("Select the index of the TODO you want to remove:");

                if (allTODOs.Count == 0)
                {
                    Console.WriteLine("No TODOs have been added yet.");
                    break;
                }

                PrintAllTODOsOnConsole(allTODOs);

                string todoIndexAsString = Console.ReadLine();

                if (string.IsNullOrEmpty(todoIndexAsString))
                {
                    Console.WriteLine("Selected index cannot be empty.");
                    Console.WriteLine("Select the index of the TODO you want to remove:");
                }
                else if (int.Parse(todoIndexAsString) < 0 || int.Parse(todoIndexAsString) > allTODOs.Count)
                {
                    Console.WriteLine("The given index is not valid.");
                    Console.WriteLine("Select the index of the TODO you want to remove:");
                }
                else
                {
                    string removedTodo = allTODOs.ElementAt(int.Parse(todoIndexAsString) - 1);
                    allTODOs.RemoveAt(int.Parse(todoIndexAsString) - 1);
                    Console.WriteLine($"TODO removed: {removedTodo}");
                    isExistValidOption = true;
                }
            }
        }

        private static void AddTodoInList(List<string> allTODO)
        {
            bool isExistValidOption = false;
            while (!isExistValidOption)
            {
                Console.WriteLine("Enter the TODO description:");
                string todoDescription = Console.ReadLine();

                if (string.IsNullOrEmpty(todoDescription))
                {
                    Console.WriteLine($"The description cannot be emty");
                }
                else if (allTODO.Contains(todoDescription))
                {
                    Console.WriteLine($"The description must be unique.");
                }
                else
                {
                    allTODO.Add(todoDescription);
                    isExistValidOption = true;
                    Console.WriteLine($"TODO successfully added: {todoDescription}");
                }
            }
        }

        private static void PrintAllTODOsOnConsole(List<string> allTODO)
        {
            if (allTODO.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");xx

            }
            else
            {
                int index = 1;
                foreach (var item in allTODO)
                {
                    Console.WriteLine($"{index++}. {item}");
                }
            }
        }
    }
}
