using System;

namespace ExpressionHelper;

public class Equation
{
    private AlgebraicExpression lhs;
    private AlgebraicExpression rhs;
    public Equation(AlgebraicExpression expr1, AlgebraicExpression expr2)
    {
        lhs = expr1;
        rhs = expr2;
    }

    public AlgebraicExpression Left
    {
        get
        {
            return lhs;
        }
    }
    public AlgebraicExpression Right
    {
        get
        {
            return rhs;
        }
    }

}