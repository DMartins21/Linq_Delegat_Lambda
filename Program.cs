// See https://aka.ms/new-console-template for more information
using Linq_Lambda.Services;
using Linq_Lambda.Entities;
using System.Collections.Generic;
using System.Linq;

List<Product> list = new();

list.Add(new Product("TV", 900.00M));
list.Add(new Product("Mouse", 50.00M));
list.Add(new Product("Notebook", 1200.00M));
list.Add(new Product("Tablet", 450.00M));

//list.RemoveAll(ProductTest);

//list.ForEach(UpdatePrice);

List<string> result = list.Select(NameUpper).ToList();

foreach (string item in result)
{
    Console.WriteLine(item);
}

static bool ProductTest(Product p)
{
    return p.Price >= 100.00M;
}

static void UpdatePrice(Product p)
{
    p.Price += p.Price * 0.1M;
}

static string NameUpper(Product p)
{
   return p.Name.ToUpper();
}