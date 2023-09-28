// See https://aka.ms/new-console-template for more information
using LINQFundamentals;

Console.WriteLine("Hello, World!");

LINQQueries linQQueries = new();

linQQueries.Display(linQQueries.GetAllProducts());
