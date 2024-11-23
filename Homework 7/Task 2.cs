using System;

public class Store
{
    private string storeName;
    private string storeAddress;
    private string storeDescription;
    private string contactPhone;
    private string email;
    private double storeArea;
    public string StoreName
    {
        get { return storeName; }
        set { storeName = value; }
    }

    public string StoreAddress
    {
        get { return storeAddress; }
        set { storeAddress = value; }
    }

    public string StoreDescription
    {
        get { return storeDescription; }
        set { storeDescription = value; }
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

    public double StoreArea
    {
        get { return storeArea; }
        set { storeArea = value; }
    }

    public void EnterStoreData(string storeName, string storeAddress, string storeDescription, string contactPhone, string email, double storeArea)
    {
        this.storeName = storeName;
        this.storeAddress = storeAddress;
        this.storeDescription = storeDescription;
        this.contactPhone = contactPhone;
        this.email = email;
        this.storeArea = storeArea;
    }

    public void DisplayStoreData()
    {
        Console.WriteLine($"Store Name: {storeName}");
        Console.WriteLine($"Store Address: {storeAddress}");
        Console.WriteLine($"Description: {storeDescription}");
        Console.WriteLine($"Contact Phone: {contactPhone}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Store Area: {storeArea} square meters");
    }

    public static Store operator +(Store store, double areaToAdd)
    {
        store.storeArea += areaToAdd;
        return store;
    }

    public static Store operator -(Store store, double areaToRemove)
    {
        store.storeArea -= areaToRemove;
        return store;
    }

    public static bool operator ==(Store store1, Store store2)
    {
        return store1.storeArea == store2.storeArea;
    }

    public static bool operator !=(Store store1, Store store2)
    {
        return store1.storeArea != store2.storeArea;
    }

    public static bool operator <(Store store1, Store store2)
    {
        return store1.storeArea < store2.storeArea;
    }

    public static bool operator >(Store store1, Store store2)
    {
        return store1.storeArea > store2.storeArea;
    }

    public static bool operator <=(Store store1, Store store2)
    {
        return store1.storeArea <= store2.storeArea;
    }

    public static bool operator >=(Store store1, Store store2)
    {
        return store1.storeArea >= store2.storeArea;
    }

    public override bool Equals(object obj)
    {
        if (obj is Store)
        {
            var otherStore = (Store)obj;
            return this.storeArea == otherStore.storeArea;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return storeArea.GetHashCode();
    }
}
