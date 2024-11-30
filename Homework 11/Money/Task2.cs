using System;

class Program2
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a logical expression:");
            string input = Console.ReadLine();
            bool result = EvaluateExpression(input);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static bool EvaluateExpression(string expression)
    {
        string[] validOperators = { "<", ">", "<=", ">=", "==", "!=" };
        foreach (var op in validOperators)
        {
            if (expression.Contains(op))
            {
                string[] parts = expression.Split(new string[] { op }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    int left = int.Parse(parts[0].Trim());
                    int right = int.Parse(parts[1].Trim());

                    switch (op)
                    {
                        case "<":
                            return left < right;
                        case ">":
                            return left > right;
                        case "<=":
                            return left <= right;
                        case ">=":
                            return left >= right;
                        case "==":
                            return left == right;
                        case "!=":
                            return left != right;
                    }
                }
            }
        }
        throw new InvalidOperationException("Invalid logical expression");
    }
}
