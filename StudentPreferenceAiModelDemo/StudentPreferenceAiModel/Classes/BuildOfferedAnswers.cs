using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;

namespace StudentPreferenceAiModel.Classes
{
    public class BuildOfferedAnswers
    {
        public static List<IStudentOfferedAndSelectedAnswer> GetOfferedAnswers()
        {
            return PopulateOfferedAnswers(); 
        }
        private static List<IStudentOfferedAndSelectedAnswer> PopulateOfferedAnswers()
        {
        var questionPreferences = new List<IStudentOfferedAndSelectedAnswer>();

        questionPreferences.Add(new StudentOfferedAnswer { Descriptions = "listen to somebody explaining it and ask questions. ", Preference = "Auditory" });
            questionPreferences.Add(new StudentOfferedAnswer { Descriptions = "use the diagrams that explain the various stages, moves and strategies in ", Preference = "Kinesthetic" });
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "read the instructions", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "watch others play the game before joining in. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "from somebody who talks it through with me. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "using graphs showing what I achieved. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "using a written description of my results. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "using examples from what I have done. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "showed me a diagram of what was wrong. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "described what was wrong. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "gave me something to read to explain what was wrong. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "used a plastic model to show me what was wrong. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "use examples and applications. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "read books, articles and handouts. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "see patterns in things. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "like to talk things through. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "consider examples of each option using my financial information.",Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "read a print brochure that describes the options in detail. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "talk with an expert about the options. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer { Descriptions = "use graphs showing different options for different time periods. ", Preference = "Visual" }) ;
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "diagrams showing each stage of the assembly. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "advice from someone who has done it before. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "watching a video of a person assembling a similar table. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer { Descriptions = "written instructions that came with the parts for the table. ", Preference = "Read/Write" }) ;
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "question and answer, talk, group discussion, or guest speakers. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "demonstrations, models or practical sessions. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "handouts, books, or readings. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "diagrams, charts, maps or graphs. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "diagrams to show the project stages with charts of benefits and costs. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "an opportunity to discuss the project. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "examples where the project has been used successfully. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "a written report describing the main features of the project. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "Applying my knowledge in real situations. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "Communicating with others through discussion. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "Working with designs, maps or charts. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "Using words well in written communications. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "follow the diagrams in a book. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "start using it and learn by trial and error. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "read the written instructions that came with the program. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "talk with people who know about the program. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "write down the street directions I need to remember. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "find out where the shop is in relation to somewhere I know. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "ask my friend to tell me the directions. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "use a map. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "a plan showing the rooms and a map of the area. ", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "a printed description of the rooms and features. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "to view a video of the property. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "a discussion with the owner. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "interesting written descriptions, lists and explanations. ", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "audio channels where I can listen to podcasts or interviews. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "interesting design and visual features. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "videos showing how to do or make things. ", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "watching the actions.", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "listening", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "seeing the diagrams", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "reading the words", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "use diagrams showing the camera and what each part does", Preference = "Kinesthetic"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "use the written instructions about what to do", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "ask questions and talk about the camera and its features", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "use examples of good and poor photos showing how to improve them", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "read about the tour on the itinerary", Preference = "Read/Write"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "use a map and see where the places are", Preference = "Visual"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "talk with the person who planned the tour or others. ", Preference = "Auditory"}); 
            questionPreferences.Add(new StudentOfferedAnswer{  Descriptions = "look at details about the highlights and activities on the tour", Preference = "Visual"}); 




            return questionPreferences;
        }
    }
}
