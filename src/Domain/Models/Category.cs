using System;
using Domain.Interfaces;

namespace Domain.Models;

public class Category(string name) : ICatalogComponent
{
    public string Name { get; } = name;
    private readonly List<ICatalogComponent> _children = [];

    public void Add(ICatalogComponent component)
    {
        _children.Add(component);
    }

    public void Remove(ICatalogComponent component)
    {
        _children.Remove(component);
    }

    public void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + $"📂 {Name}");
        foreach (var component in _children)
        {
            component.Display(depth + 2);
        }
    }
}