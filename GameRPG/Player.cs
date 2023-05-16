using System;
using System.Reflection.Emit;

namespace GameRPG
{
    internal class Player
    {
        private string nameClass;
        private int health;
        private int xp;
        private int damage;
        private int upgradeHeal;
        private int upgradeDamage;
        private Balance balance;

        
        public string NameClass => nameClass;
        public int Health => health;
        public int Xp { get => xp; set => xp = value; }
        public int Damage => damage;
        public int Money { get => balance.Money; set => balance.Money =value; }

        public Player(ClassPlayer classPlayer)
        {
            nameClass = classPlayer.GetType().Name;
            xp = health = classPlayer.HealthClass;
            damage = classPlayer.DamageClass;
            upgradeHeal = classPlayer.UpgradeHeallClass;
            upgradeDamage = classPlayer.UpgradeDamageClass;
            balance = new Balance();
        }


        
    }
}
