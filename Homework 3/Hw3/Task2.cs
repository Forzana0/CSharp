using System;

public class Program2
{
    public static bool IsPalindrome(int number)
    {
        int original = number;
        int reverse = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number /= 10;
        }

        return original == reverse;
    }

    public static void Main()
    {
        Console.WriteLine(IsPalindrome(1221));
        Console.WriteLine(IsPalindrome(3443)); 
        Console.WriteLine(IsPalindrome(7854)); 
    }
}
