using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace GameRPG
{
    static class Logic
    {
        private static Player player;

        public static Player Player { get => player; set => player = value; }

        public static ClassPlayer ClassPlayerCheck(int indexclass)
        {
            if (indexclass == 1)
            {
                Mag mag = new Mag();
                return mag;
            }
            else if (indexclass == 2)
            {
                Paladin paladin = new Paladin();
                return paladin;
            }
            else return null;
        }

        public static void ClassSelection(int index)
        {
            Player = new Player(ClassPlayerCheck(index));
        }

        public static void Skill1()
        {
            Random random = new Random();
            try { player.Xp -= random.Next(player.Xp - 2) + 1; }
            catch { player.Xp = 0; }
        }

        public static void HealXp()
        {
            if (player.Xp <= player.Health - 3) player.Xp += 4;
            else player.Xp = player.Health;
        }

        public static void Deadplayer()
        {
            if (player.Xp <= 0)
            {
                MessageBox.Show("Game over");
            }
        }

        public static void MobGeneration()
        {
            if (Mobs.Xp >= 0)
            {
                Mobs.Xp -= player.Damage;
                return;
            }
            else
            {
                player.Money += Mobs.Money;
                Mobs.MobMoneyGeneration();
            }
        }

    }
}
