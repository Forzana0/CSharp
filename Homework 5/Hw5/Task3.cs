using System;

public abstract class MusicalInstrument
{
    public string Name { get; set; }
    public string Description { get; set; }

    public MusicalInstrument(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public abstract void Sound();
    public abstract void Show();
    public abstract void Desc();
    public abstract void History();
}
