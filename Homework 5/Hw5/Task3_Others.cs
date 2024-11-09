public class Violin : MusicalInstrument
{
    public Violin() : base("Скрипка", "Струнний музичний інструмент")
    { }

    public override void Sound()
    {
        Console.WriteLine("Скрипка звучить: ла-ла-ла.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва інструменту: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Опис: {Description}");
    }

    public override void History()
    {
        Console.WriteLine("Історія: Скрипка була створена в Італії у XVI столітті.");
    }
}

public class Trombone : MusicalInstrument
{
    public Trombone() : base("Тромбон", "Мідний духовий музичний інструмент")
    { }

    public override void Sound()
    {
        Console.WriteLine("Тромбон звучить: до-до-до.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва інструменту: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Опис: {Description}");
    }

    public override void History()
    {
        Console.WriteLine("Історія: Тромбон виник у XV столітті в Європі.");
    }
}

public class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Укулеле", "Малий струнний музичний інструмент з Гавайських островів")
    { }

    public override void Sound()
    {
        Console.WriteLine("Укулеле звучить: ді-ді-ді.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва інструменту: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Опис: {Description}");
    }

    public override void History()
    {
        Console.WriteLine("Історія: Укулеле з'явилося на Гавайських островах у XIX столітті.");
    }
}

public class Cello : MusicalInstrument
{
    public Cello() : base("Віолончель", "Струнний музичний інструмент, більший за скрипку")
    { }

    public override void Sound()
    {
        Console.WriteLine("Віолончель звучить: дооо-дооо.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва інструменту: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Опис: {Description}");
    }

    public override void History()
    {
        Console.WriteLine("Історія: Віолончель з'явилася в Італії в XVI столітті.");
    }
}
