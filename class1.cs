using System;

class Class1
{
    public static void Main(string[] args)
    {

        Console.Writeline("Введите имя: ");
        var name = Console.ReadLine();
        Console.Writeline("Введите возраст: ");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.Writeline("Введите дату рождения: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Ваше имя {0}, Вас возраст {1} лет, Вы родились {2}", name, age, birthdate);

    }
}