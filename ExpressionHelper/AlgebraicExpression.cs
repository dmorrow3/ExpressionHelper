using System;
using ExpressionHelper.Helpers;

namespace ExpressionHelper;

public class AlgebraicExpression
{
    private List<Term> termList;
    public AlgebraicExpression(string s)
    {
        var expression = MathLib.ParseExpression(s);
        termList = expression.termList;
    }
    public AlgebraicExpression(params Term[] values)
    {
        termList = values.ToList();
    }

    public List<Term> Terms
    {
        get { return termList; }
    }

}