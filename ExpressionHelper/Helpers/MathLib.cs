using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExpressionHelper.Helpers;

public static class MathLib
{
    public static AlgebraicExpression ParseExpression(string s)
    { // Use Coefficient and Exponential in tandem to produce an AlgebraicExpression instance with the help of RegularExpressions.
        throw new NotImplementedException();
    }
    private static AlgebraicExpression ParseExpressionCoefficient(string s)
    {
        throw new NotImplementedException();
    }
    private static AlgebraicExpression ParseExpressionExponential(string s)
    {
        throw new NotImplementedException();
    }

    public static Symbol Add(Symbol s1, Symbol s2)
    { //TODO: create a new symbol where s2.Value is added to s1.Value
        throw new NotImplementedException();
    }
}