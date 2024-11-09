using System;

public abstract class Device
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Sound();
    public abstract void Show();
    public abstract void Desc();
}
