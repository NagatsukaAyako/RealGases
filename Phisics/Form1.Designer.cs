using System.Reflection;
using System.Resources;

namespace Phisics
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
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("RealGases.Properties." + RealGases.Properties.Settings.Default["lang"], typeof(Form1).Assembly);
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CylynderBox = new System.Windows.Forms.PictureBox();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.TurnOnButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PowerUp = new System.Windows.Forms.Button();
            this.PowerDoun = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.CylynderPosition = new System.Windows.Forms.Button();
            this.Os = new System.Windows.Forms.PictureBox();
            this.CylynderReset = new System.Windows.Forms.Button();
            this.ResultTable = new System.Windows.Forms.Label();
            this.GasChanger = new System.Windows.Forms.ComboBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.TemperatureBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.теорияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.укрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.CylynderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Os)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CylynderBox
            // 
            this.CylynderBox.BackColor = System.Drawing.Color.Transparent;
            this.CylynderBox.BackgroundImage = global::RealGases.Properties.Resources.ЦилиндрMod;
            this.CylynderBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CylynderBox.Location = new System.Drawing.Point(105, 165);
            this.CylynderBox.Name = "CylynderBox";
            this.CylynderBox.Size = new System.Drawing.Size(255, 122);
            this.CylynderBox.TabIndex = 0;
            this.CylynderBox.TabStop = false;
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TemperatureLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TemperatureLabel.Location = new System.Drawing.Point(435, 288);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(0, 18);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Visible = false;
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.PressureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PressureLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PressureLabel.Location = new System.Drawing.Point(435, 343);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(0, 18);
            this.PressureLabel.TabIndex = 2;
            this.PressureLabel.Visible = false;
            // 
            // TurnOnButton
            // 
            this.TurnOnButton.BackColor = System.Drawing.Color.Transparent;
            this.TurnOnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnOnButton.FlatAppearance.BorderSize = 0;
            this.TurnOnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TurnOnButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TurnOnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnOnButton.Location = new System.Drawing.Point(443, 500);
            this.TurnOnButton.Name = "TurnOnButton";
            this.TurnOnButton.Size = new System.Drawing.Size(34, 20);
            this.TurnOnButton.TabIndex = 3;
            this.TurnOnButton.UseVisualStyleBackColor = false;
            this.TurnOnButton.Click += new System.EventHandler(this.TurnOnButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PowerUp
            // 
            this.PowerUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerUp.Enabled = false;
            this.PowerUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerUp.Location = new System.Drawing.Point(430, 412);
            this.PowerUp.Name = "PowerUp";
            this.PowerUp.Size = new System.Drawing.Size(30, 30);
            this.PowerUp.TabIndex = 4;
            this.PowerUp.Text = "+";
            this.PowerUp.UseVisualStyleBackColor = true;
            this.PowerUp.Click += new System.EventHandler(this.PowerUp_Click);
            // 
            // PowerDoun
            // 
            this.PowerDoun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerDoun.Enabled = false;
            this.PowerDoun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerDoun.Location = new System.Drawing.Point(430, 449);
            this.PowerDoun.Name = "PowerDoun";
            this.PowerDoun.Size = new System.Drawing.Size(30, 30);
            this.PowerDoun.TabIndex = 5;
            this.PowerDoun.Text = "-";
            this.PowerDoun.UseVisualStyleBackColor = true;
            this.PowerDoun.Click += new System.EventHandler(this.PowerDoun_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(36, 14);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(0, 13);
            this.Info.TabIndex = 7;
            // 
            // CylynderPosition
            // 
            this.CylynderPosition.BackColor = System.Drawing.Color.Transparent;
            this.CylynderPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CylynderPosition.Enabled = false;
            this.CylynderPosition.FlatAppearance.BorderSize = 0;
            this.CylynderPosition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CylynderPosition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CylynderPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CylynderPosition.Location = new System.Drawing.Point(357, 123);
            this.CylynderPosition.Name = "CylynderPosition";
            this.CylynderPosition.Size = new System.Drawing.Size(57, 32);
            this.CylynderPosition.TabIndex = 8;
            this.CylynderPosition.UseVisualStyleBackColor = false;
            this.CylynderPosition.Click += new System.EventHandler(this.CylynderPosition_Click);
            // 
            // Os
            // 
            this.Os.BackColor = System.Drawing.Color.Transparent;
            this.Os.BackgroundImage = global::RealGases.Properties.Resources.Ось;
            this.Os.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Os.Location = new System.Drawing.Point(280, 192);
            this.Os.Name = "Os";
            this.Os.Size = new System.Drawing.Size(32, 35);
            this.Os.TabIndex = 9;
            this.Os.TabStop = false;
            // 
            // CylynderReset
            // 
            this.CylynderReset.BackColor = System.Drawing.Color.Transparent;
            this.CylynderReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CylynderReset.Enabled = false;
            this.CylynderReset.FlatAppearance.BorderSize = 0;
            this.CylynderReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CylynderReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CylynderReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CylynderReset.Location = new System.Drawing.Point(183, 113);
            this.CylynderReset.Name = "CylynderReset";
            this.CylynderReset.Size = new System.Drawing.Size(55, 32);
            this.CylynderReset.TabIndex = 10;
            this.CylynderReset.UseVisualStyleBackColor = false;
            this.CylynderReset.Click += new System.EventHandler(this.CylynderReset_Click);
            // 
            // ResultTable
            // 
            this.ResultTable.AutoSize = true;
            this.ResultTable.Location = new System.Drawing.Point(29, 0);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.Size = new System.Drawing.Size(0, 13);
            this.ResultTable.TabIndex = 11;
            // 
            // GasChanger
            // 
            this.GasChanger.Enabled = false;
            this.GasChanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GasChanger.Items.AddRange(new object[] {
            rm.GetString("gas0"),
            rm.GetString("gas1"),
            "Хлор",
            "Бром",
            rm.GetString("gas4"),
           rm.GetString("gas5"),
            "Пропан"});
            this.GasChanger.Location = new System.Drawing.Point(183, 81);
            this.GasChanger.Name = "GasChanger";
            this.GasChanger.Size = new System.Drawing.Size(147, 26);
            this.GasChanger.TabIndex = 12;
            this.GasChanger.Text = rm.GetString("gas0");
            this.GasChanger.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopButton.Enabled = false;
            this.StopButton.FlatAppearance.BorderSize = 0;
            this.StopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Location = new System.Drawing.Point(271, 113);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(59, 32);
            this.StopButton.TabIndex = 13;
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TemperatureBar
            // 
            this.TemperatureBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.TemperatureBar.Location = new System.Drawing.Point(464, 411);
            this.TemperatureBar.Margin = new System.Windows.Forms.Padding(0);
            this.TemperatureBar.Maximum = 30;
            this.TemperatureBar.Minimum = 1;
            this.TemperatureBar.Name = "TemperatureBar";
            this.TemperatureBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TemperatureBar.Size = new System.Drawing.Size(45, 70);
            this.TemperatureBar.TabIndex = 14;
            this.TemperatureBar.Value = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.теорияToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.инструкцияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.укрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // теорияToolStripMenuItem
            // 
            this.теорияToolStripMenuItem.Name = "теорияToolStripMenuItem";
            this.теорияToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.теорияToolStripMenuItem.Text = rm.GetString("theory");
            this.теорияToolStripMenuItem.Click += new System.EventHandler(this.теорияToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.инструкцияToolStripMenuItem.Text = rm.GetString("instruction");
            this.инструкцияToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = rm.GetString("about");
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ResultTable);
            this.panel1.Location = new System.Drawing.Point(642, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 612);
            this.panel1.TabIndex = 16;
            // 
            // укрToolStripMenuItem
            // 
            this.укрToolStripMenuItem.Name = "укрToolStripMenuItem";
            this.укрToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.укрToolStripMenuItem.Text = rm.GetString("lang");
            this.укрToolStripMenuItem.Click += new System.EventHandler(this.укрToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::RealGases.Properties.Resources.термостат1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TemperatureBar);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.GasChanger);
            this.Controls.Add(this.CylynderReset);
            this.Controls.Add(this.Os);
            this.Controls.Add(this.CylynderPosition);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.PowerDoun);
            this.Controls.Add(this.PowerUp);
            this.Controls.Add(this.TurnOnButton);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.CylynderBox);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = rm.GetString("lab_name");
            ((System.ComponentModel.ISupportInitialize)(this.CylynderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Os)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CylynderBox;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Button TurnOnButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button PowerUp;
        private System.Windows.Forms.Button PowerDoun;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button CylynderPosition;
        private System.Windows.Forms.PictureBox Os;
        private System.Windows.Forms.Button CylynderReset;
        private System.Windows.Forms.Label ResultTable;
        private System.Windows.Forms.ComboBox GasChanger;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TrackBar TemperatureBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem теорияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem укрToolStripMenuItem;
    }
}

