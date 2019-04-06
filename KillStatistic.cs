using System;

namespace Practice_22_01
{
    public class KillStatistic
    {
        public int Kills { get; set; }
        public int People { get; set; }

        public void Print()
        {
            Console.WriteLine($"1 убийство на {(double)People / Kills} человек");
        }

        public static bool operator !=(KillStatistic statistic1, KillStatistic statistic2)
        {
            double quatity1 = statistic1.People / statistic1.Kills;
            double quatity2 = statistic2.People / statistic2.Kills;
            if (quatity1 != quatity2) return true;
            return false;
        }

        public static bool operator==(KillStatistic statistic1, KillStatistic statistic2)
        {
            return statistic1 != statistic2;
        }
    }
}
