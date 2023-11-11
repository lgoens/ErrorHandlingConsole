namespace ConsoleCalculator;

public class Calculator
{
    public int Calculate(int number1, int number2, string operation) => operation switch
    {
        null => throw new ArgumentNullException(nameof(operation)),
        "/" => Divide(number1, number2),
        "+" => Sum(number1, number2),            
        _ => throw new CalculationOperationNotSupportedException(operation)
    };

    private int Sum(int number1, int number2) => number1 + number2;

    private int Divide(int number, int divisor) => Math.DivRem(number, divisor).Quotient;
}

