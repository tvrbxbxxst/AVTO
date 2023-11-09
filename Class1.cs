using System;

class Avto
{
    private string nomerAvto;
    private int bakBenzina;
    private float rashodTopliva;
    private int probeg;

    public void info(string nom, int bak, float ras)
    {
        nomerAvto = nom;
        bakBenzina = bak;
        rashodTopliva = ras;
    }

    public void outAvto()
    {
        Console.WriteLine("Номер авто: " + nomerAvto);
        Console.WriteLine("Количество бензина в баке: " + bakBenzina);
        Console.WriteLine("Расход топлива на 100 км: " + rashodTopliva);
        Console.WriteLine("Общий пробег: " + probeg);
    }

    public void zapravka(float top)
    {
        bakBenzina += (int)top;
    }

    public void move(int km)
    {
        int rashod = (int)(rashodTopliva * km / 100);

        if (rashod <= bakBenzina)
        {
            Console.WriteLine("Можем проехать " + km + " км.");
            probeg += km;
            bakBenzina -= rashod;
        }
        else
        {
            Console.WriteLine("Недостаточно топлива для поездки!");
            Console.WriteLine("Хотите заправиться? (да/нет)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "да")
            {
                Console.WriteLine("Введите количество топлива для заправки:");
                float top = float.Parse(Console.ReadLine());
                zapravka(top);
                move(km);
            }
        }
    }

    private int ostatok()
    {
        return bakBenzina;
    }

    private float raschetRasstoyaniya(int x1, int y1, int x2, int y2)
    {
        return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    public float raschetObshchegoProbega(int x1, int y1, int x2, int y2)
    {
        float dist = raschetRasstoyaniya(x1, y1, x2, y2);
        probeg += (int)dist;
        return dist;
    }
}