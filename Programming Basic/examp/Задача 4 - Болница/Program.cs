using System;

class Program
{
    static void Main()
    {
        int dni = int.Parse(Console.ReadLine());
        int pregledaniPacienti = 0;
        int nepregledaniPacienti = 0;
        int dobavqneLekar = 0;
        for (int i = 1; i <= dni; i++)
        {
            int pacienti = int.Parse(Console.ReadLine());

            if (i % 3 == 0 && pregledaniPacienti < nepregledaniPacienti)
            {
                if (pacienti>8+dobavqneLekar)
                {
                    pregledaniPacienti += (8 + dobavqneLekar);
                    nepregledaniPacienti = (pacienti - (8 + dobavqneLekar)) + nepregledaniPacienti;
                    
                }
                else
                {
                    pregledaniPacienti += pacienti;
                }

                dobavqneLekar += 1;
            }
            else if (dobavqneLekar>0 )
            {
                if (pacienti>7+dobavqneLekar)
                {
                    pregledaniPacienti += (7 + dobavqneLekar);
                    nepregledaniPacienti = (pacienti - (7 + dobavqneLekar)) + nepregledaniPacienti;
                }
                else
                {
                    pregledaniPacienti += pacienti;
                }
                
            }
            else
            {
                if (pacienti >= 7)
                {
                    pregledaniPacienti += 7;
                    nepregledaniPacienti = (pacienti - 7) + nepregledaniPacienti;
                }
                else
                {
                    pregledaniPacienti += pacienti;
                }
            }
           
            
        }
        Console.WriteLine("Treated patients: {0}.", pregledaniPacienti);
        Console.WriteLine("Untreated patients: {0}.", nepregledaniPacienti);
    }
}

