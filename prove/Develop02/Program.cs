using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    // Class to represent a single journal entry
    public class UserResponse
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string DateAndTime { get; set; }

        public UserResponse(string prompt, string response)
        {
            Prompt = prompt;
            Response = response;
            DateAndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public override string ToString()
        {
            return $"Date: {DateAndTime}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }
    }



    // Class to manage journal entries
    public class DataManager
    {
        public List<UserResponse> Entries { get; set; } = new List<UserResponse>();

        public void AddEntries(UserResponse entry)
        {
            Entries.Add(entry);
        }

        public void LoadEntries(string filename)
        {
            Entries.Clear();
            using (StreamReader file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
                    UserResponse entry = new UserResponse(parts[1], parts[2]) { DateAndTime = parts[0] };
                    Entries.Add(entry);
                }
            }
        }

        public void StoreEntries(string filename)
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                foreach (UserResponse entry in Entries)
                {
                    file.WriteLine($"{entry.DateAndTime}~|~{entry.Prompt}~|~{entry.Response}");
                }
            }
        }

        public void DisplayEntries()
        {
            foreach (UserResponse entry in Entries)
            {
                Console.WriteLine(entry);
            }
        }
    }




    // Class to generate prompts
    public class PromptGenerator
    {
        private List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        public string Generate()
        {
            Random rand = new Random();
            return prompts[rand.Next(prompts.Count)];
        }
    }

    // Class to manage the journal application
    public class JournalApp
    {
        private DataManager dataManager = new DataManager();
        private PromptGenerator promptGenerator = new PromptGenerator();

        public void DisplayMenu()
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
        }

        public void GetUserChoice()
        {
            Console.Write("Please choose an option: ");
        }

        public void WriteNewEntry()
        {
            string prompt = promptGenerator.Generate();
            Console.WriteLine($"\nPrompt: {prompt}");
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            UserResponse entry = new UserResponse(prompt, response);
            dataManager.AddEntries(entry);
        }

        public void DisplayJournal()
        {
            dataManager.DisplayEntries();
        }

        public void SaveJournal()
        {
            Console.Write("Enter the filename to save the journal: ");
            string filename = Console.ReadLine();
            dataManager.StoreEntries(filename);
            Console.WriteLine($"Journal saved to {filename}");
        }

        public void LoadJournal()
        {
            Console.Write("Enter the filename to load the journal: ");
            string filename = Console.ReadLine();
            dataManager.LoadEntries(filename);
            Console.WriteLine($"Journal loaded from {filename}");
        }

        public void Run()
        {
            while (true)
            {
                DisplayMenu();
                GetUserChoice();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        WriteNewEntry();
                        break;
                    case "2":
                        DisplayJournal();
                        break;
                    case "3":
                        SaveJournal();
                        break;
                    case "4":
                        LoadJournal();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the journal app. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

    // Main class to run the journal application
    class Program
    {
        static void Main(string[] args)
        {
            JournalApp app = new JournalApp();
            app.Run();
        }
    }
}

