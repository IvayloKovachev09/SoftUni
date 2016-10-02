using System;

class Program
{
    static void Main()
    {
        double priceToVegetables = double.Parse(Console.ReadLine());
        double priceToFruit = double.Parse(Console.ReadLine());
        int kgVegetables = int.Parse(Console.ReadLine());
        int kgFruit = int.Parse(Console.ReadLine());

        double Vegetables = priceToVegetables * kgVegetables;
        double Fruit = priceToFruit * kgFruit;
        double sum = (Vegetables + Fruit) / 1.94;

        Console.WriteLine(sum);
    }
}

