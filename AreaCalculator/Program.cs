using System;

ConsoleApplication.Run();

public class ConsoleApplication
{
    public static void Run()
    {
        Console.WriteLine("What type of shape (R)ectangle, (T)riangle, (C)ircle?");
        string shapes = (Console.ReadLine().ToUpper());

        

        if (shapes != "R" && shapes != "T" && shapes != "C")
        {
            Console.WriteLine("Invalid input. Please try again.");
            return;
        }

        double length, width, radius;

        switch (shapes)
        {
            case "R":
            Console.WriteLine("Enter the length: ");
            length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width: ");
            width = double.Parse(Console.ReadLine());

            double areaR = length * width;

            Console.WriteLine($"The area of this rectangle is {areaR}.");
            break;

            case "T":
                Console.WriteLine("Enter the base: ");
                double baseT = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height: ");
                double height = double.Parse(Console.ReadLine());

                double areaT = 0.5 * baseT * height;

                Console.WriteLine($"The area of this triangle is {areaT}.");
                break;
            

            case "C":
                
                    
                Console.WriteLine("Enter the radius: ");
                radius = double.Parse(Console.ReadLine());

                double areaC = Math.PI * radius * radius;

                Console.WriteLine($"The area of this triangle is {areaC}.");
                break;

            }

        }
    }