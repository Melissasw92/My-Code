using System;

public class Temperature
{
    private double kelvin;
    public double Kelvin
    {
        get { return kelvin; }
        set
        {
            kelvin = value < 0 ? 0 : value;
        }
    }
    public double Celsius => Kelvin - 273.15;

    public double Fahrenheit => Celsius * 9 / 5 + 32;
}

class Program
{

    static void Main(string[] args)
    {
        Temperature t1 = new Temperature();

        Console.Write("Enter temperature (K): ");
        t1.Kelvin = double.Parse(Console.ReadLine());

        Console.WriteLine($"The temperature is {t1.Kelvin}K, {t1.Celsius}C, {t1.Fahrenheit}F.");


    }

}