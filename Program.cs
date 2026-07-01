using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите рост (в метрах): ");
        double height = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

        Console.Write("Введите вес (в килограммах): ");
        double weight = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

        //формулу и данные я брал с сайта https://www.vidal.ru/calculators/kardiologiya/indeks-massy-tela?ysclid=mr1yzhik6780082875

        double bmi = weight / (height * height);

        Console.Write("ИМТ = " + Math.Round(bmi, 1) + " - ");

        if (bmi < 18.5)
        {
            Console.WriteLine("Ниже нормального");
        }
        else if (bmi <= 24.9)
        {
            Console.WriteLine("Нормальный");
        }
        else
        {
            Console.WriteLine("Выше нормального");
        }
    }
}