using ConsoleCalculator;
using static System.Console;

AppDomain currentAppDomain = AppDomain.CurrentDomain;
currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);



WriteLine("Enter first number");
int number1 = int.Parse(ReadLine()!);

WriteLine("Enter second number");
int number2 = int.Parse(ReadLine()!);

WriteLine("Enter operation");
string operation = ReadLine()!.ToUpperInvariant();

try
{
    var calculator = new Calculator();
    int result = calculator.Calculate(number1, number2, operation);
    DisplayResult(result);
}
catch (ArgumentNullException ex) when (ex.ParamName?.Equals("operation") ?? false)
{
    WriteLine($"Operation was not provided. {ex}");
}
catch (ArgumentNullException ex)
{
    WriteLine($"An argument was null. {ex}");
}
catch (CalculationOperationNotSupportedException ex)
{
    WriteLine($"CalculationOperationNotSupportedException caught. {ex.Operation}");
    WriteLine(ex);
}
catch (CalculationException ex)
{
    WriteLine($"CalculationException caught");
    WriteLine(ex);
}
catch (Exception ex)
{
    WriteLine($"Sorry, something went wrong. {ex}");
}
finally
{
    WriteLine("...finally...");
}

WriteLine("\nPress enter to exit.");
ReadLine();

static void DisplayResult(int result) => WriteLine($"Result is: {result}");

static void HandleException(object sender, UnhandledExceptionEventArgs e) => WriteLine($"Sorry there was a problem and we need to close. Details: {e.ExceptionObject}");