using LINQ.DataSources;
using LINQ.Models;

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
	

			var productsLessThan25 = productList
				.OrderBy(p => p.UnitPrice)
				.TakeWhile(p => p.UnitPrice < 25);

			foreach (var item in productsLessThan25)
			{
				Console.WriteLine(item);
			}


			#endregion



		}
	}
}
