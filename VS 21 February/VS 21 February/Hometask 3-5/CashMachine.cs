using System;
namespace VS_21_February
{
	public class CashMachine
	{
        public int countOfDenomination_20;
        public int countOfDenomination_50;
        public int countOfDenomination_100;
        public int allMoney;

        public CashMachine(int countOfDenomination_20, int countOfDenomination_50, int countOfDenomination_100)
        {
            this.countOfDenomination_20 = countOfDenomination_20;
            this.countOfDenomination_50 = countOfDenomination_50;
            this.countOfDenomination_100 = countOfDenomination_100;
        }

        public int DepositingMoney(int add_20, int add_50, int add_100)
        {
            countOfDenomination_20 += add_20;
            countOfDenomination_50 += add_50;
            countOfDenomination_100 += add_100;

            allMoney = countOfDenomination_20 * 20 + countOfDenomination_50 * 50 + countOfDenomination_100 * 100;
            return allMoney;
        }

        //I tried, but didn't succeed, so I'll just leave it at that
        public void WithdrawalMoney(int summOfMoney)
        {
            bool result = allMoney >= summOfMoney;

            if (summOfMoney %10 != 0)
            {
                Console.WriteLine($"Error! Available banknotes at cash mashine are 10, 20, 100. Please enter correct summ of money to withdraw.");
            }
            else
            {
                Console.WriteLine($"{result}");
            }

        }
    }
}

