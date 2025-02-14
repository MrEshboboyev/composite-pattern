using Domain.Interfaces;

namespace Domain.Models;

public class Product(string name, decimal price) : ICatalogComponent
{
    public string Name { get; } = name;
    public decimal Price { get; } = price;

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + $"📦 {Name} - ${Price}");
    }
}
