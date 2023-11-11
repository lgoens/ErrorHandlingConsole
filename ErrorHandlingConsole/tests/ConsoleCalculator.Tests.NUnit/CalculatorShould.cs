namespace ConsoleCalculator.Tests.NUnit;

public class CalculatorShould
{
    [Test]
    public void ThrownWhenUnsupportedOperation()
    {
        var sut = new Calculator();

        Assert.That(() => sut.Calculate(1, 2, "+"),
           Throws.TypeOf<CalculationOperationNotSupportedException>()
           .With
           .Property("Operation").EqualTo("+"));

        var ex = Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 2, "+"));

        Assert.That(ex!.Operation, Is.EqualTo("+"));

    }
}