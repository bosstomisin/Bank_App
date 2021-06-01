using NewBank.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace NewBank.Test
{
    public class UtilitiesTest
    {
        [Fact]
        public void RemoveDigitRomStartTest()
        {
            //Arrange
            var source = "4jane";
            var expected = "jane";
            //Act
            var actual = Utilities.RemoveDigitFromStart(source);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FirstCharacterToUpperTest()
        {
            var source = "jane";
            var expected = "Jane";
            var actual = Utilities.FirstCharacterToUpper(source);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidateEmailTest()
        {
                 
                var validate = Utilities.ValidateEmail("a@gmail.com");
                var validate2 = Utilities.ValidateEmail("agmailcom");

            Assert.True(validate);
            Assert.False(validate2);

        }


    }
}
