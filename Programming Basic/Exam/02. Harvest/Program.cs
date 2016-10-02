using System;

    class Program
    {
        static void Main()
        {
        int lozeKvadratniMetra = int.Parse(Console.ReadLine());
        double grozeKvadratenMetyr= double.Parse(Console.ReadLine());
        int vino = int.Parse(Console.ReadLine());
        int hora = int.Parse(Console.ReadLine());

        double zemqLoze = lozeKvadratniMetra * grozeKvadratenMetyr;
        double dobivVino = ((zemqLoze * (40/100) )/ 2.5);
        if (dobivVino > vino)
        {
            double ostatakVino = Math.Ceiling(dobivVino - vino);
            int vinoNaChovek = (int) Math.Ceiling(ostatakVino / hora);
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(dobivVino));
            Console.WriteLine("{0} liters left -> {1} liters per person.", (int)ostatakVino,vinoNaChovek);
        }
        else
        {
            double sumNedostik = Math.Floor (vino - dobivVino);
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",sumNedostik);
        }

    }
}

