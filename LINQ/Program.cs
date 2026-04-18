using LINQ.DataSources;
using LINQ.Models;
using System.Collections;
using System.Diagnostics.Metrics;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var productList = Source.ProductList;
			#region Q1

			//var MostExpensiveProducts = productList
			//	.OrderByDescending(p => p.UnitPrice)
			//	.Take(3);
			//foreach (var product in MostExpensiveProducts)
			//{
			//	Console.WriteLine(product);
			//}


			#endregion

			#region Q2

			//int pageSize = 5;
			//int pageNumber = 2;
			//var pagination = productList
			//	.OrderBy(p => p.ProductID)
			//	.Skip((pageNumber - 1) * pageSize)
			//	.Take(pageSize)
			//	.ToList();	
			//foreach (var item in pagination)
			//{
			//	Console.WriteLine(item);
			//}

			#endregion

			#region Q3

			//var productsLessThan25 = productList
			//	.OrderBy(p => p.UnitPrice)
			//	.TakeWhile(p => p.UnitPrice < 25);

			//foreach (var item in productsLessThan25)
			//{
			//	Console.WriteLine(item);
			//}

			#endregion

			#region Q4

			//var allSeafoodInStock = productList
			//	.Where(p => p.Category == "Seafood")
			//	.All(p => p.UnitsInStock > 0);

			//Console.WriteLine($"All seafood products in stock: {allSeafoodInStock}");

			#endregion

			#region Q5

			//int[] ids = { 3, 9, 13, 18 };

			//var contain = ids.Contains(9);
			//Console.WriteLine($"ID list contains 9: {contain}");

			#endregion

			#region Q6

			//var productsByCategory = productList
			//	.GroupBy(p => p.Category)
			//	.Select(g => new { Category = g.Key, Count = g.Count() });

			//foreach (var group in productsByCategory)
			//{
			//	Console.WriteLine($"Category: {group.Category}, Count: {group.Count}");
			//}

			#endregion

			#region Q7


			//var productsByCategory = productList
			//	.ToLookup(p => p.Category, p => p.ProductName);

			//foreach (var group in productsByCategory)
			//{
			//	int c = 0;
			//	Console.WriteLine("\n=============================");

			//	Console.WriteLine($"Category: {group.Key}");
			//	Console.WriteLine("\n");

			//	foreach (var name in group)
			//	{
			//		c++;

			//		Console.WriteLine($"{c}-{name}");
			//	}
			//}


			#endregion

			#region Q8

			//var categoriesMoreThan3Products = productList
			//	.GroupBy(p => p.Category)
			//	.Where(g => g.Count() > 3)
			//	.Select(g => g.Key);

			//foreach (var category in categoriesMoreThan3Products)
			//{
			//	Console.WriteLine(category);
			//}


			#endregion

			#region Q9

			//var customerList = Source.CustomerList;

			//var groupcustomers = from c in customerList
			//						group c by c.Country into g
			//						select new
			//						{
			//							Country = g.Key,
			//							Count = g.Count(),
			//							TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
			//						};

			//	foreach (var g in groupcustomers)
			//	{
			//		Console.WriteLine($"Country: {g.Country,-15} | Customers: {g.Count,-5} | Total Revenue: {g.TotalOrderValue:C}");
			//	}


			#endregion

			#region Q10

			//var totalUnitsInStock = productList.Sum(p => p.UnitsInStock);

			//Console.WriteLine(  $"total number in stock: {totalUnitsInStock:F2}" );

			#endregion

			#region Q11

			//var mostExpensiveProduct = productList
			//	.OrderByDescending(p => p.UnitPrice)
			//	.Select(p => new { p.ProductName, p.UnitPrice })
			//	.FirstOrDefault();

			//var cheapestProduct = productList
			//	.OrderBy(p => p.UnitPrice)
			//	.Select(p => new { p.ProductName, p.UnitPrice })
			//	.FirstOrDefault();

			//Console.WriteLine($"Most expensive product: {mostExpensiveProduct.ProductName} - Price: {mostExpensiveProduct.UnitPrice:C}");
			//Console.WriteLine("\n=================================================");

			//Console.WriteLine($"Cheapest product: {cheapestProduct.ProductName} - Price: {cheapestProduct.UnitPrice:C}");

			#endregion

			#region Q12


			//var distinctCategories = productList
			//	.Select(p => p.Category)
			//	.Distinct();

			//foreach (var category in distinctCategories)
			//{
			//	Console.WriteLine(category);
			//}

			#endregion

			#region Q13
			//find product IDs that are in setA but NOT in setB
			int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
			int[] setB = { 3, 6, 9, 12, 15, 13 };

			var difference = setA.Except(setB);
			foreach (var id in difference)
			{
				Console.WriteLine($"Product IDs in setA but not in setB: {id}   ");

			}


			#endregion



		}
	}
}
