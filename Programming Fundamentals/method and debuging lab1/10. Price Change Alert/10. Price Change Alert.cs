using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double priceTreshHold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());
        double lastPrice = firstPrice;

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = GetPercemtageDifference(lastPrice, currentPrice);
            bool isSignificantDifference = IsHaveDifferent(difference, priceTreshHold);
            string message = GetPrice(currentPrice, lastPrice, difference, isSignificantDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string GetPrice(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
    {
        string result = "";
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        return result;
    }
    private static bool IsHaveDifferent(double difference, double priceTreshHold)
    {
        if (Math.Abs(difference/100) >= priceTreshHold)
        {
            return true;
        }
        return false;
    }

    private static double GetPercemtageDifference(double lastPrice, double currentPrice)
    {
        double result = ((currentPrice - lastPrice) / lastPrice)*100;
        return result;
    }
}


