# SimpleCalculator - .NET Console Project

This project is a simple calculator application, built with .NET, to practice and demonstrate the usage of Xunit, FluentAssertions, and Stryker.

## Project Overview

SimpleCalculator is a .NET Console application that provides basic arithmetic operations like addition, subtraction, multiplication, and division. The main focus of this project is to showcase the implementation of Xunit for unit testing, FluentAssertions for more expressive assertions, and Stryker for mutation testing.

## Prerequisites

- .NET 5.0 or higher: https://dotnet.microsoft.com/download
- Visual Studio Code or any compatible IDE: https://code.visualstudio.com/

## Getting Started

1. Clone the repository:

    git clone https://github.com/GMoreyra/SimpleCalculator.git

2. Navigate to the project directory:

    cd SimpleCalculator

3. Restore the NuGet packages:

    dotnet restore

4. Build the project:

    dotnet build

5. Run the project:

    dotnet run --project SimpleCalculator

## Running Tests

To run the tests, execute the following command:

dotnet test

## Dependencies

- Xunit: https://xunit.net/
- FluentAssertions: https://fluentassertions.com/
- Stryker: https://stryker-mutator.io/

## Project Structure

- **SimpleCalculator**: The main console application project.
- **SimpleCalculator.Tests**: The Xunit test project containing unit tests for SimpleCalculator.

### SimpleCalculator

- `Program.cs`: The entry point of the console application.
- `Calculator.cs`: The main class responsible for arithmetic operations.

### SimpleCalculator.Tests

- `CalculatorTests.cs`: Xunit test class containing unit tests for Calculator class.
- `StrykerConfig.json`: Stryker configuration file for mutation testing.

## Contributing

Feel free to submit issues or pull requests to improve the project. All contributions are welcome!

## License

This project is licensed under the MIT License.



