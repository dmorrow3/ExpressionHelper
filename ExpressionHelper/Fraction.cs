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

    public override string ToString()
    { 
        if (numerator == 0) return "1";
        else return String.Concat(numerator, "/", denominator);
    }
}