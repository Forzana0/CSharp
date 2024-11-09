public class Kettle : Device
{
    public Kettle() : base("Чайник", "Пристрій для кип'ятіння води")
    { }

    public override void Sound()
    {
        Console.WriteLine("Шипіння чайника.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва пристрою: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Опис: {Description}");
    }
}

public class Microwave : Device
{
    public Microwave() : base("Мікрохвильовка", "Пристрій для швидкого розігрівання їжі")
    { }

    public override void Sound()
    {
        Console.WriteLine("Біп-біп, мікрохвильовка розігріває їжу.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва пристрою: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Опис: {Description}");
    }
}

public class Car : Device
{
    public Car() : base("Автомобіль", "Транспортний засіб на колесах")
    { }

    public override void Sound()
    {
        Console.WriteLine("Гуде двигун автомобіля.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва пристрою: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Опис: {Description}");
    }
}

public class Steamboat : Device
{
    public Steamboat() : base("Пароплав", "Корабель, що рухається за допомогою пари")
    { }

    public override void Sound()
    {
        Console.WriteLine("Гудок пароплава.");
    }

    public override void Show()
    {
        Console.WriteLine($"Назва пристрою: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Опис: {Description}");
    }
}
