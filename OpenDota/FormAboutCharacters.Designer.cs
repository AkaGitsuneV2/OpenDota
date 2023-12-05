namespace OpenDota
{
    partial class FormAboutCharacters
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabelName = new MetroFramework.Controls.MetroLabel();
            this.metroLabelHealth = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMana = new MetroFramework.Controls.MetroLabel();
            this.metroLabelArmor = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAttackMin = new MetroFramework.Controls.MetroLabel();
            this.metroLabelAttackMax = new MetroFramework.Controls.MetroLabel();
            this.metroLabelMove = new MetroFramework.Controls.MetroLabel();
            this.metroLabelHeroId = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabelAttackRange = new MetroFramework.Controls.MetroLabel();
            this.metroLabelWins = new MetroFramework.Controls.MetroLabel();
            this.metroLabelPicks = new MetroFramework.Controls.MetroLabel();
            this.metroLabelNight = new MetroFramework.Controls.MetroLabel();
            this.metroLabelDay = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(105, 69);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(122, 95);
            this.metroProgressSpinner1.Speed = 2F;
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressSpinner1.TabIndex = 20;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabelAttackRange);
            this.metroPanel1.Controls.Add(this.metroLabelHeroId);
            this.metroPanel1.Controls.Add(this.metroLabelMove);
            this.metroPanel1.Controls.Add(this.metroLabelAttackMax);
            this.metroPanel1.Controls.Add(this.metroLabelAttackMin);
            this.metroPanel1.Controls.Add(this.metroLabelArmor);
            this.metroPanel1.Controls.Add(this.metroLabelMana);
            this.metroPanel1.Controls.Add(this.metroLabelHealth);
            this.metroPanel1.Controls.Add(this.metroLabelName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(320, 33);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(399, 318);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabelName
            // 
            this.metroLabelName.AutoSize = true;
            this.metroLabelName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabelName.Location = new System.Drawing.Point(0, 0);
            this.metroLabelName.Name = "metroLabelName";
            this.metroLabelName.Size = new System.Drawing.Size(62, 25);
            this.metroLabelName.TabIndex = 2;
            this.metroLabelName.Text = "Name";
            // 
            // metroLabelHealth
            // 
            this.metroLabelHealth.AutoSize = true;
            this.metroLabelHealth.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelHealth.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelHealth.Location = new System.Drawing.Point(0, 36);
            this.metroLabelHealth.Name = "metroLabelHealth";
            this.metroLabelHealth.Size = new System.Drawing.Size(63, 25);
            this.metroLabelHealth.TabIndex = 3;
            this.metroLabelHealth.Text = "Health";
            // 
            // metroLabelMana
            // 
            this.metroLabelMana.AutoSize = true;
            this.metroLabelMana.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMana.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelMana.Location = new System.Drawing.Point(0, 72);
            this.metroLabelMana.Name = "metroLabelMana";
            this.metroLabelMana.Size = new System.Drawing.Size(56, 25);
            this.metroLabelMana.TabIndex = 4;
            this.metroLabelMana.Text = "Mana";
            // 
            // metroLabelArmor
            // 
            this.metroLabelArmor.AutoSize = true;
            this.metroLabelArmor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelArmor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelArmor.Location = new System.Drawing.Point(0, 108);
            this.metroLabelArmor.Name = "metroLabelArmor";
            this.metroLabelArmor.Size = new System.Drawing.Size(63, 25);
            this.metroLabelArmor.TabIndex = 5;
            this.metroLabelArmor.Text = "Armor";
            // 
            // metroLabelAttackMin
            // 
            this.metroLabelAttackMin.AutoSize = true;
            this.metroLabelAttackMin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAttackMin.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelAttackMin.Location = new System.Drawing.Point(0, 144);
            this.metroLabelAttackMin.Name = "metroLabelAttackMin";
            this.metroLabelAttackMin.Size = new System.Drawing.Size(97, 25);
            this.metroLabelAttackMin.TabIndex = 6;
            this.metroLabelAttackMin.Text = "Attack min";
            // 
            // metroLabelAttackMax
            // 
            this.metroLabelAttackMax.AutoSize = true;
            this.metroLabelAttackMax.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAttackMax.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelAttackMax.Location = new System.Drawing.Point(0, 180);
            this.metroLabelAttackMax.Name = "metroLabelAttackMax";
            this.metroLabelAttackMax.Size = new System.Drawing.Size(95, 25);
            this.metroLabelAttackMax.TabIndex = 7;
            this.metroLabelAttackMax.Text = "AttackMax";
            // 
            // metroLabelMove
            // 
            this.metroLabelMove.AutoSize = true;
            this.metroLabelMove.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelMove.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelMove.Location = new System.Drawing.Point(-1, 216);
            this.metroLabelMove.Name = "metroLabelMove";
            this.metroLabelMove.Size = new System.Drawing.Size(57, 25);
            this.metroLabelMove.TabIndex = 8;
            this.metroLabelMove.Text = "Move";
            // 
            // metroLabelHeroId
            // 
            this.metroLabelHeroId.AutoSize = true;
            this.metroLabelHeroId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelHeroId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelHeroId.Location = new System.Drawing.Point(0, 288);
            this.metroLabelHeroId.Name = "metroLabelHeroId";
            this.metroLabelHeroId.Size = new System.Drawing.Size(71, 25);
            this.metroLabelHeroId.TabIndex = 9;
            this.metroLabelHeroId.Text = "Hero id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(23, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 169);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // metroLabelAttackRange
            // 
            this.metroLabelAttackRange.AutoSize = true;
            this.metroLabelAttackRange.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelAttackRange.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelAttackRange.Location = new System.Drawing.Point(-1, 252);
            this.metroLabelAttackRange.Name = "metroLabelAttackRange";
            this.metroLabelAttackRange.Size = new System.Drawing.Size(117, 25);
            this.metroLabelAttackRange.TabIndex = 21;
            this.metroLabelAttackRange.Text = "Attack Range";
            // 
            // metroLabelWins
            // 
            this.metroLabelWins.AutoSize = true;
            this.metroLabelWins.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelWins.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelWins.Location = new System.Drawing.Point(22, 321);
            this.metroLabelWins.Name = "metroLabelWins";
            this.metroLabelWins.Size = new System.Drawing.Size(95, 25);
            this.metroLabelWins.TabIndex = 25;
            this.metroLabelWins.Text = "Turbo Win";
            // 
            // metroLabelPicks
            // 
            this.metroLabelPicks.AutoSize = true;
            this.metroLabelPicks.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelPicks.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelPicks.Location = new System.Drawing.Point(22, 285);
            this.metroLabelPicks.Name = "metroLabelPicks";
            this.metroLabelPicks.Size = new System.Drawing.Size(95, 25);
            this.metroLabelPicks.TabIndex = 24;
            this.metroLabelPicks.Text = "Turbo Pick";
            // 
            // metroLabelNight
            // 
            this.metroLabelNight.AutoSize = true;
            this.metroLabelNight.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelNight.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelNight.Location = new System.Drawing.Point(23, 249);
            this.metroLabelNight.Name = "metroLabelNight";
            this.metroLabelNight.Size = new System.Drawing.Size(107, 25);
            this.metroLabelNight.TabIndex = 23;
            this.metroLabelNight.Text = "Night vision";
            // 
            // metroLabelDay
            // 
            this.metroLabelDay.AutoSize = true;
            this.metroLabelDay.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelDay.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabelDay.Location = new System.Drawing.Point(23, 213);
            this.metroLabelDay.Name = "metroLabelDay";
            this.metroLabelDay.Size = new System.Drawing.Size(94, 25);
            this.metroLabelDay.TabIndex = 22;
            this.metroLabelDay.Text = "Day vision";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // FormAboutCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 362);
            this.Controls.Add(this.metroLabelWins);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroLabelPicks);
            this.Controls.Add(this.metroLabelNight);
            this.Controls.Add(this.metroLabelDay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutCharacters";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "FormAboutCharacters";
            this.Load += new System.EventHandler(this.FormAboutCharacters_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabelHeroId;
        private MetroFramework.Controls.MetroLabel metroLabelMove;
        private MetroFramework.Controls.MetroLabel metroLabelAttackMax;
        private MetroFramework.Controls.MetroLabel metroLabelAttackMin;
        private MetroFramework.Controls.MetroLabel metroLabelArmor;
        private MetroFramework.Controls.MetroLabel metroLabelMana;
        private MetroFramework.Controls.MetroLabel metroLabelHealth;
        private MetroFramework.Controls.MetroLabel metroLabelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabelAttackRange;
        private MetroFramework.Controls.MetroLabel metroLabelWins;
        private MetroFramework.Controls.MetroLabel metroLabelPicks;
        private MetroFramework.Controls.MetroLabel metroLabelNight;
        private MetroFramework.Controls.MetroLabel metroLabelDay;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}