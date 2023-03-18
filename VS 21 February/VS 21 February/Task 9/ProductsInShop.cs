using System;
using System.Diagnostics;

namespace VS_21_February.Task9
{
	public class ProductsInShop : Product
	{
		public ProductsInShop(string productName, double price, DateTime productionDate, int expirationNumberDays) : base (productName, price, productionDate, expirationNumberDays)
		{
		}

		public override string GetInfo()
		{
			return $"Product name: {ProductName}. Price: {Price}. Production Date: {ProductionDate}. Expiration Date: {ExpirationNumberDays}";
		}
	}
}

