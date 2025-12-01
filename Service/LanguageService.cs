using CampusAssistant.Models;

namespace CampusAssistant.Service
{
    public static class LanguageService
    {
        public LanguageType CurrentLanguage { get; set; } = LanguageType.English;

        public void SwitchLanguage()
        {
            Console.WriteLine("Select Language / 言語を選択してください:");
            Console.WriteLine("1. English");
            Console.WriteLine("2. 日本語");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CurrentLanguage = LanguageType.English;
                Console.WriteLine("Language switched to English.");
            }
            else if (choice == "2")
            {
                CurrentLanguage = LanguageType.Japanese;
                Console.WriteLine("言語が日本語に切り替えられました。");
            }
            else
            {
                Console.WriteLine("Invalid choice. Language not changed.");
            }
        }
        
    }
}