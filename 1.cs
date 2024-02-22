using System;

enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    White
}

class Romb
{
    protected int a; // сторона
    protected int d1; // діагональ
    protected Color color; // колір ромба

    // Конструктор
    public Romb(int side, int diagonal, Color c)
    {
        a = side;
        d1 = diagonal;
        color = c;
    }

    // Вивести довжини на екран
    public void PrintDimensions()
    {
        Console.WriteLine($"Сторона ромба: {a}");
        Console.WriteLine($"Діагональ ромба: {d1}");
    }

    // Розрахунок периметра ромба
    public int CalculatePerimeter()
    {
        return 4 * a;
    }

    // Розрахунок площі ромба
    public double CalculateArea()
    {
        return 0.5 * a * d1;
    }

    // Перевірка, чи є ромб квадратом
    public bool IsSquare()
    {
        return a == d1;
    }

    // Властивості
    public int Side
    {
        get { return a; }
        set { a = value; }
    }

    public int Diagonal
    {
        get { return d1; }
        set { d1 = value; }
    }

    public Color Color
    {
        get { return color; }
        set { color = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Romb[] rombs = new Romb[5]; // Заданий масив ромбів

        // Ініціалізація ромбів
        rombs[0] = new Romb(3, 4, Color.Red);
        rombs[1] = new Romb(5, 5, Color.Green);
        rombs[2] = new Romb(4, 6, Color.Blue);
        rombs[3] = new Romb(7, 7, Color.Yellow);
        rombs[4] = new Romb(8, 9, Color.White);

        // Виведення інформації про ромби
        for (int i = 0; i < rombs.Length; i++)
        {
            Console.WriteLine($"Ромб {i + 1}:");
            rombs[i].PrintDimensions();
            Console.WriteLine($"Колір ромба: {rombs[i].Color}");
            Console.WriteLine($"Периметр: {rombs[i].CalculatePerimeter()}");
            Console.WriteLine($"Площа: {rombs[i].CalculateArea()}");
            Console.WriteLine($"Чи є квадратом: {rombs[i].IsSquare()}");
            Console.WriteLine();
        }

        // Підрахунок кількості квадратів
        int squareCount = 0;
        foreach (Romb romb in rombs)
        {
            if (romb.IsSquare())
                squareCount++;
        }

        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}




