//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter a date (dd.MM.yyyy): ");
//        string input = Console.ReadLine();

//        if (DateTime.TryParse(input, out DateTime date))
//        {
//            string season = GetSeason(date);
//            string dayOfWeek = date.DayOfWeek.ToString();

//            Console.WriteLine($"{season} {dayOfWeek}");
//        }
//        else
//        {
//            Console.WriteLine("Error: Please enter a valid date in the format dd.MM.yyyy.");
//        }
//    }

//    static string GetSeason(DateTime date)
//    {
//        if (date.Month == 12 || date.Month <= 2)
//            return "Winter";
//        else if (date.Month >= 3 && date.Month <= 5)
//            return "Spring";
//        else if (date.Month >= 6 && date.Month <= 8)
//            return "Summer";
//        else
//            return "Autumn";
//    }
//}
