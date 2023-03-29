using System;
namespace VS_21_February.Task11
{
    public class MonitoringAveragePrice
    {
        public Random randomPrice = new Random();
        public Action<int> showPrice;

        public MonitoringAveragePrice(Action<int> showPrice)
        {
            this.showPrice = showPrice;
        }

        public void MonitorPrice(double minPrice, double maxPrice)
        {
            double price = randomPrice.NextDouble() * (maxPrice - minPrice);

            showPrice((int)Math.Round(price));
        }
    }
}

