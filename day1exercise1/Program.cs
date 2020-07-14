using System;
public class Exercise1
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the amount of celsius: ");
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fahrenheit ={0}  ", celsius * 18 / 10 + 32);
        Console.ReadLine();
    }
}
