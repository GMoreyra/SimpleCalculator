public class Calculator
{
    public double Add(double first, double second)
    {
        return first + second;
    }

    public double Subtract(double first, double second)
    {
        return first - second;
    }

    public double Multiply(double first, double second)
    {
        return first * second;
    }

    public double Divide(double first, double second)
    {
        if (second == 0)
        {
            throw new DivideByZeroException();
        }

        return first / second;
    }
}