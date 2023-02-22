class Hello
{
    static void Main(string[] args)
    {
        Lesson2_Task4_Way2();

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
