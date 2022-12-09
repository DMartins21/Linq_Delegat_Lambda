// See https://aka.ms/new-console-template for more information


using Linq_Lambda.Services;
using Linq_Lambda.Entities;


double a = 10;
double b = 12;

BinaryNumericOperation op = CalculationService.Sum;

double result = op(a, b);

Console.WriteLine(result);

delegate double BinaryNumericOperation(double n1, double n2);

