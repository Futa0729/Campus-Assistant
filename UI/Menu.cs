

namespace CampusAssistant.UI
{
    public class Menu
    {
        public void MainMenu()
        {
            while(true)
            {
                Console.WriteLine("===== Multi-Language Campus Assistant =====");
                Console.WriteLine();
                Console.WriteLine("1. Search academic terms");
                Console.WriteLine("2. Campus information");
                Console.WriteLine("3. Safety information");
                Console.WriteLine("4. Step-by-step guides");
                Console.WriteLine("5. Change language");
                Console.WriteLine("6. Exit");
                Console.WriteLine();

                Console.Write("Please select an option (1-6): ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Call the method to search academic terms
                    break;
                }
                else if (choice == "2")
                {
                    // Call the method to display campus information
                    break;
                }
                else if (choice == "3")
                {
                    // Call the method to display safety information
                    break;
                }
                else if (choice == "4")
                {
                    // Call the method to display step-by-step guides
                    break;
                }
                else if (choice == "5")
                {
                    // Call the method to change language
                    break;
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}