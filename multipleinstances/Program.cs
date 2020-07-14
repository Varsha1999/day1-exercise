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
    internal Product()
    {
        Console.WriteLine("empty object initialization");
        Console.ReadLine();
    }
    internal Product(int productId, string productName, double price, string color)
    {
        Console.WriteLine("object initialiazation");
        Console.ReadLine();
        this.productId = productId;
        this.productName = productName;
        this.price = price;
        this.color = color;
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
        Product product2;
        product2 = new Product(271099, "disk", 3000, "blue");
        product2.Display();

        product1 = new Product(1027, "drive", 2500, "green");
        product1.Display();
    }
}