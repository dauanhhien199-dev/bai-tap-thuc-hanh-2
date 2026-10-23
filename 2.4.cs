
using System;
using System.Collections.Generic;

List<Product> products = new List<Product>
{
    new Product("Ban phim", 55000, 10),
    new Product("Chuot may tinh", 400000, 15),
    new Product("Tai nghe", 90000, 8),
    new Product("Man hinh", 3200000, 6),
    new Product("USB", 3000000, 20)
};

Console.WriteLine(" BANG TON KHO ");
Console.WriteLine(
    $"{"Ten san pham",-20} {"Don gia",12} {"So luong",10} {"Thanh tien",15}");

double totalInventory = 0;

foreach (Product product in products)
{
    product.DisplayInfo();
    totalInventory += product.CalculateInventoryValue();
}

Console.WriteLine($"Tong gia tri ton kho: {totalInventory:N0} VND");

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public double CalculateInventoryValue()
    {
        return Price * Quantity;
    }

    public void DisplayInfo()
    {
        Console.WriteLine(
            $"{Name,-20} {Price,12:N0} {Quantity,10} " +
            $"{CalculateInventoryValue(),15:N0}");
    }
}
