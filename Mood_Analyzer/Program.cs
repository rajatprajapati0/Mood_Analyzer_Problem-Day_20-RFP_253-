using System;

namespace Mood_Analyzer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyzer Problem");

            Console.WriteLine("Welcome in Mood Analyzer Program ");
            Mood mood = new Mood();
            Console.WriteLine("How Are You");

            Console.WriteLine(mood.checkMood(Console.ReadLine()));
        }
    }
}
