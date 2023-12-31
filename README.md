# ExpressionHelper

ExpressionHelper allows developers a tool to manipulate math equations and expressions.

This project is currently under development. The below examples and documentation may not be fully built yet.

### How to use it

Convert your string expressions into a form that will work for you.

```cs
// Left hand expression
string s_lhs = "2x";
AlgebraicExpression expr_lhs = new AlgebraicExpression(s_lhs);

// Right hand expression
string s_rhs = "12x^2 + 2x - 4";
AlgebraicExpression expr_rhs = new AlgebraicExpression(s_rhs);

Equation eq = new Equation(expr_lhs, expr_rhs);
IEnumerable<AlgebraicExpression> result = eq.Solve("x"); // Solve for 'x'

string s_result = String.Concat("[", string.Join(", ", result.Select(x => x.ToString())), "]"); // Produces "[sqrt(1/3), -sqrt(1/3)]"
```

```cs
AlgebraicExpression expr = new AlgebraicExpression("3x^2");
Derivative dx = expr.Derivative("x");
string result = dx.ToString(); // Produces "6x"
```

```cs
Vector vec1 = new Vector(3)
{
    new AlgebraicExpression("2x+1"),
    new AlgebraicExpression("x"),
    new AlgebraicExpression("x^2")
};
AlgebraicExpression expr = new AlgebraicExpression("5x-2");
AlgebraicExpression linearAlgebra_expr = new AlgebraicExpression(expr * vec1);
```

Please be aware, the examples above may not be available yet as it may be a work in project. These examples represent the intended use-cases and will change if needed during development.

## Documentation

Below is a list of the available classes and their functions.

1. `AlgebraicExpression`
    - `Derivative()`
    - `Integral()`
2. `Derivative`
    - `Derivative()`
    - `Integral()`
3. `Equation`
    - `Solve()`
4. `Integral`
    - `Derivative()`
    - `Integral()`
5. `Matrix`
    - `Determinant()`
6. `Vector`
    - `Dot()`
    - `Cross()`
    - `Proj()`

`ToString()` will build a string that represents the algebraic expression.
Operator overloads handle all addition, subtraction, multiplication and division operations.
