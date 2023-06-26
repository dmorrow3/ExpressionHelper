using System;

namespace ExpressionHelper;

public class Fraction 
{
    private int numerator = 0;
    private int denominator = 1;

    public Fraction()
    {

    }
    public Fraction(int numerator, int denominator = 1)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public void Reduce()
    { // Reduce numerator and denominator by eliminating common factors
        throw new NotImplementedException();
    }

    public override string ToString()
    { 
        if (numerator == 0) return "0";
        else if (denominator == 1) return numerator.ToString();
        else return String.Concat(numerator, "/", denominator);
    }
}