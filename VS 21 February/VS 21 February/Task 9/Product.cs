using System;
namespace VS_21_February.Task9
{
	public abstract class Product
	{
		public string ProductName { get; set; }
		public double Price { get; set; }
		public DateTime ProductionDate { get; set; }
		public int ExpirationNumberDays { get; set; }

		public Product(string productName, double price, DateTime productionDate, int expirationNumberDays)
		{
			ProductName = productName;
			Price = price;
			ProductionDate = productionDate;
			ExpirationNumberDays = expirationNumberDays;
		}

		protected Product(string productName, double price)
		{
			ProductName = productName;
			Price = price;
		}

		/// <summary>
		/// Display product information
		/// </summary>
		/// <returns></returns>
		public virtual string GetInfo()
		{
			return $"Product name: {ProductName}. Price: {Price}.";
		}

		/// <summary>
		/// Check product Expiration Date
		/// </summary>
		/// <param name="today"></param>
		/// <returns></returns>
		public virtual string CheckExpirationDate(DateTime today)
		{
			if(today > ProductionDate.AddDays(Convert.ToDouble(ExpirationNumberDays)))
			{
				return "\nExpired! Expired from date: "+ ProductionDate.AddDays(Convert.ToDouble(ExpirationNumberDays));
			}

			return "The product is ok. The expiration date is coming: " + ProductionDate.AddDays(Convert.ToDouble(ExpirationNumberDays));
		}
	}
}

