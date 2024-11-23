using System;

public class Journal
{
    private string name;
    private int yearFounded;
    private string description;
    private string contactPhone;
    private string email;
    private int numberOfEmployees;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int YearFounded
    {
        get { return yearFounded; }
        set { yearFounded = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string ContactPhone
    {
        get { return contactPhone; }
        set { contactPhone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public int NumberOfEmployees
    {
        get { return numberOfEmployees; }
        set { numberOfEmployees = value; }
    }

    public void EnterJournalData(string name, int yearFounded, string description, string contactPhone, string email, int numberOfEmployees)
    {
        this.name = name;
        this.yearFounded = yearFounded;
        this.description = description;
        this.contactPhone = contactPhone;
        this.email = email;
        this.numberOfEmployees = numberOfEmployees;
    }

    public void DisplayJournalData()
    {
        Console.WriteLine($"Journal Name: {name}");
        Console.WriteLine($"Year Founded: {yearFounded}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Contact Phone: {contactPhone}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Number of Employees: {numberOfEmployees}");
    }

    public static Journal operator +(Journal journal, int employeesToAdd)
    {
        journal.numberOfEmployees += employeesToAdd;
        return journal;
    }

    public static Journal operator -(Journal journal, int employeesToRemove)
    {
        journal.numberOfEmployees -= employeesToRemove;
        return journal;
    }

    public static bool operator ==(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees == journal2.numberOfEmployees;
    }

    public static bool operator !=(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees != journal2.numberOfEmployees;
    }

    public static bool operator <(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees < journal2.numberOfEmployees;
    }

    public static bool operator >(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees > journal2.numberOfEmployees;
    }

    public static bool operator <=(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees <= journal2.numberOfEmployees;
    }

    public static bool operator >=(Journal journal1, Journal journal2)
    {
        return journal1.numberOfEmployees >= journal2.numberOfEmployees;
    }

    public override bool Equals(object obj)
    {
        if (obj is Journal)
        {
            var otherJournal = (Journal)obj;
            return this.numberOfEmployees == otherJournal.numberOfEmployees;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return numberOfEmployees.GetHashCode();
    }
}
