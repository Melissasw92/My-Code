using System;

ConsoleApplication.Run();

public class ConsoleApplication
{
    public static void Run()
    {
       
            Console.WriteLine("Enter the purchase price: ");
            double purchasePrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the tax rate: ");
            double taxrate = double.Parse(Console.ReadLine());

            double taxAmount = purchasePrice * (taxrate / 100);

            double total = purchasePrice + taxAmount;



            Console.WriteLine($"For your ${purchasePrice:C2} purchase, a {taxrate}% tax is ${taxAmount:C2} for a total of ${total:C}");
        }
    }
