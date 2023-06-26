using System;

namespace ExpressionHelper;

public class Symbol
{
    private object val;
    public Symbol(object v)
    {
        this.val = v;
    }

    public object Value
    {
        get 
        {
            return this.val;
        }
    }
    
    public bool IsVariable 
    {
        get
        {
            return val is string;
        }
    }
    public bool IsTerm 
    {
        get
        {
            return val is Term;
        }
    }
    public bool IsAlgebraicExpression
    {
        get
        {
            return val is AlgebraicExpression;
        }
    }
    public bool IsVector
    {
        get
        {
            return val is Vector;
        }
    }
    public bool IsMatrix
    {
        get
        {
            return val is Matrix;
        }
    }
    public bool IsNumber
    {
        get
        {
            return val is int;
        }
    }
    public bool IsFraction
    {
        get
        {
            return val is Fraction;
        }
    }    

    public static implicit operator Symbol(int value)
    {
        return new Symbol(value);
    }
    public static implicit operator Symbol(AlgebraicExpression value)
    {
        return new Symbol(value);
    }
    public static implicit operator Symbol(string value)
    {
        return new Symbol(value);
    }
}