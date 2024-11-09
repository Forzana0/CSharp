public class President : Worker
{
    public President(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"{Name} — Президент компанії.");
    }
}

public class Security : Worker
{
    public Security(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"{Name} — Охоронець компанії.");
    }
}

public class Manager : Worker
{
    public Manager(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"{Name} — Менеджер компанії.");
    }
}

public class Engineer : Worker
{
    public Engineer(string name) : base(name) { }

    public override void Print()
    {
        Console.WriteLine($"{Name} — Інженер компанії.");
    }
}
