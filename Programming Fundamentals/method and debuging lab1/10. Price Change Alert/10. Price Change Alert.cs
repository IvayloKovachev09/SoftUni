using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double granica = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n-1 ; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double div = Proc(lastPrice, currentPrice);
            bool isSignificantDifference = HaveDifferent(div, granica);
            string message = GetPrice(currentPrice, lastPrice, div, isSignificantDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string GetPrice(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
            {
                string to = "";
                if (difference == 0)
                {
                    to = string.Format("NO CHANGE: {0}", currentPrice);
                }
                else if (!etherTrueOrFalse)
                {
                    to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
                }
                else if (etherTrueOrFalse && (difference > 0))
                {
                    to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
                }
                else if (etherTrueOrFalse && (difference < 0))
                    to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
                return to;
            }
    private static bool HaveDifferent(double granica, double isDiff)
            {
                if (Math.Abs(granica) >= isDiff)
                {
                    return true;
                }
                return false;
            }

    private static double Proc(double lastPrice, double currentPrice)
            {
                double r = (currentPrice - lastPrice) * lastPrice;
                return r;
            }
}


