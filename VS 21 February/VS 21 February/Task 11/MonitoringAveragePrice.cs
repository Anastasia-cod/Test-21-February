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

        public void GetAvarageMonitorPrice()
        {
            int price = (randomPrice.Next(70000, 150000) + randomPrice.Next(25000, 50000)/ 2);
            showPrice(price);
        }
    }
}

