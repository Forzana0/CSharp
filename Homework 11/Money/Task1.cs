using System;

public class Money
{
    private int grivnias;
    private int kopecks;

    public Money(int grivnias, int kopecks)
    {
        if (grivnias < 0 || kopecks < 0)
            throw new InvalidOperationException("Bankrupt");

        this.grivnias = grivnias + kopecks / 100;
        this.kopecks = kopecks % 100;
    }

    public static Money operator +(Money a, Money b)
    {
        int newKopecks = a.kopecks + b.kopecks;
        int newGrivnias = a.grivnias + b.grivnias + newKopecks / 100;
        newKopecks = newKopecks % 100;

        if (newGrivnias < 0 || newKopecks < 0)
            throw new InvalidOperationException("Bankrupt");

        return new Money(newGrivnias, newKopecks);
    }

    public static Money operator -(Money a, Money b)
    {
        int newKopecks = a.kopecks - b.kopecks;
        int newGrivnias = a.grivnias - b.grivnias;

        if (newKopecks < 0)
        {
            newKopecks += 100;
            newGrivnias--;
        }

        if (newGrivnias < 0 || newKopecks < 0)
            throw new InvalidOperationException("Bankrupt");

        return new Money(newGrivnias, newKopecks);
    }

    public static Money operator /(Money a, int b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero");

        int totalKopecks = a.grivnias * 100 + a.kopecks;
        totalKopecks /= b;

        if (totalKopecks < 0)
            throw new InvalidOperationException("Bankrupt");

        return new Money(totalKopecks / 100, totalKopecks % 100);
    }

    public static Money operator *(Money a, int b)
    {
        int totalKopecks = (a.grivnias * 100 + a.kopecks) * b;

        if (totalKopecks < 0)
            throw new InvalidOperationException("Bankrupt");

        return new Money(totalKopecks / 100, totalKopecks % 100);
    }

    public static Money operator ++(Money a)
    {
        int totalKopecks = a.grivnias * 100 + a.kopecks + 1;

        if (totalKopecks < 0)
            throw new InvalidOperationException("Bankrupt");

        return new Money(totalKopecks / 100, totalKopecks % 100);
    }

    public static Money operator --(Money a)
    {
        int totalKopecks = a.grivnias * 100 + a.kopecks - 1;

        if (totalKopecks < 0)
            throw new InvalidOperationException("Bankrupt");

        return new Money(totalKopecks / 100, totalKopecks % 100);
    }

    public static bool operator <(Money a, Money b)
    {
        return a.grivnias < b.grivnias || (a.grivnias == b.grivnias && a.kopecks < b.kopecks);
    }

    public static bool operator >(Money a, Money b)
    {
        return a.grivnias > b.grivnias || (a.grivnias == b.grivnias && a.kopecks > b.kopecks);
    }

    public static bool operator ==(Money a, Money b)
    {
        return a.grivnias == b.grivnias && a.kopecks == b.kopecks;
    }

    public static bool operator !=(Money a, Money b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj is Money other)
            return this == other;
        return false;
    }

    public override int GetHashCode()
    {
        return grivnias.GetHashCode() ^ kopecks.GetHashCode();
    }

    public override string ToString()
    {
        return $"{grivnias} UAH {kopecks} Kop";
    }
}

class Program
{
    static void Main1()
    {
        try
        {
            Money money1 = new Money(10, 50);
            Money money2 = new Money(5, 60);

            Money resultAdd = money1 + money2;
            Money resultSub = money1 - money2;
            Money resultMul = money1 * 2;
            Money resultDiv = money1 / 2;
            Money resultInc = ++money1;
            Money resultDec = --money1;

            Console.WriteLine($"Addition: {resultAdd}");
            Console.WriteLine($"Subtraction: {resultSub}");
            Console.WriteLine($"Multiplication: {resultMul}");
            Console.WriteLine($"Division: {resultDiv}");
            Console.WriteLine($"Increment: {resultInc}");
            Console.WriteLine($"Decrement: {resultDec}");

            Console.WriteLine(money1 > money2);
            Console.WriteLine(money1 < money2);
            Console.WriteLine(money1 == money2);
            Console.WriteLine(money1 != money2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
