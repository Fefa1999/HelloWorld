using Xunit;
using FluentAssertions;

namespace HelloWorld.Test;

public class UnitTest1
{
    [Fact]
    public void YES_2008_IS_LEAP_YEAR_DIVEDED_BY_4(){
         // Arrange
        var year = 2008;

        // Act
        var isLeapYear = HelloWorld.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(true);
    }

     [Fact]
    public void NO_2007_IS_NOT_LEAP_YEAR_DIVIDED_BY_4(){
         // Arrange
        var year = 2007;

        // Act
        var isLeapYear = HelloWorld.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(false);
    }

    [Fact]
    public void NO_1900_IS_NOT_LEAP_YEAR_DIVISBLE_BY_100(){
         // Arrange
        var year = 1900;

        // Act
        var isLeapYear = HelloWorld.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(false);
    }

    [Fact]
    public void YES_1600_IS_A_LEAP_YEAR_DIVISBLE_BY_400(){
         // Arrange
        var year = 1600;

        // Act
        var isLeapYear = HelloWorld.IsLeapYear(year);

        // Assert
        isLeapYear.Should().Be(true);
    }

}