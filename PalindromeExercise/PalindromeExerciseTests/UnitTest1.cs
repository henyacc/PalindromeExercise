using System;
using System.ComponentModel.Design;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("truck", true)]
        [InlineData("motorbike", true )]
        [InlineData("bicycle", true)]
        [InlineData("SUV", true)]
        
        public void PalindromeTest1(string word, bool expected)
        {
            //Arrange
            var wordSmith  = new WordSmith();
            
            //Act
            var actual = wordSmith.IsPalindrome(word);
            
            Assert.Equal(expected, actual);

        }
        
        
        
        
    
    }
}
