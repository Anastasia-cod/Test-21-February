using System;
namespace VS_21_February.Task9
{
	public class Batch : Product
	{
		public int Quantity { get; set; }

		public Batch(string productName, double price, int quantity, DateTime productionDate, int expirationNumberDays) : base(productName, price, productionDate, expirationNumberDays)
		{
			Quantity = quantity;
		}

		public override string GetInfo()
		{
			return $"Product name: {ProductName}. Price: {Price}. Number of items in a batch: {Quantity}. Production Date: {ProductionDate}. Expiration number (Days): {ExpirationNumberDays}";
		}
	}
}

