using System;
using System.Collections.Generic;
using System.Linq;

public class CafeQueue
{
    private Queue<string> queue;
    private HashSet<string> reservedGuests;

    public CafeQueue()
    {
        queue = new Queue<string>();
        reservedGuests = new HashSet<string>();
    }

    public void AddVisitor(string name, bool hasReservation)
    {
        if (hasReservation)
        {
            reservedGuests.Add(name);
            Console.WriteLine($"Visitor {name} has a reservation and is served out of turn.");
        }
        else
        {
            queue.Enqueue(name);
            Console.WriteLine($"Visitor {name} added to the queue.");
        }
    }

    public void ServeVisitor()
    {
        if (reservedGuests.Count > 0)
        {
            string visitor = reservedGuests.First();
            reservedGuests.Remove(visitor);
            Console.WriteLine($"Visitor {visitor} got the reserved table.");
        }
        else if (queue.Count > 0)
        {
            string visitor = queue.Dequeue();
            Console.WriteLine($"Visitor {visitor} got a table.");
        }
        else
        {
            Console.WriteLine("The queue is empty.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        CafeQueue cafe = new CafeQueue();

        cafe.AddVisitor("Alice", false);
        cafe.AddVisitor("Bob", true);
        cafe.AddVisitor("Charlie", false);

        cafe.ServeVisitor();
        cafe.ServeVisitor();
        cafe.ServeVisitor();
        cafe.ServeVisitor();
    }
}
