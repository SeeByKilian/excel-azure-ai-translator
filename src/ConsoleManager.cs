using System.Diagnostics;

namespace ExcelAzureAiTranslator
{
    // Additional class of the program grouping the console methods
    class ConsoleManager
    {
        // Method for generating the Copyright section in the console
        public static void Copyright()
        {
            try
            {
                // Print the ASCII art copyright message with the correct colors
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" _______  _______  _______  _______  __   __  ___   _  ___   ___      ___   _______  __    _ ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("|       ||       ||       ||  _    ||  | |  ||   | | ||   | |   |    |   | |   _   ||  |  | |");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("|  _____||    ___||    ___|| |_|   ||  |_|  ||   |_| ||   | |   |    |   | |  |_|  ||   |_| |");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("| |_____ |   |___ |   |___ |       ||       ||      _||   | |   |    |   | |       ||       |");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("|_____  ||    ___||    ___||  _   | |_     _||     |_ |   | |   |___ |   | |       ||  _    |");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" _____| ||   |___ |   |___ | |_|   |  |   |  |    _  ||   | |       ||   | |   _   || | |   |");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("|_______||_______||_______||_______|  |___|  |___| |_||___| |_______||___| |__| |__||_|  |__|");
                Console.ForegroundColor = ConsoleColor.Gray;
                // Print the documentation link message
                Console.Write("\nIf you need help formatting your Excel file to translate or using Excel Azure AI Translator, visit the documentation available at the following address: https://github.com/SeeByKilian/excel-azure-ai-translator\n");
            }
            catch
            {
                // If an error occurs while generating the copyright section, generate an error
                Error("An error occurred while generating the console copyright section. Please try again.");
            }
        }

        // Method to ask a console question and return the user's response
        public static string AskQuestion(string questionContent)
        {
            // Set console text color to gray
            Console.ForegroundColor = ConsoleColor.Gray;
            // Print the question in the console with the specified content
            Console.WriteLine("\n" + questionContent);

            try
            {
                // Read the user's response from the console and store it in a variable
                string userResponse = Console.ReadLine() ?? "";
                // Return the variable containing the user's response
                return userResponse;
            }
            catch
            {
                // If an error occurs while reading the user's response, generate an error
                Error("An error occurred while reading user response in console. Please try again.");
                // Return null
                return "";
            }
        }

        // Method for generating an error message in the console with a specific message and stopping the program
        public static void Error(string errorContent)
        {
            try
            {
                // Set console text color to red
                Console.ForegroundColor = ConsoleColor.Red;
                // Print the error message
                Console.WriteLine("\n" + errorContent);

                // Print a message in the console to inform the user to click any key to close the program
                Message("Press any key to close Excel Azure AI Translator...");

                // Wait for the user to press any key
                Console.ReadKey();

                // Exit the program and close the command prompt window
                Environment.Exit(1);
            }
            catch
            {
                // If an error occurs while error message generation process, generate an error
                Console.WriteLine("An error occurred while generating a console error message. Please try again.");
            }
        }

        // Method for generating a success message in the console with a specific message
        public static void Success(string successContent)
        {
            try
            {
                // Set console text color to green
                Console.ForegroundColor = ConsoleColor.Green;
                // Print the success message
                Console.WriteLine("\n" + successContent);
            }
            catch
            {
                // If an error occurs while success message generation process, generate an error
                Error("An error occurred while generating a console success message. Please try again.");
            }
        }

        // Method for generating a task message in the console with a specific message
        public static void Task(string taskContent, bool isAnEdit)
        {
            try
            {
                // Check if it's a task message creation or an edition
                if (isAnEdit)
                {
                    // If it's a edition, set console text color to yellow
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    // Delete the last console message
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop);
                    // Print the new task message
                    Console.WriteLine(taskContent);
                }
                else
                {
                    // If it's a generation, set console text color to yellow
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    // Print the task message
                    Console.WriteLine("\n" + taskContent);
                }
            }
            catch
            {
                // If an error occurs while task message generation or editing process, generate an error
                Error("An error occurred while generating or editing a console task message. Please try again.");
            }
        }

        // Method for generating a message in the console with a specific message
        public static void Message(string messageContent)
        {
            try
            {
                // Set console text color to gray
                Console.ForegroundColor = ConsoleColor.Gray;
                // Print the message in the console with the specified content
                Console.WriteLine("\n" + messageContent);
            }
            catch
            {
                // If an error occurs while message generation, generate an error
                Error("An error occurred while generating a console message. Please try again.");
            }
        }
    }
}