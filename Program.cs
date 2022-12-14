// See https://aka.ms/new-console-template for more information
using System.Linq;

int[] numbers = new int[] { 2, 3, 4, 5 };

IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
foreach(var r in result)
{
    Console.WriteLine(r);
}