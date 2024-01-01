using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)] // ← you will need to put some test data and expected result here.
        [InlineData("not", false)]
        [InlineData("Hannah", true)]
        [InlineData("leveL", true)]

        // For example [InlineData(“racecar”, true)]
        public void Test1(string word, bool expected)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(word);

            Assert.Equal(actual, expected);
        }
    }
}
