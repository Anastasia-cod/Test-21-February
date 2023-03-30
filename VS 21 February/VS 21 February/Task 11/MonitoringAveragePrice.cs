using System;
namespace VS_21_February.Task11
{
    public class MonitoringAveragePrice
    {
        public event EventHandler PriceDecreased;
        private PriceDelegate priceDelegate;

        private int minPrice = 45000;
        private int maxPrice = 125000;
        private int currentPrice;

        public MonitoringAveragePrice(PriceDelegate priceDelegate)
        {
            this.priceDelegate = priceDelegate;
            Random random = new Random();
            currentPrice = random.Next(minPrice, maxPrice);
        }

        public void UpdatePrice()
        {
            Random random = new Random();
            int priceChange = random.Next(-10000, 10000);

            currentPrice += priceChange;

            priceDelegate(currentPrice);

            if (currentPrice < 66000)
            {
                AddEventPriceDecreased();
            }
        }

        protected virtual void AddEventPriceDecreased()
        {
            PriceDecreased?.Invoke(this, EventArgs.Empty);
        }
    }
}

