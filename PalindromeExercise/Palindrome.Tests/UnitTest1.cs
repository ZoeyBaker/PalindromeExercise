using System;
using Xunit;
using PalindromeExercise;


namespace Palindrome.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello" , false)]
        [InlineData("Racecar", true)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();
            //act
           bool actual = tester.IsaPalindrome(word);
            //assert

            Assert.Equal(expected, actual);
        }
        

        
    }
}