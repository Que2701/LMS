using System;
using StudentPreferenceAiModel.Classes;
using StudentPreferenceAiModelDemoML.Model;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;

namespace StudentPreferenceAiModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Student Preference Ai Model";

            var studentOfferedAnswers = BuildOfferedAnswers.GetOfferedAnswers();
            var studentSelectedAnswers = new List<IStudentOfferedAndSelectedAnswer>();
            var questionCounter = 0;

            Console.WriteLine("Enter first name: ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter your student number: ");
            var studentNumber = Console.ReadLine();

            for (int i = 0; i < studentOfferedAnswers.Count; i += 4)
            {
                Console.WriteLine("Select the answer that best describes your preference");
                Console.WriteLine("Enter your answer (i.e. 1 or 2 or 3 or 4) with spaces or enter all e.g. 1234");
                var questionIndex = 1;
                var innerLoopController = i + 4;
                for (int j = i; j < innerLoopController; j++)
                {
                    Console.WriteLine($"  {questionIndex}. {studentOfferedAnswers[j].Descriptions}");
                    questionIndex++;
                }


                var userSelectAnswers = Console.ReadLine().Split();

                foreach (var userSelectAnswer in userSelectAnswers)
                {
                    switch (Convert.ToInt32(userSelectAnswer))
                    {
                        case 1:
                            studentSelectedAnswers.Add((studentOfferedAnswers[1] as IStudentOfferedAndSelectedAnswer));
                            break;
                        case 2:
                            studentSelectedAnswers.Add((studentOfferedAnswers[2] as IStudentOfferedAndSelectedAnswer));
                            break;
                        case 3:
                            studentSelectedAnswers.Add((studentOfferedAnswers[3] as IStudentOfferedAndSelectedAnswer));
                            break;
                        case 4:
                            studentSelectedAnswers.Add((studentOfferedAnswers[4] as IStudentOfferedAndSelectedAnswer));
                            break;
                        default:
                            break;
                    }
                }

                questionCounter++;
                Console.WriteLine();
            }

            // Aggregate the answers from the selected student answers
            var calculatedResults = from studentSelectedAnswer in studentSelectedAnswers
                                    group studentSelectedAnswer by studentSelectedAnswer.Preference into preferences
                                    select new 
                                    {
                                        Preference = preferences.Key,
                                        Sum = preferences.Count()
                                    } ;
            Console.WriteLine($"The recommended study preference for {firstName} {lastName} student number {studentNumber} is {calculatedResults.OrderByDescending(x => x.Sum).Take(1).FirstOrDefault().Preference}");
            // Allow the user to close the application
            Console.ReadLine();
            #region Initial Code
            /*
            // Add input data
            var input = new ModelInput();
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
                input.Description = Console.ReadLine();

                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);

                Console.WriteLine($"The recommended study preference for {firstName} {lastName} student number {studentNumber}:");
                Console.WriteLine($"Preference: {result.Prediction}\tAccurary: {result.Score[0]}");
            } while (Console.ReadKey().Key != ConsoleKey.Q);
            */
            #endregion
        }
    }
}
