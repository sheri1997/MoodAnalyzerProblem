using System;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            Console.WriteLine(moodAnalyzer.analyseMood("I am in Any Mood"));
        }
    }
}
