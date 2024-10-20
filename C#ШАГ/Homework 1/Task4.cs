//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a six-digit number: ");
//        string input = Console.ReadLine();

//        if (input.Length != 6 || !int.TryParse(input, out _))
//        {
//            Console.WriteLine("Error: Please enter a valid six-digit number.");
//            return;
//        }

//        Console.Write("Enter the first digit position to swap (1-6): ");
//        int firstIndex = int.Parse(Console.ReadLine()) - 1;

//        Console.Write("Enter the second digit position to swap (1-6): ");
//        int secondIndex = int.Parse(Console.ReadLine()) - 1;

//        if (firstIndex < 0 || firstIndex >= 6 || secondIndex < 0 || secondIndex >= 6)
//        {
//            Console.WriteLine("Error: Positions must be between 1 and 6.");
//            return;
//        }

//        char[] digits = input.ToCharArray();

//        char temp = digits[firstIndex];
//        digits[firstIndex] = digits[secondIndex];
//        digits[secondIndex] = temp;

//        string result = new string(digits);
//        Console.WriteLine($"Result: {result}");
//    }
//}
