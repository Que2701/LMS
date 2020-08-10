using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StudentPreferenceAiModel.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LearningPreference { get; set; }
    }
}
