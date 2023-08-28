using System;

class Calculator {
    public int Add(int x, int y) {
        return x + y;
    }

    public int Subtract(int x, int y) {
        return x - y;
    }

    public int Multiply(int x, int y) {
        return x * y;
    }

    public int Divide(int x, int y) {
        if (y != 0) {
            return x / y;
        } else {
            Console.WriteLine("Error: Division by zero.");
            return 0;
        }
    }
}

class Program {
    static void Main(string[] args) {
        Calculator calculator = new Calculator();

        Console.WriteLine("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = 0;
        switch (operation) {
            case '+':
                result = calculator.Add(num1, num2);
                break;
            case '-':
                result = calculator.Subtract(num1, num2);
                break;
            case '*':
                result = calculator.Multiply(num1, num2);
                break;
            case '/':
                result = calculator.Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}
