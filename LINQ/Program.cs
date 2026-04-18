using LINQ.DataSources;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var products = Source.ProductList;
			#region Q1

			//var MostExpensiveProducts = products
			//	.OrderByDescending(p => p.UnitPrice)
			//	.Take(3);
			//foreach (var product in MostExpensiveProducts)
			//{
			//	Console.WriteLine(product);
			//}


			#endregion
		}
	}
}
