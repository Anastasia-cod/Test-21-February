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

        public void GetAvarageMonitorPriceFor2RoomFlat()
        {
            int price = (randomPrice.Next(46000, 125000) + randomPrice.Next(25000, 45000)/ 2);
            showPrice(price);
        }
    }
}

