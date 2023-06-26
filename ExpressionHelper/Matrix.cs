using System;

namespace ExpressionHelper;

public class Matrix 
{
    private Vector[] matrix;
    public Matrix(params AlgebraicExpression[][] values)
    {
        var vectors = values.Select(val => new Vector(val));
        this.matrix = vectors.ToArray();
    }
    public Matrix(params Vector[] values)
    {
        this.matrix = values;
    }
    
}