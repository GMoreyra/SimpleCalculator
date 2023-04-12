namespace SimpleCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine("Enter two numbers separated by a space:");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || !Helper.regexValidator(input))
            {
                Console.WriteLine("Invalid input. Please enter two numbers separated by a space.");
                return;
            }

            var numbers = input.Split(' ');

            if (!double.TryParse(numbers[0], out double first) || !double.TryParse(numbers[1], out double second))
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
                return;
            }

            Console.WriteLine($"Addition: {calculator.Add(first, second)}");
            Console.WriteLine($"Subtraction: {calculator.Subtract(first, second)}");
            Console.WriteLine($"Multiplication: {calculator.Multiply(first, second)}");
            Console.WriteLine($"Division: {calculator.Divide(first, second)}");

        }
    }
}
