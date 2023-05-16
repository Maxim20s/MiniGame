using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            labelCharacterClass.Visible = false;
            panelMagClass.Visible = false;
            panelPaladinClass.Visible = false;
            buttonSkill1.Visible = true;
            buttonSkill2.Visible = true;
            buttonSkill3.Visible = true;
            buttonSkill4.Visible = true;
            buttonSkill5.Visible = true;
            buttonHeal.Visible = true;
            labelMoney.Visible = true;
            labelXP.Visible = true;
            labelDamage.Visible = true;
            labelClassName.Visible = true;
            labelXpMob.Visible = true;
            labelMoneyMob.Visible = true;
            pictureBoxMob.Visible = true;
        }

        private void CharactersGame()
        {
            labelClassName.Text = "Class:" + Logic.Player.NameClass;
            labelMoney.Text = "Money: " + Logic.Player.Money;
            labelXP.Text = "XP: " + Logic.Player.Xp;
            labelDamage.Text = "Damage: " + Logic.Player.Damage;
            labelXpMob.Text = "XP: " + Mobs.Xp;
            labelMoneyMob.Text = "Money: " + Mobs.Money;
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            NewGame.Visible = false;
            Exit.Visible = false;
            labelCharacterClass.Visible = true;
            panelMagClass.Visible = true;
            panelPaladinClass.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMagClass_Click(object sender, EventArgs e)
        {
            StartGame();
            Mobs.MobMoneyGeneration();
            Logic.ClassSelection(1);
            CharactersGame();
        }

        private void buttonPaladinClass_Click(object sender, EventArgs e)
        {
            StartGame();
            Mobs.MobMoneyGeneration();
            Logic.ClassSelection(2);
            CharactersGame();

        }

        private void buttonSkill1_Click(object sender, EventArgs e)
        {
            Logic.Skill1();
            Logic.MobGeneration();
            Logic.Deadplayer();
            if (Logic.Player.Xp <= 0) Close();
            CharactersGame();
        }

        private void buttonSkill2_Click(object sender, EventArgs e)
        {
            CharactersGame();
        }

        private void buttonSkill3_Click(object sender, EventArgs e)
        {
            CharactersGame();
        }

        private void buttonSkill4_Click(object sender, EventArgs e)
        {
            CharactersGame();
        }

        private void buttonSkill5_Click(object sender, EventArgs e)
        {
            CharactersGame();
        }

        private void buttonHeal_Click(object sender, EventArgs e)
        {
            Logic.HealXp();
            CharactersGame();
        }
    }
}
