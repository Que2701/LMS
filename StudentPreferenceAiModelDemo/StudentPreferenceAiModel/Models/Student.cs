using Microsoft.ML.Data;

namespace StudentPreferenceAiModel.Models
{
    public class Student
    {
        [LoadColumn(0)]
        public int Id { get; set; }
        [LoadColumn(1)]
        public string StudentNumber { get; set; }
        [LoadColumn(2)]
        public string FirstName { get; set; }
        [LoadColumn(3)]
        public string LastName { get; set; }
        [LoadColumn(4)]
        public string LearningPreference { get; set; }
    }

    public class PreferencePrediction
    {
        [ColumnName("PredictedLabel")]
        public string Preference;
    }
}
