using System;

namespace GameRPG
{
    static class Mobs
    {
        static Random random = new Random();

        static int xp = 0;
        static int money = 0;

        static public int Xp { get => xp; set => xp = value; }
        static public int Money { get => money; set => money = value; }

        private static void XpMob () 
        {
            Xp = random.Next(200);
        }
        private static void MoneyMob()
        {
            if (Xp <= 30) Money = random.Next(20);
            else if (Xp <= 60 && Xp >= 30) Money = random.Next(40);
            else if (Xp <= 90 && Xp >= 60) Money = random.Next(60);
            else if (Xp <= 120 && Xp >= 90) Money = random.Next(80);
            else if (Xp <= 200 && Xp >= 120) Money = random.Next(100);
        }
        public static void MobMoneyGeneration()
        {
            XpMob();
            MoneyMob();
        }
    }
}
