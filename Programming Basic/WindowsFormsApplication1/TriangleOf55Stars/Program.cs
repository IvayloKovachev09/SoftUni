using System;


namespace TriangleOf55Stars
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)                        //проверка на i и добавяне на 1 към резултата, така докато стане 10;
            {
                string stars = new string('*', i);      //заменя "i" със символа звезда "*" ;
                Console.WriteLine(stars);            //отпечатва броя на "*" на нов ред ;
            }
        }
    }
}
