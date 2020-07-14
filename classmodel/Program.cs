using System;

class Product
{
    internal int productId;
    internal string productName;
    internal double price;
    internal string color;

    internal void Display()
    {
        Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        Console.ReadLine();
    }
}
class ProductModel
{
    static void Main(string[] args)
    {
        Product product1;
        product1 = new Product();
        product1.productId = 2710;
        product1.productName = "hard disk";
        product1.price = 5000;
        product1.color = "cyan";

        product1.Display();

    }
}
        
    
