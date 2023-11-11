namespace ConsoleCalculator;

public class CalculationOperationNotSupportedException : CalculationException
{
    private const string DefaultMessage = "Specified operation was out of the range of valid values.";

    public string? Operation { get; set; }

    public CalculationOperationNotSupportedException() : base(DefaultMessage) { }

    public CalculationOperationNotSupportedException(Exception innerException) : base(innerException) { }

    public CalculationOperationNotSupportedException(string message, Exception innerException) : base(message, innerException) { }

    public CalculationOperationNotSupportedException(string operation) : this() => Operation = operation;

    public CalculationOperationNotSupportedException(string operation, string message) : base(message) => Operation = operation;

    public override string Message
    {
        get
        {
            if(Operation is null)
            {
                return base.Message;
            }

            return base.Message + Environment.NewLine + $"Unsupported operation: {Operation}";
        }
    }
}
