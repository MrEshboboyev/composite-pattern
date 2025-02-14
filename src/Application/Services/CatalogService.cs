using Domain.Models;

namespace Application.Services;

public class CatalogService
{
    public Category GetSampleCatalog()
    {
        var rootCategory = new Category("E-Commerce Catalog");

        var electronics = new Category("Electronics");
        var laptops = new Category("Laptops");
        var gamingLaptops = new Category("Gaming Laptops");

        var dellLaptop = new Product("Dell XPS 15", 1599.99m);
        var asusGamingLaptop = new Product("ASUS ROG Strix", 1899.99m);

        gamingLaptops.Add(asusGamingLaptop);
        laptops.Add(gamingLaptops);
        laptops.Add(dellLaptop);
        electronics.Add(laptops);

        var smartphones = new Category("Smartphones");
        var iphone = new Product("iPhone 15", 1299.99m);
        var samsung = new Product("Samsung Galaxy S23", 1199.99m);
        smartphones.Add(iphone);
        smartphones.Add(samsung);
        electronics.Add(smartphones);

        rootCategory.Add(electronics);

        return rootCategory;
    }
}