using System;
using ExpressionHelper.Helpers;

namespace ExpressionHelper;

public class Term
{
    private Symbol coefficient = 1;
    private Symbol exponent = 1;
    private Symbol variable = "x";
    private bool imaginary = false;
    public Term()
    {
        
    }

    public Symbol Coefficient 
    {
        get
        {
            return coefficient;
        }
        set 
        {
            coefficient = value;
        }
    }

    public Symbol Exponent 
    {
        get
        {
            return exponent;
        }
        set 
        {
            exponent = value;
        }
    }

    public Symbol Variable 
    {
        get
        {
            return variable;
        }
        set 
        {
            variable = value;
        }
    }

    public bool Imaginary
    {
        get 
        {
            return imaginary;
        }
        set 
        {
            imaginary = value;
        }
    }

    public AlgebraicExpression GetAlgebraicExpression
    {
        get 
        { 
            if (variable.IsAlgebraicExpression)
            {//TODO: If there are coefficients and exponents that are not `1`, Perform an operation first.
                throw new NotImplementedException();
            }
            else 
            {
                return new AlgebraicExpression(this);
            }
        }
    }

    public static Term operator +(Term term, Term term2)
    {
        if (term.variable.Value == term2.variable.Value && term.exponent.Value == term2.exponent.Value && term.imaginary == term2.imaginary)
        { // Merge the terms
            Symbol symbol = MathLib.Add(term.coefficient, term2.coefficient);
            term.coefficient = symbol;
        }
        else
        { // Create two terms in a larger expression
            Term term1 = new Term() { Coefficient = term.coefficient, Exponent = term.exponent, Variable = term.variable, Imaginary = term.imaginary }; // Copy of term (move the references)
            AlgebraicExpression expression = new AlgebraicExpression(term1, term2);
            term.variable = new Symbol(expression);
            term.coefficient = new Symbol(1);
            term.exponent = new Symbol(1);
            term.imaginary = false;
        }

        return term;
    }

    public override string ToString()
    {
        //TODO: Recursively propogate through Symbol to create the form: "Cx^Ei" where C is coefficient, x is variable, E is exponent, i is imaginary (omit if not)(wrap parenthesis when needing recursion)
        throw new NotImplementedException();
    }
}