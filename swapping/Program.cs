using System;
public class Exercise1
{
    public static void Main(string[] args)
    {
        int number1, number2, temp;
        Console.Write("Input the First Number : ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("Input the Second Number : ");
        number2 = int.Parse(Console.ReadLine());
        temp = number1;
        number1 = number2;
        number2 = temp;
        Console.WriteLine("After Swapping ");
        Console.WriteLine("First Number : "+number1);
        Console.Write("Second Number : "+number2);
        Console.Read();
    }
}