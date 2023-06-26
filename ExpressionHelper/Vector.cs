using System;

namespace ExpressionHelper;

public class Vector
{
    private AlgebraicExpression[] vector;
    public Vector(params AlgebraicExpression[] values)
    {
        this.vector = values;
    }
    
}