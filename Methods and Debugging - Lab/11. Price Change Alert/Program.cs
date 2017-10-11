using System;
namespace _11.Price_Change_Alert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double granica = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double c = double.Parse(Console.ReadLine());
                double div = Proc(last, c);
                bool isSignificantDifference = isDifference(div, granica);
                string message = Get(c, last, div, isSignificantDifference);
                Console.WriteLine(message);
                //last = c;
            }
        }

        static string Get(double c, double last, double difference, bool etherTrueOrFalse)
        {
            string to = "";
            if (difference == 0)
            {
                to = string.Format("NO CHANGE: {0}", c);
            }
            else if (!etherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, difference);
            }
            else if (etherTrueOrFalse && (difference > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, difference);
            }
            else if (etherTrueOrFalse && (difference < 0))
                to = string.Format($"PRICE DOWN: {0} to {1} ({2*100:F2}%)", last, c, difference);
            return to;
        }

        static bool isDifference(double limit, double isDiff)
        {
            if (Math.Abs(limit) >= isDiff)
            {
                return true;
            }
            return false;
        }

        static double Proc(double l, double c)
        {
            double r = (c - l) / l;
            return r;
        }
    }
}



