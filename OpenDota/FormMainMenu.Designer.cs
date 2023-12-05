namespace OpenDota
{
    partial class FormMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.metroButtonPlayers = new MetroFramework.Controls.MetroButton();
            this.metroButtonCharacters = new MetroFramework.Controls.MetroButton();
            this.metroButtonItems = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButtonPlayers
            // 
            this.metroButtonPlayers.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonPlayers.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButtonPlayers.Location = new System.Drawing.Point(65, 208);
            this.metroButtonPlayers.Name = "metroButtonPlayers";
            this.metroButtonPlayers.Size = new System.Drawing.Size(215, 78);
            this.metroButtonPlayers.TabIndex = 1;
            this.metroButtonPlayers.Text = "Игроки";
            this.metroButtonPlayers.UseSelectable = true;
            this.metroButtonPlayers.Click += new System.EventHandler(this.metroButtonPlayers_Click);
            // 
            // metroButtonCharacters
            // 
            this.metroButtonCharacters.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonCharacters.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButtonCharacters.Location = new System.Drawing.Point(65, 315);
            this.metroButtonCharacters.Name = "metroButtonCharacters";
            this.metroButtonCharacters.Size = new System.Drawing.Size(215, 78);
            this.metroButtonCharacters.TabIndex = 2;
            this.metroButtonCharacters.Text = "Персонажи";
            this.metroButtonCharacters.UseSelectable = true;
            this.metroButtonCharacters.Click += new System.EventHandler(this.metroButtonCharacters_Click);
            // 
            // metroButtonItems
            // 
            this.metroButtonItems.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonItems.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButtonItems.Location = new System.Drawing.Point(65, 419);
            this.metroButtonItems.Name = "metroButtonItems";
            this.metroButtonItems.Size = new System.Drawing.Size(215, 78);
            this.metroButtonItems.TabIndex = 3;
            this.metroButtonItems.Text = "Предметы";
            this.metroButtonItems.UseSelectable = true;
            this.metroButtonItems.Click += new System.EventHandler(this.metroButtonItems_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(344, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButtonItems);
            this.Controls.Add(this.metroButtonCharacters);
            this.Controls.Add(this.metroButtonPlayers);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainMenu";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Программа сбора аналитики ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButtonPlayers;
        private MetroFramework.Controls.MetroButton metroButtonCharacters;
        private MetroFramework.Controls.MetroButton metroButtonItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

