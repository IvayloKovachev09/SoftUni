using System;


public class Program
{
    public static void Main()
    {
        int picture = int.Parse(Console.ReadLine());
        int filterTime = int.Parse(Console.ReadLine());
        int filterOfPicturesPercent = int.Parse(Console.ReadLine());
        int uploudInTime = int.Parse(Console.ReadLine());

        long filterPicturesPerSecondsTotal = (long)picture * filterTime;
        long filterOfPicture = (long)Math.Ceiling((double)picture * filterOfPicturesPercent / 100);
        long totalFilterPicturePerSeconds = filterOfPicture * uploudInTime;
        long allTime = totalFilterPicturePerSeconds + filterPicturesPerSecondsTotal;


        TimeSpan timeSpan = TimeSpan.FromSeconds(allTime);
        Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",timeSpan.Days,timeSpan.Hours,timeSpan.Minutes,timeSpan.Seconds);
        
    }
}

