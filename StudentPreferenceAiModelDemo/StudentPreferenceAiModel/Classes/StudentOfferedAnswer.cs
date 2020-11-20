using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPreferenceAiModel.Classes
{
    public class StudentOfferedAnswer : IStudentOfferedAndSelectedAnswer
    {
        public string Descriptions { get; set; }
        public string Preference { get; set; }
    }
}
