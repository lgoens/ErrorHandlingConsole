namespace ConsoleCalculator;

public class Calculator
{
    public int Calculate(int number1, int number2, string operation)
    {
        if (operation.Equals("/"))
        {
            return Divide(number1, number2);
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(operation), "The math operator is not supported");
        }
    }

    private int Divide(int number, int divisor) => Math.DivRem(number, divisor).Quotient;
}
