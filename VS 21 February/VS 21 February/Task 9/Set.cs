using System;
namespace VS_21_February.Task9
{
	public class Set : Product
	{
		public string ProductList { get; set; }

		public Set(string productName, double price, string productList) : base(productName, price)
		{
			ProductList = productList;
		}

		public override string GetInfo()
		{
			return $"Product name: {ProductName}. Price: {Price}. Number of items in a batch: {ProductList}.";
		}

		public override string CheckExpirationDate(DateTime today)
		{
			return "Not suitable for set";
		}
	}
}

