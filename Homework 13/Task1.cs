using System;
using System.Collections.Generic;

public class EmployeeManagement
{
    private Dictionary<string, string> employees;

    public EmployeeManagement()
    {
        employees = new Dictionary<string, string>();
    }

    public void AddEmployee(string login, string password)
    {
        if (employees.ContainsKey(login))
        {
            Console.WriteLine("This login already exists.");
        }
        else
        {
            employees[login] = password;
            Console.WriteLine("Employee added.");
        }
    }

    public void RemoveEmployee(string login)
    {
        if (employees.ContainsKey(login))
        {
            employees.Remove(login);
            Console.WriteLine("Employee removed.");
        }
        else
        {
            Console.WriteLine("Employee with this login not found.");
        }
    }

    public void ChangePassword(string login, string newPassword)
    {
        if (employees.ContainsKey(login))
        {
            employees[login] = newPassword;
            Console.WriteLine("Password changed.");
        }
        else
        {
            Console.WriteLine("Employee with this login not found.");
        }
    }

    public void GetPassword(string login)
    {
        if (employees.ContainsKey(login))
        {
            Console.WriteLine($"Password for {login}: {employees[login]}");
        }
        else
        {
            Console.WriteLine("Employee with this login not found.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        EmployeeManagement manager = new EmployeeManagement();

        manager.AddEmployee("alice", "password123");
        manager.AddEmployee("bob", "password456");

        manager.GetPassword("alice");
        manager.ChangePassword("alice", "newpassword");
        manager.GetPassword("alice");

        manager.RemoveEmployee("bob");
        manager.GetPassword("bob");
    }
}
