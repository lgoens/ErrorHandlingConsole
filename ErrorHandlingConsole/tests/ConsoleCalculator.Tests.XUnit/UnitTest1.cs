namespace ConsoleCalculator.Tests.XUnit;

public class UnitTest1
{
    [Fact]
    public void TesThrownWhenUnsupportedOperationt1()
    {
        var sut = new Calculator();

        Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));

        Assert.ThrowsAny<CalculationException>(() => sut.Calculate(1, 1, "+"));

        var ex = Assert.Throws<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));

        Assert.Equal("+", ex.Operation);
    }
}