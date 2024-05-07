// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
        new Product { Id = 1, Name = "Ноутбук", Category = "Електроніка", Price = 1200 },
        new Product { Id = 2, Name = "Футболка", Category = "Одяг", Price = 20 },
        new Product { Id = 3, Name = "Шоколадка", Category = "Їжа", Price = 2.5 },
        new Product { Id = 4, Name = "Смартфон", Category = "Електроніка", Price = 800 },
        new Product { Id = 5, Name = "Джинси", Category = "Одяг", Price = 50 },
        new Product { Id = 6, Name = "Морозиво", Category = "Їжа", Price = 3 },
        new Product { Id = 7, Name = "Телевiзор", Category = "Електроніка", Price = 1500 },
        new Product { Id = 8, Name = "Кросівки", Category = "Взуття", Price = 80 },
        new Product { Id = 9, Name = "Пiча", Category = "Їжа", Price = 10 },
        new Product { Id = 10, Name = "Монiтор", Category = "Електроніка", Price = 300 },
        new Product { Id = 11, Name = "Свiтшот", Category = "Одяг", Price = 35 },
        new Product { Id = 12, Name = "Книга", Category = "Книги", Price = 15 },
        new Product { Id = 13, Name = "Браслет", Category = "Прикраси", Price = 25 },
        new Product { Id = 14, Name = "Чайник", Category = "Побутова техніка", Price = 40 },
        new Product { Id = 15, Name = "Батонцик", Category = "Їжа", Price = 1.5 },
        new Product { Id = 16, Name = "Мишка", Category = "Електроніка", Price = 10 },
        new Product { Id = 17, Name = "Портфель", Category = "Аксесуари", Price = 70 },
        new Product { Id = 18, Name = "Спортивний костюм", Category = "Спорт", Price = 100 },
        new Product { Id = 19, Name = "Кавоварка", Category = "Побутова техніка", Price = 60 },
        new Product { Id = 20, Name = "Годинник", Category = "Прикраси", Price = 120 }
        };

        var mostExpensiveProduct = products.OrderByDescending(p => p.Price).FirstOrDefault();

        if (mostExpensiveProduct != null)
        {
            Console.WriteLine($"The most expensive product: {mostExpensiveProduct.Name}, Price: {mostExpensiveProduct.Price}");
        }
        else
        {
            Console.WriteLine("Item list is empty.");
        }
        Console.WriteLine("  ");

        var productsStartingWithC = products.Where(p => p.Name.StartsWith("С"));

        Console.WriteLine("Products with names that begin with a letter 'С':");
        foreach (var product in productsStartingWithC)
        {
            Console.WriteLine($"Name : {product.Name}, Price: {product.Price}");
        }
        Console.WriteLine("  ");

        var minPrice = products.Min(p => p.Price);

        Console.WriteLine($"Lowest price among goods: {minPrice}");

        Console.WriteLine("  ");

        var sortedProducts = products.OrderBy(p => p.Price).ToList();

        // Виведення відсортованого списку
        Console.WriteLine("List of items sorted by price in ascending order:");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        Console.WriteLine("  ");

        var minIdProduct = products.OrderBy(p => p.Id).FirstOrDefault();

        if (minIdProduct != null)
        {
            Console.WriteLine($"Item with lowest ID: {minIdProduct.Name}");
        }
        else
        {
            Console.WriteLine("Item list is empty.");
        }

        Console.WriteLine("  ");

        int totalCount = products.Count;

        Console.WriteLine($"Total products: {totalCount}");

        Console.WriteLine("  ");

        var electronicProducts = products.Where(p => p.Category == "Електроніка").ToList();

        Console.WriteLine("Products from the category 'Електронiка':");
        
         foreach (var product in electronicProducts)
         {
                Console.WriteLine($"{product.Id}, {product.Name}, {product.Price}");
         }
        
        //WRITE YOUR CODE HERE
    }
}