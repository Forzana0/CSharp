using System;

class Program
{
    public delegate void MessageDelegate(string message);

    static void Main()
    {
        MessageDelegate msgDelegate = DisplayMessage;
        msgDelegate.Invoke("Hello, this is a test message!");

        msgDelegate = DisplayMessageUpperCase;
        msgDelegate.Invoke("Hello, this is another test message!");

        msgDelegate = (message) => Console.WriteLine("Anonymous method: " + message);
        msgDelegate.Invoke("This is an anonymous method message.");
    }

    static void DisplayMessage(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    static void DisplayMessageUpperCase(string message)
    {
        Console.WriteLine("Uppercase Message: " + message.ToUpper());
    }
}
