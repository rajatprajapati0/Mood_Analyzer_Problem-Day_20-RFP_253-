using Mood_Analyzer;
using NUnit.Framework;

namespace Test_Mood_Analayzer
{
    public class Tests
    {
        Mood mood;
        [SetUp]
        public void Setup()
        {
            mood = new Mood();
        }

        [TestCase("sad")]
        [TestCase("SAD")]
        [TestCase("i am sad")]
        [TestCase("i am in sad mood")]
        [TestCase("I AM SAD")]
        public void test_TO_checkMood(string moodinput)
        {
            mood = new Mood();
            string expected = "SAD";
            var actual = mood.checkMood(moodinput);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("happy")]
        [TestCase("HAPPY")]
        [TestCase("i am happy")]
        [TestCase("i am not in sad mood")]
        [TestCase("I AM in any mood")]
        public void test_TO_checkMood_FOR_HAPPY(string moodinput)
        {
            mood = new Mood();
            string expected = "HAPPY";
            var actual = mood.checkMood(moodinput);
            Assert.AreEqual(expected, actual);
        }
    }
}