class Hello
{
    static void Main(string[] args)
    {
        Lesson2_Task2();

    }


    public static void Lesson1_Task1()
    {
        string name = Console.ReadLine();
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, " + name);
    }

    

   
    public static void Lesson2_Task2()
    {
        int number = int.Parse(Console.ReadLine());
        if((number>=0) && (number <= 14))
        {
            Console.WriteLine($"The entered number is between 0 and 14");
        }
        else if((number >= 15) && (number <= 35))
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

}
