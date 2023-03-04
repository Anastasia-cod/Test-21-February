using System;

class Hello
{
    static void Main(string[] args)
    {
        //First Home Task
        VS_21_February.Phone iphone_13 = new VS_21_February.Phone();

        iphone_13.number = "13";
        iphone_13.model = "Iphone";
        iphone_13.weight = 0.173;

        VS_21_February.Phone samsung_Galaxy = new VS_21_February.Phone();

        samsung_Galaxy.number = "S 23";
        samsung_Galaxy.model = "Samsung Galaxy S Ultra";
        samsung_Galaxy.weight = 0.234;

        VS_21_February.Phone huawei = new VS_21_February.Phone();

        huawei.number = "P50";
        huawei.model = "Huawei Pro";
        huawei.weight = 0.195;

        Console.WriteLine($"Phone 1: number {iphone_13.number}, model {iphone_13.model}, weight {iphone_13.weight}");
        Console.WriteLine($"Phone 2: number {samsung_Galaxy.number}, model {samsung_Galaxy.model}, weight {samsung_Galaxy.weight}");
        Console.WriteLine($"Phone 3: number {huawei.number}, model {huawei.model}, weight {huawei.weight}");

        //Method ReceiveCall
        iphone_13.ReceiveCall("Masha");

        samsung_Galaxy.ReceiveCall("Michael");

        huawei.ReceiveCall("Elizaveta");

        //Method GetNumber
        iphone_13.phoneNumber = 80441371010;
        iphone_13.GetNumber();

        Console.WriteLine(iphone_13.phoneNumber);

        samsung_Galaxy.phoneNumber = 80293386767;
        samsung_Galaxy.GetNumber();

        Console.WriteLine(samsung_Galaxy.phoneNumber);

        huawei.phoneNumber = 80449480999;
        huawei.GetNumber();

        Console.WriteLine(huawei.phoneNumber);

        //Constructor with 2 parametres
        VS_21_February.Phone lenovo = new("K14", "Lenovo");

        Console.WriteLine($"Phone 4: number {lenovo.number}, model {lenovo.model}, weight {lenovo.weight}");

        //overloaded method ReceiveCall
        iphone_13.ReceiveCall("Nastya", 80447222525);

        //Method SendMessage
        samsung_Galaxy.SendMessage(80293334567, 80447568990, 80445682130, 80297775507);

        huawei.SendMessage();

        //Second Home Task
        VS_21_February.CreditCard card_1 = new VS_21_February.CreditCard();

        card_1.accountNumber = "BY11ALFA100110DA7U9910101000";
        card_1.currentSumm = 51000.5;

        VS_21_February.CreditCard card_2 = new VS_21_February.CreditCard();

        card_2.accountNumber = "BY24ALFA200160PP7U0670101001";
        card_2.currentSumm = 145000.9;

        VS_21_February.CreditCard card_3 = new VS_21_February.CreditCard();

        card_3.accountNumber = "BY97ALFA110960SE7K0990401003";
        card_3.currentSumm = 28000.3;

        card_1.AccrualMoney(8000.5);

        card_2.AccrualMoney(14700);

        card_3.WithdrawalMoney(30000);

        card_1.CurrentStatus();

        card_2.CurrentStatus();

        card_3.CurrentStatus();

        //Third Home Task partially performed
        VS_21_February.CashMachine atm_1 = new(1, 1, 1);

        atm_1.DepositingMoney(1, 1, 1);

        atm_1.WithdrawalMoney(340);
    }

    public static void Lesson1_Task1()
    {
        char name = char.Parse(Console.ReadLine());
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, " + name);
    }

    public static void Lesson2_Task1()
    {
        int operand1 = 25;
        int operand2 = 5;
        string sign = Console.ReadLine();
        int result;

        switch(sign)
        {
            case "+":
                result = operand1 + operand2;
                Console.WriteLine($"addition operation: {operand1} {sign} {operand2} = {result}");
                break;
            case "-":
                result = operand1 - operand2;
                Console.WriteLine($"subtraction operation: {operand1} {sign} {operand2} = {result}");
                break;
            case "*":
                result = operand1 * operand2;
                Console.WriteLine($"multiplication operation: {operand1} {sign} {operand2} = {result}");
                break;
            case "/":
                if ((operand2 != 0))
                {
                    result = operand1 / operand2;
                    Console.WriteLine($"division operation: {operand1} {sign} {operand2} = {result}");
                }
                else
                {
                    Console.WriteLine($"Error! Dividing by Zero impossible");
                }   
                break;
            default:
                Console.WriteLine($"The calculator can only perform operations of addition, subtraction, division, multiplication.\nPlease enter a sign only for available operations.");
                break;
        } 
    }

    public static void Lesson2_Task2()
    {
        int number = int.Parse(Console.ReadLine());

        if ((number >= 0) && (number <= 14))
        {
            Console.WriteLine($"The entered number is between 0 and 14");
        }
        else if ((number >= 15) && (number <= 35))
        {
            Console.WriteLine($"The entered number is between 15 and 35");
        }
        else if ((number >= 36) && (number <= 50))
        {
            Console.WriteLine($"The entered number is between 36 and 50");
        }
        else if ((number >= 51) && (number <= 100))
        {
            Console.WriteLine($"The entered number is between 51 and 100");
        }
        else
        {
            Console.WriteLine($"The entered number is not included in any of the existing ranges. Please enter integer number from 0 to 100");
        }
    }

    public static void Lesson2_Task3()
    {
        string badWeather_1 = "cold";
        string badWeather_2 = "freezing";
        string badWeather_3 = "humid";
        string badWeather_4 = "rainy";
        string badWeather_5 = "unsettled";
        string goodWeather_1 = "sunny";
        string goodWeather_2 = "cloudless";
        string goodWeather_3 = "warm";
        string goodWeather_4 = "chilly";
        string goodWeather_5 = "thaw";
        string weather = Console.ReadLine();

        if ((weather == "холодно") || (weather == "холодная"))
        {
            Console.WriteLine($"Translate to English: {badWeather_1}");
        }
        else if ((weather == "очень холодно") || (weather == "очень холодная"))
        {
            Console.WriteLine($"Translate to English: {badWeather_2}");
        }
        else if ((weather == "влажно") || (weather == "влажная"))
        {
            Console.WriteLine($"Translate to English: {badWeather_3}");
        }
        else if ((weather == "дождливо") || (weather == "дождливая"))
        {
            Console.WriteLine($"Translate to English: {badWeather_4}");
        }
        else if ((weather == "неустойчивая") || (weather == "переменчивая"))
        {
            Console.WriteLine($"Translate to English: {badWeather_5}");
        }
        else if ((weather == "солнечно") || (weather == "солнечная"))
        {
            Console.WriteLine($"Translate to English: {goodWeather_1}");
        }
        else if ((weather == "безоблачно") || (weather == "безоблачная"))
        {
            Console.WriteLine($"Translate to English: {goodWeather_2}");
        }
        else if ((weather == "тепло") || (weather == "теплая"))
        {
            Console.WriteLine($"Translate to English: {goodWeather_3}");
        }
        else if ((weather == "прохладно") || (weather == "прохладная"))
        {
            Console.WriteLine($"Translate to English: {goodWeather_4}");
        }
        else if ((weather == "оттепель") || (weather == "потепление"))
        {
            Console.WriteLine($"Translate to English: {goodWeather_5}");
        }
        else
        {
            Console.WriteLine($"There is no translation for this word");
        }
    }

    public static void Lesson2_Task4_Way1()
    {
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"The entered number is even");
        }
        else
        {
            Console.WriteLine($"The entered number is odd");
        }
    }

    public static void Lesson2_Task4_Way2()
    {
        int number = int.Parse(Console.ReadLine());

        switch (number % 2)
        {
            case 0:
                Console.WriteLine($"The entered number is even");
                break;
            default:
                Console.WriteLine($"The entered number is odd");
                break;
        }
    }
}
