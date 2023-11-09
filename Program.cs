using System;

class Program
{
    static void Main(string[] args)
    {
        Avto avto = new Avto();

        Console.WriteLine("Введите номер авто:");
        string nomer = Console.ReadLine();

        Console.WriteLine("Введите количество бензина в баке:");
        int bak = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите расход топлива на 100 км:");
        float rashod = float.Parse(Console.ReadLine());

        avto.info(nomer, bak, rashod);

        Console.WriteLine("Автомобиль создан и готов к использованию!");

        Console.WriteLine("Введите объем бензина для заправки:");
        float topUp = float.Parse(Console.ReadLine());
        avto.zapravka(topUp);

        Random rnd = new Random();

        while (true)
        {
            int distance = rnd.Next(1, 100);
            avto.move(distance);

            Console.WriteLine("Хотите продолжить поездку? (да/нет)");
            string answer = Console.ReadLine();

            if (answer.ToLower() != "да")
                break;
        }

        avto.outAvto();

        Console.ReadLine();
    }
}