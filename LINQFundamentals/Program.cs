// See https://aka.ms/new-console-template for more information
using LINQFundamentals;

Console.WriteLine("Hello, World!");

LINQQueries linQQueries = new();

//linQQueries.Display(linQQueries.GetAllProducts());

//linQQueries.Display(linQQueries.GetNameFromProducts());

//linQQueries.Display(linQQueries.GetSpecificColumnNames());

//linQQueries.Display(linQQueries.GetColumnWithAnonymousClass());

//linQQueries.Display(linQQueries.GetProductsInOrder());

linQQueries.Display(linQQueries.WhereExtensionByColor());
