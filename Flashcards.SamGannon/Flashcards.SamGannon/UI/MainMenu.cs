﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards.SamGannon.UI
{
    public class MainMenu
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Custom Flashcard Console App ===");
            Console.WriteLine("1. Flashcard Menu");
            Console.WriteLine("2. Stack Menu");
            Console.WriteLine("3. Start Study Session");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.WriteLine("I - Instructions");
            Console.WriteLine("Enter your choice (1, 2, 3, 4, or I): ");

            string choice = Console.ReadLine()?.Trim().ToUpper();

            while (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "I")
            {
                Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4 to navigate to a new menu or I for instructions.");
                choice = Console.ReadLine()?.Trim().ToUpper();
            }
            
            switch (choice)
            {
                case "1":
                    FlashcardMenu.ShowFlashcardMenu();
                    break;
                case "2":
                    StackMenu.ShowStackMenu();
                    break;
                case "3":
                    StudySession.StartStudySession();
                    break;
                case "4":
                    Console.WriteLine("Exiting the Custom Flashcard Console App. Goodbye!");
                    break;
                    case "I":
                    ShowInstructions();
                    break;
                default:
                    break;
            }

        }

        private static void ShowInstructions()
        {
            Console.Clear();
            Console.WriteLine("=== Instructions ===");
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Custom Flashcard Console App!");
            Console.WriteLine("Navigate through the app using the following instructions:");
            Console.WriteLine("");
            Console.WriteLine("1. To access different menus, enter the corresponding number:");
            Console.WriteLine("   - Enter '1' for Flashcard Menu");
            Console.WriteLine("   - Enter '2' for Stack Menu");
            Console.WriteLine("   - Enter '3' to start a Study Session");
            Console.WriteLine("   - Enter '4' to exit the application");
            Console.WriteLine("   - Enter 'I' to view instructions (you're here now)");
            Console.WriteLine("");
            Console.WriteLine("2. In each menu, follow the on-screen prompts to perform actions:");
            Console.WriteLine("   - Create and manage flashcards in the Flashcard Menu");
            Console.WriteLine("   - Create and manage stacks in the Stack Menu");
            Console.WriteLine("   - Start a study session to review flashcards");
            Console.WriteLine("");
            // add more instructions as they become neccessary
            Console.WriteLine("3. Press 'E' to exit the instructions screen and return to the main menu.");

            string choice = Console.ReadLine()?.Trim().ToUpper();
            int exitAttempts = 0;

            while (choice != "E" && exitAttempts < 3)
            {
                Console.Clear();
                Console.WriteLine("Invalid command. Press 'E' to exit.");
                choice = Console.ReadLine()?.Trim().ToUpper();
                exitAttempts++;
            }

            if (choice == "E")
            {
                ShowMenu();
            }
            else
            {
                // i may log that the user failed to exit the instructions menu successfully.
                Environment.Exit(1);
            }
        }

    }
}
 

