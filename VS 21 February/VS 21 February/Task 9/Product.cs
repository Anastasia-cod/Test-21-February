using System;
namespace VS_21_February.Task9
{
	public abstract class Product : ICheckPrice, IComparable<Product>
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

		protected Product(string productName)
		{
			ProductName = productName;
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

		/// <summary>
		/// Check if the price more than 300, return true or false
		/// </summary>
		/// <returns></returns>
		public string ICheckPriceMore300()
		{
			if (Price > 300)
			{
				return "true";
			}

			return "false";
		}

		/// <summary>
		/// Compare to Price
		/// </summary>
		/// <param name="other"></param>
		/// <returns></returns>
		int IComparable<Product>.CompareTo(Product? other)
		{
			if (other.Price > this.Price)
				return -1;
			else if (other.Price == this.Price)
				return 0;
			else
				return 1;
		}

		public override string ToString()
		{
			return string.Format($"Product Name: {ProductName}");
		}
	}
}

