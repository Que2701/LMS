using System;
using System.Collections.Generic;
using StudentPreferenceAiModel.Models;

namespace StudentPreferenceAiModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Student Preference Ai Model";

            // Add input data
            // var input = new ModelInput();

            Console.WriteLine("Press 'Q' to close program");
            do
            {
                Console.WriteLine("Enter first name: ");
                var firstName = Console.ReadLine();

                Console.WriteLine("Enter last name: ");
                var lastName = Console.ReadLine();

                Console.WriteLine("Enter your student number: ");
                var studentNumber = Console.ReadLine();

                Console.WriteLine("Describe your study preferences: ");
                // input.Description = Console.ReadLine();

                // Load model and predict output of sample data
                // ModelOutput result = ConsumeModel.Predict(input);

                Console.WriteLine($"The recommended study preference for {firstName} {lastName} student number {studentNumber}:");
                // Console.WriteLine($"Preference: {result.Prediction}\tAccurary: {result.Score[0]}");
            } while (Console.ReadKey().Key != ConsoleKey.Q);


            // Allow the user to close the application
            // Console.ReadLine();
        }
    }
}
