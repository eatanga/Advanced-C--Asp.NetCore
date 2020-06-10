using FirstResponsiveWebAppAtanga.Models;
using System;
using Xunit;
using Xunit.Sdk;

namespace TestAgeTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingCaseTest()
        {
            //Arrange
            AgeDisplayModel a = new AgeDisplayModel();
            a.BirthYear = 1984;
            int expected = 36;
            int actual;

            //Act
            actual = a.AgeThisYear();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NegativeValueCaseTest()
        {
            //Arrange
            AgeDisplayModel a = new AgeDisplayModel();
            a.BirthYear = -1984;
            int expected = 36;
            int actual;

            //Act
            actual = a.AgeThisYear();

            // Assert
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void errorMessageTest()
        {
            //Arrange
            AgeDisplayModel a = new AgeDisplayModel();
            a.BirthYear = 1990;
            string expected = "Enter a birth year between 1920 and 2019.";
            int actual;
            //Act
            actual = a.AgeThisYear();

            // Assert
            Assert.NotEqual(expected, actual.ToString());
        }
    }
}
