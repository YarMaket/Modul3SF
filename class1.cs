using System;

class Class1
{
    public static void Main(string[] args)
    {

        Console.Writeline("������� ���: ");
        var name = Console.ReadLine();
        Console.Writeline("������� �������: ");
        var age = Convert.ToInt32(Console.ReadLine());
        Console.Writeline("������� ���� ��������: ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("���� ��� {0}, ��� ������� {1} ���, �� �������� {2}", name, age, birthdate);

    }
}