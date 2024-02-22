using System;
using System.Collections.Generic;

// Базовий клас Тварина
class Animal
{
    protected string name;
    protected int age;

    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Тварина: {name}, Вік: {age}");
    }
}

// Похідний клас від Тварина: Птах
class Bird : Animal
{
    protected string species;

    public Bird(string name, int age, string species) : base(name, age)
    {
        this.species = species;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Вид птаха: {species}");
    }
}

// Похідний клас від Тварина: Савець
class Mammal : Animal
{
    protected string habitat;

    public Mammal(string name, int age, string habitat) : base(name, age)
    {
        this.habitat = habitat;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Середовище існування: {habitat}");
    }
}

// Похідний клас від Савець: Парнокопитне
class MammalEvenToed : Mammal
{
    protected bool hasHorns;

    public MammalEvenToed(string name, int age, string habitat, bool hasHorns) : base(name, age, habitat)
    {
        this.hasHorns = hasHorns;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Наявність рогів: {(hasHorns ? "Так" : "Ні")}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>(); // Чек-лист

        // Наповнення масиву різними об’єктами похідних класів
        animals.Add(new Bird("Синиця", 2, "Горобцеві"));
        animals.Add(new Mammal("Лев", 5, "Саванна"));
        animals.Add(new Bird("Сова", 3, "Совові"));
        animals.Add(new MammalEvenToed("Олень", 4, "Ліси", true));

        // Виведення масиву впорядкованого за алфавітом назв тварин
        animals.Sort((x, y) => String.Compare(x.GetType().Name, y.GetType().Name));
        foreach (var animal in animals)
        {
            animal.Show();
            Console.WriteLine();
        }
    }
}
