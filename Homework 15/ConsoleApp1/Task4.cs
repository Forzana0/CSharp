using System;

class Program
{
    public delegate double ArithmeticOperation(double a, double b);

    static void Main()
    {
        ArithmeticOperation add = Add;
        ArithmeticOperation subtract = Subtract;
        ArithmeticOperation multiply = Multiply;

        Console.WriteLine("Addition using Invoke: " + add.Invoke(5, 3));
        Console.WriteLine("Subtraction using Invoke: " + subtract.Invoke(5, 3));
        Console.WriteLine("Multiplication using Invoke: " + multiply.Invoke(5, 3));
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }
}
