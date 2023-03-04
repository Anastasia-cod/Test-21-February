using System;
namespace VS_21_February
{
	public class CreditCard
	{
		public string accountNumber;
		public double currentSumm;

		public CreditCard()
		{

		}

		public double AccrualMoney(double summOfMoney)
		{
			currentSumm += summOfMoney;
			return currentSumm;
		}

		public double WithdrawalMoney(double summOfMoney)
		{
            if (summOfMoney > currentSumm)
			{
                Console.WriteLine($"Error! Not enough money. Available summ of money on the card is {currentSumm}");
            }
            else
			{
                currentSumm -= summOfMoney;
            }

            return currentSumm;
        }

		public void CurrentStatus ()
		{
			Console.WriteLine($"The current summ is {currentSumm}");
		}

    }
}

