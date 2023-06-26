using System;
using ExpressionHelper;
using Xunit;

namespace Tests;

public class FractionTests
{
    [Fact]
    public void ToString_ReturnsZero()
    {
        Fraction fraction = new Fraction(0);
        Assert.Equal("0", fraction.ToString());

        fraction = new Fraction();
        Assert.Equal("0", fraction.ToString());
    }

    [Fact]
    public void ToString_ReturnsNumber()
    {
        Fraction fraction = new Fraction(1);
        Assert.Equal("1", fraction.ToString());

        fraction = new Fraction(2);
        Assert.Equal("2", fraction.ToString());
    }

    [Fact]
    public void ToString_ReturnsFraction()
    {
        Fraction fraction = new Fraction(1, 2);
        Assert.Equal("1/2", fraction.ToString());

        fraction = new Fraction(3, 6);
        Assert.Equal("3/6", fraction.ToString());
    }
}