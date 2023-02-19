using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mood_Analyzer
{
    public class Mood
    {
        public class MoodPattern
        {
            public static string sadmood = @"^(sad|i am sad|sad mood|i am in sad mood)$";

        }
        public string checkMood(string mymood)
        {
            Regex mood = new Regex(MoodPattern.sadmood);
            bool check = mood.IsMatch(mymood.ToLower());
            if (check == true)
            {
                mymood = "SAD";
            }
            else
            {
                mymood = "HAPPY";

          
            }

            return mymood;

        }

    }
}
