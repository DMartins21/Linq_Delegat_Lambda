// See https://aka.ms/new-console-template for more information


using Linq_Lambda.Services;
using Linq_Lambda.Entities;



List<Product> list = new();
delegate double BinaryNumericOperation(double n1, double n2);
list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

list.Sort(comp);

foreach (Product item in list)
{
    Console.WriteLine(item);
}



double a = 10;
double b = 12;

BinaryNumericOperation op = CalculationService.Sum;


double result = op(a, b);

Console.WriteLine(result);