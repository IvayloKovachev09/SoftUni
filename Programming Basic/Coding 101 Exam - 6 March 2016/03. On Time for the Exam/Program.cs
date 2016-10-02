using System;

    class Program
    {
    static void Main()
    {
        int hourExam = int.Parse(Console.ReadLine());
        int minutesExam = int.Parse(Console.ReadLine());
        int hourArrive = int.Parse(Console.ReadLine());
        int minutesArrive = int.Parse(Console.ReadLine());

        int sumMinutesExam = hourExam * 60 + minutesExam;
        int sumMinutesArrive = hourArrive * 60 + minutesArrive;
        int different = sumMinutesArrive - sumMinutesExam;
        int chas = Math.Abs(different/60);
        int minuti = Math.Abs(different % 60);

        if (different > 0)
        {

            Console.WriteLine("Late");
        }
        else if (different<-30)
        {

            Console.WriteLine("Early");
        }
        else if (different<=0 && different>=-30)
        {
            Console.WriteLine("On Time");
        }
        if (different<60 && different>0)
        {
                
                Console.WriteLine("{0} minutes after the start",different);
        }
       else if (different >= 60 && different<70)
        {
                Console.WriteLine("{0}:0{1} hours after the start", chas, minuti);
        }
       else if(different>=70)
        {
               Console.WriteLine("{0}:{1} hours after the start", chas, minuti);
        }
        else if (different < 0 && different > -60)
        {
            Console.WriteLine("{0} minutes before the start",Math.Abs( different));
        }
        else if (different<=-60 && different>-70)
        {
            Console.WriteLine("{0}:0{1} hours before the start", chas, minuti);
        }
        else if (different<=-70)
        {
            Console.WriteLine("{0}:{1} hours before the start", chas, minuti);
        }
               
     }

 }
