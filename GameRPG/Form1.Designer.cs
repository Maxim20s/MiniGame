namespace GameRPG
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NewGame = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.labelCharacterClass = new System.Windows.Forms.Label();
            this.labelMagClass = new System.Windows.Forms.Label();
            this.panelMagClass = new System.Windows.Forms.Panel();
            this.buttonMagClass = new System.Windows.Forms.Button();
            this.labelMagCharacters = new System.Windows.Forms.Label();
            this.panelPaladinClass = new System.Windows.Forms.Panel();
            this.buttonPaladinClass = new System.Windows.Forms.Button();
            this.labelPaladinCharacters = new System.Windows.Forms.Label();
            this.labelPaladinClass = new System.Windows.Forms.Label();
            this.buttonSkill1 = new System.Windows.Forms.Button();
            this.buttonSkill2 = new System.Windows.Forms.Button();
            this.buttonSkill3 = new System.Windows.Forms.Button();
            this.buttonSkill4 = new System.Windows.Forms.Button();
            this.buttonSkill5 = new System.Windows.Forms.Button();
            this.buttonHeal = new System.Windows.Forms.Button();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelXP = new System.Windows.Forms.Label();
            this.labelDamage = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            this.pictureBoxMob = new System.Windows.Forms.PictureBox();
            this.labelXpMob = new System.Windows.Forms.Label();
            this.labelMoneyMob = new System.Windows.Forms.Label();
            this.panelMagClass.SuspendLayout();
            this.panelPaladinClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMob)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.AutoSize = true;
            this.NewGame.BackColor = System.Drawing.Color.Transparent;
            this.NewGame.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewGame.Location = new System.Drawing.Point(479, 156);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(297, 73);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New game";
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(557, 229);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 73);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // labelCharacterClass
            // 
            this.labelCharacterClass.AutoSize = true;
            this.labelCharacterClass.BackColor = System.Drawing.Color.Transparent;
            this.labelCharacterClass.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCharacterClass.Location = new System.Drawing.Point(402, 9);
            this.labelCharacterClass.Name = "labelCharacterClass";
            this.labelCharacterClass.Size = new System.Drawing.Size(455, 53);
            this.labelCharacterClass.TabIndex = 2;
            this.labelCharacterClass.Text = "Choose a character class";
            this.labelCharacterClass.Visible = false;
            // 
            // labelMagClass
            // 
            this.labelMagClass.AutoSize = true;
            this.labelMagClass.BackColor = System.Drawing.Color.Transparent;
            this.labelMagClass.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMagClass.Location = new System.Drawing.Point(14, 15);
            this.labelMagClass.Name = "labelMagClass";
            this.labelMagClass.Size = new System.Drawing.Size(66, 35);
            this.labelMagClass.TabIndex = 3;
            this.labelMagClass.Text = "Mag";
            // 
            // panelMagClass
            // 
            this.panelMagClass.BackColor = System.Drawing.Color.Transparent;
            this.panelMagClass.Controls.Add(this.buttonMagClass);
            this.panelMagClass.Controls.Add(this.labelMagCharacters);
            this.panelMagClass.Controls.Add(this.labelMagClass);
            this.panelMagClass.Location = new System.Drawing.Point(36, 71);
            this.panelMagClass.Name = "panelMagClass";
            this.panelMagClass.Size = new System.Drawing.Size(350, 200);
            this.panelMagClass.TabIndex = 4;
            this.panelMagClass.Visible = false;
            // 
            // buttonMagClass
            // 
            this.buttonMagClass.BackColor = System.Drawing.Color.Indigo;
            this.buttonMagClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMagClass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMagClass.Location = new System.Drawing.Point(20, 157);
            this.buttonMagClass.Name = "buttonMagClass";
            this.buttonMagClass.Size = new System.Drawing.Size(95, 40);
            this.buttonMagClass.TabIndex = 5;
            this.buttonMagClass.Text = "Apply";
            this.buttonMagClass.UseVisualStyleBackColor = false;
            this.buttonMagClass.Click += new System.EventHandler(this.buttonMagClass_Click);
            // 
            // labelMagCharacters
            // 
            this.labelMagCharacters.AutoSize = true;
            this.labelMagCharacters.BackColor = System.Drawing.Color.Transparent;
            this.labelMagCharacters.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMagCharacters.Location = new System.Drawing.Point(17, 53);
            this.labelMagCharacters.Name = "labelMagCharacters";
            this.labelMagCharacters.Size = new System.Drawing.Size(119, 63);
            this.labelMagCharacters.TabIndex = 4;
            this.labelMagCharacters.Text = "Heals: 22\r\nDamage: 5\r\nRegeneration: 3";
            // 
            // panelPaladinClass
            // 
            this.panelPaladinClass.BackColor = System.Drawing.Color.Transparent;
            this.panelPaladinClass.Controls.Add(this.buttonPaladinClass);
            this.panelPaladinClass.Controls.Add(this.labelPaladinCharacters);
            this.panelPaladinClass.Controls.Add(this.labelPaladinClass);
            this.panelPaladinClass.Location = new System.Drawing.Point(36, 277);
            this.panelPaladinClass.Name = "panelPaladinClass";
            this.panelPaladinClass.Size = new System.Drawing.Size(350, 200);
            this.panelPaladinClass.TabIndex = 5;
            this.panelPaladinClass.Visible = false;
            // 
            // buttonPaladinClass
            // 
            this.buttonPaladinClass.BackColor = System.Drawing.Color.Indigo;
            this.buttonPaladinClass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPaladinClass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPaladinClass.Location = new System.Drawing.Point(21, 157);
            this.buttonPaladinClass.Name = "buttonPaladinClass";
            this.buttonPaladinClass.Size = new System.Drawing.Size(95, 40);
            this.buttonPaladinClass.TabIndex = 6;
            this.buttonPaladinClass.Text = "Apply";
            this.buttonPaladinClass.UseVisualStyleBackColor = false;
            this.buttonPaladinClass.Click += new System.EventHandler(this.buttonPaladinClass_Click);
            // 
            // labelPaladinCharacters
            // 
            this.labelPaladinCharacters.AutoSize = true;
            this.labelPaladinCharacters.BackColor = System.Drawing.Color.Transparent;
            this.labelPaladinCharacters.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPaladinCharacters.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPaladinCharacters.Location = new System.Drawing.Point(17, 60);
            this.labelPaladinCharacters.Name = "labelPaladinCharacters";
            this.labelPaladinCharacters.Size = new System.Drawing.Size(119, 63);
            this.labelPaladinCharacters.TabIndex = 5;
            this.labelPaladinCharacters.Text = "Heals: 22\r\nDamage: 5\r\nRegeneration: 3";
            // 
            // labelPaladinClass
            // 
            this.labelPaladinClass.AutoSize = true;
            this.labelPaladinClass.BackColor = System.Drawing.Color.Transparent;
            this.labelPaladinClass.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPaladinClass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPaladinClass.Location = new System.Drawing.Point(14, 15);
            this.labelPaladinClass.Name = "labelPaladinClass";
            this.labelPaladinClass.Size = new System.Drawing.Size(101, 35);
            this.labelPaladinClass.TabIndex = 3;
            this.labelPaladinClass.Text = "Paladin";
            // 
            // buttonSkill1
            // 
            this.buttonSkill1.BackColor = System.Drawing.Color.Black;
            this.buttonSkill1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSkill1.Location = new System.Drawing.Point(12, 529);
            this.buttonSkill1.Name = "buttonSkill1";
            this.buttonSkill1.Size = new System.Drawing.Size(50, 50);
            this.buttonSkill1.TabIndex = 6;
            this.buttonSkill1.Text = "1";
            this.buttonSkill1.UseVisualStyleBackColor = false;
            this.buttonSkill1.Visible = false;
            this.buttonSkill1.Click += new System.EventHandler(this.buttonSkill1_Click);
            // 
            // buttonSkill2
            // 
            this.buttonSkill2.BackColor = System.Drawing.Color.Black;
            this.buttonSkill2.Enabled = false;
            this.buttonSkill2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSkill2.Location = new System.Drawing.Point(82, 529);
            this.buttonSkill2.Name = "buttonSkill2";
            this.buttonSkill2.Size = new System.Drawing.Size(50, 50);
            this.buttonSkill2.TabIndex = 7;
            this.buttonSkill2.Text = "2";
            this.buttonSkill2.UseVisualStyleBackColor = false;
            this.buttonSkill2.Visible = false;
            this.buttonSkill2.Click += new System.EventHandler(this.buttonSkill2_Click);
            // 
            // buttonSkill3
            // 
            this.buttonSkill3.BackColor = System.Drawing.Color.Black;
            this.buttonSkill3.Enabled = false;
            this.buttonSkill3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSkill3.Location = new System.Drawing.Point(149, 529);
            this.buttonSkill3.Name = "buttonSkill3";
            this.buttonSkill3.Size = new System.Drawing.Size(50, 50);
            this.buttonSkill3.TabIndex = 8;
            this.buttonSkill3.Text = "3";
            this.buttonSkill3.UseVisualStyleBackColor = false;
            this.buttonSkill3.Visible = false;
            this.buttonSkill3.Click += new System.EventHandler(this.buttonSkill3_Click);
            // 
            // buttonSkill4
            // 
            this.buttonSkill4.BackColor = System.Drawing.Color.Black;
            this.buttonSkill4.Enabled = false;
            this.buttonSkill4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSkill4.Location = new System.Drawing.Point(219, 529);
            this.buttonSkill4.Name = "buttonSkill4";
            this.buttonSkill4.Size = new System.Drawing.Size(50, 50);
            this.buttonSkill4.TabIndex = 9;
            this.buttonSkill4.Text = "4";
            this.buttonSkill4.UseVisualStyleBackColor = false;
            this.buttonSkill4.Visible = false;
            this.buttonSkill4.Click += new System.EventHandler(this.buttonSkill4_Click);
            // 
            // buttonSkill5
            // 
            this.buttonSkill5.BackColor = System.Drawing.Color.Black;
            this.buttonSkill5.Enabled = false;
            this.buttonSkill5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSkill5.Location = new System.Drawing.Point(287, 529);
            this.buttonSkill5.Name = "buttonSkill5";
            this.buttonSkill5.Size = new System.Drawing.Size(50, 50);
            this.buttonSkill5.TabIndex = 10;
            this.buttonSkill5.Text = "5";
            this.buttonSkill5.UseVisualStyleBackColor = false;
            this.buttonSkill5.Visible = false;
            this.buttonSkill5.Click += new System.EventHandler(this.buttonSkill5_Click);
            // 
            // buttonHeal
            // 
            this.buttonHeal.BackColor = System.Drawing.Color.Black;
            this.buttonHeal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHeal.Location = new System.Drawing.Point(1177, 529);
            this.buttonHeal.Name = "buttonHeal";
            this.buttonHeal.Size = new System.Drawing.Size(50, 50);
            this.buttonHeal.TabIndex = 11;
            this.buttonHeal.Text = "Heal";
            this.buttonHeal.UseVisualStyleBackColor = false;
            this.buttonHeal.Visible = false;
            this.buttonHeal.Click += new System.EventHandler(this.buttonHeal_Click);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.Location = new System.Drawing.Point(8, 9);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(79, 24);
            this.labelMoney.TabIndex = 12;
            this.labelMoney.Text = "Money: ";
            this.labelMoney.Visible = false;
            // 
            // labelXP
            // 
            this.labelXP.AutoSize = true;
            this.labelXP.BackColor = System.Drawing.Color.Transparent;
            this.labelXP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXP.Location = new System.Drawing.Point(8, 33);
            this.labelXP.Name = "labelXP";
            this.labelXP.Size = new System.Drawing.Size(43, 24);
            this.labelXP.TabIndex = 13;
            this.labelXP.Text = "XP: ";
            this.labelXP.Visible = false;
            // 
            // labelDamage
            // 
            this.labelDamage.AutoSize = true;
            this.labelDamage.BackColor = System.Drawing.Color.Transparent;
            this.labelDamage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDamage.Location = new System.Drawing.Point(8, 57);
            this.labelDamage.Name = "labelDamage";
            this.labelDamage.Size = new System.Drawing.Size(89, 24);
            this.labelDamage.TabIndex = 14;
            this.labelDamage.Text = "Damage: ";
            this.labelDamage.Visible = false;
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.BackColor = System.Drawing.Color.Transparent;
            this.labelClassName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClassName.Location = new System.Drawing.Point(1096, 9);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(63, 24);
            this.labelClassName.TabIndex = 15;
            this.labelClassName.Text = "Class: ";
            this.labelClassName.Visible = false;
            // 
            // pictureBoxMob
            // 
            this.pictureBoxMob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMob.BackgroundImage")));
            this.pictureBoxMob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMob.Location = new System.Drawing.Point(801, 124);
            this.pictureBoxMob.Name = "pictureBoxMob";
            this.pictureBoxMob.Size = new System.Drawing.Size(325, 321);
            this.pictureBoxMob.TabIndex = 16;
            this.pictureBoxMob.TabStop = false;
            this.pictureBoxMob.Visible = false;
            // 
            // labelXpMob
            // 
            this.labelXpMob.AutoSize = true;
            this.labelXpMob.BackColor = System.Drawing.Color.Transparent;
            this.labelXpMob.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXpMob.Location = new System.Drawing.Point(466, 156);
            this.labelXpMob.Name = "labelXpMob";
            this.labelXpMob.Size = new System.Drawing.Size(169, 97);
            this.labelXpMob.TabIndex = 17;
            this.labelXpMob.Text = "XP: ";
            this.labelXpMob.Visible = false;
            // 
            // labelMoneyMob
            // 
            this.labelMoneyMob.AutoSize = true;
            this.labelMoneyMob.BackColor = System.Drawing.Color.Transparent;
            this.labelMoneyMob.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoneyMob.Location = new System.Drawing.Point(320, 277);
            this.labelMoneyMob.Name = "labelMoneyMob";
            this.labelMoneyMob.Size = new System.Drawing.Size(315, 97);
            this.labelMoneyMob.TabIndex = 18;
            this.labelMoneyMob.Text = "Money: ";
            this.labelMoneyMob.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1239, 591);
            this.Controls.Add(this.labelMoneyMob);
            this.Controls.Add(this.labelXpMob);
            this.Controls.Add(this.pictureBoxMob);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.labelDamage);
            this.Controls.Add(this.labelXP);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.buttonHeal);
            this.Controls.Add(this.buttonSkill5);
            this.Controls.Add(this.buttonSkill4);
            this.Controls.Add(this.buttonSkill3);
            this.Controls.Add(this.buttonSkill2);
            this.Controls.Add(this.buttonSkill1);
            this.Controls.Add(this.panelPaladinClass);
            this.Controls.Add(this.panelMagClass);
            this.Controls.Add(this.labelCharacterClass);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMagClass.ResumeLayout(false);
            this.panelMagClass.PerformLayout();
            this.panelPaladinClass.ResumeLayout(false);
            this.panelPaladinClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewGame;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label labelCharacterClass;
        private System.Windows.Forms.Label labelMagClass;
        private System.Windows.Forms.Panel panelMagClass;
        private System.Windows.Forms.Label labelMagCharacters;
        private System.Windows.Forms.Panel panelPaladinClass;
        private System.Windows.Forms.Label labelPaladinCharacters;
        private System.Windows.Forms.Label labelPaladinClass;
        private System.Windows.Forms.Button buttonMagClass;
        private System.Windows.Forms.Button buttonPaladinClass;
        private System.Windows.Forms.Button buttonSkill1;
        private System.Windows.Forms.Button buttonSkill2;
        private System.Windows.Forms.Button buttonSkill3;
        private System.Windows.Forms.Button buttonSkill4;
        private System.Windows.Forms.Button buttonSkill5;
        private System.Windows.Forms.Button buttonHeal;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelXP;
        private System.Windows.Forms.Label labelDamage;
        private System.Windows.Forms.Label labelClassName;
        private System.Windows.Forms.PictureBox pictureBoxMob;
        private System.Windows.Forms.Label labelXpMob;
        private System.Windows.Forms.Label labelMoneyMob;
    }
}

