using System;

class Product
{
    int productId;
    string productName;
    double price;
    string color;

    void Display()
    {
        Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        Console.ReadLine();
    }
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
class ProductModel
{
    static void Main(string[] args)
    {
        Product product1;
        product1 = new Product();
        product1.productId = 271099;
        product1.productName = "disk";
        product1.price = 7000;
        product1.color = "yellow";

        product1.Display();

    }
}