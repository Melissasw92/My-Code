using System;
using LockerRental.Actions;

public class ConsoleIO
{

public static void DisplayLockerContents(LockerContents _lockers, int lockerNumber)
{
    Console.WriteLine($"Locker {lockerNumber} contents: {_lockers.Description} (Rented by {_lockers.renterName}).");

}

public static string GetRequiredString(string prompt)
{
        Console.WriteLine(prompt);
        return Console.ReadLine();
}

public static int GetLockerNumber()
{
    Console.Write("Enter locker number (1-100): ");
         return int.Parse(Console.ReadLine());

}

public static int GetMenuOption()
{
    Console.Clear();
    Console.WriteLine("Locker Rental Menu");
    Console.WriteLine("=============================");
    Console.WriteLine("1. View a locker");
    Console.WriteLine("2. Rent a locker");
    Console.WriteLine("3. End a locker rental");
    Console.WriteLine("4. List all locker contents");
    Console.WriteLine("5. Quit");
    Console.Write("\nEnter your choice (1-5): ");
    return int.Parse(Console.ReadLine());

}

public static void AnyKey()
{
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
}
}