namespace Weather
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TemperatureTextBox = new TextBox();
            TemperatureLabel = new Label();
            RainLabel = new Label();
            RainTextBox = new TextBox();
            label1 = new Label();
            HumidityTextBox = new TextBox();
            label2 = new Label();
            PressureTextBox = new TextBox();
            label3 = new Label();
            WindSpeedTextBox = new TextBox();
            WMOPictureBox = new PictureBox();
            WMOLabel = new Label();
            menuStrip1 = new MenuStrip();
            aplikacjaToolStripMenuItem = new ToolStripMenuItem();
            wyjścieToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)WMOPictureBox).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TemperatureTextBox
            // 
            TemperatureTextBox.Location = new Point(157, 37);
            TemperatureTextBox.Name = "TemperatureTextBox";
            TemperatureTextBox.Size = new Size(100, 23);
            TemperatureTextBox.TabIndex = 0;
            // 
            // TemperatureLabel
            // 
            TemperatureLabel.AutoSize = true;
            TemperatureLabel.Location = new Point(74, 40);
            TemperatureLabel.Name = "TemperatureLabel";
            TemperatureLabel.Size = new Size(77, 15);
            TemperatureLabel.TabIndex = 1;
            TemperatureLabel.Text = "Temperatura:";
            // 
            // RainLabel
            // 
            RainLabel.AutoSize = true;
            RainLabel.Location = new Point(106, 69);
            RainLabel.Name = "RainLabel";
            RainLabel.Size = new Size(45, 15);
            RainLabel.TabIndex = 3;
            RainLabel.Text = "Opady:";
            // 
            // RainTextBox
            // 
            RainTextBox.Location = new Point(157, 66);
            RainTextBox.Name = "RainTextBox";
            RainTextBox.Size = new Size(100, 23);
            RainTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 98);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "Wilgotność:";
            // 
            // HumidityTextBox
            // 
            HumidityTextBox.Location = new Point(157, 95);
            HumidityTextBox.Name = "HumidityTextBox";
            HumidityTextBox.Size = new Size(100, 23);
            HumidityTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 127);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 7;
            label2.Text = "Ciśnienie atmosferyczne:";
            // 
            // PressureTextBox
            // 
            PressureTextBox.Location = new Point(157, 124);
            PressureTextBox.Name = "PressureTextBox";
            PressureTextBox.Size = new Size(100, 23);
            PressureTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 156);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 9;
            label3.Text = "Prędkość wiatru:";
            // 
            // WindSpeedTextBox
            // 
            WindSpeedTextBox.Location = new Point(157, 153);
            WindSpeedTextBox.Name = "WindSpeedTextBox";
            WindSpeedTextBox.Size = new Size(100, 23);
            WindSpeedTextBox.TabIndex = 8;
            // 
            // WMOPictureBox
            // 
            WMOPictureBox.Location = new Point(106, 182);
            WMOPictureBox.Name = "WMOPictureBox";
            WMOPictureBox.Size = new Size(100, 100);
            WMOPictureBox.TabIndex = 10;
            WMOPictureBox.TabStop = false;
            // 
            // WMOLabel
            // 
            WMOLabel.Location = new Point(106, 285);
            WMOLabel.Name = "WMOLabel";
            WMOLabel.Size = new Size(100, 23);
            WMOLabel.TabIndex = 11;
            WMOLabel.Text = "label4";
            WMOLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aplikacjaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(314, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // aplikacjaToolStripMenuItem
            // 
            aplikacjaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wyjścieToolStripMenuItem });
            aplikacjaToolStripMenuItem.Name = "aplikacjaToolStripMenuItem";
            aplikacjaToolStripMenuItem.Size = new Size(67, 20);
            aplikacjaToolStripMenuItem.Text = "Aplikacja";
            // 
            // wyjścieToolStripMenuItem
            // 
            wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            wyjścieToolStripMenuItem.Size = new Size(180, 22);
            wyjścieToolStripMenuItem.Text = "Wyjście";
            wyjścieToolStripMenuItem.Click += wyjścieToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 329);
            Controls.Add(WMOLabel);
            Controls.Add(WMOPictureBox);
            Controls.Add(label3);
            Controls.Add(WindSpeedTextBox);
            Controls.Add(label2);
            Controls.Add(PressureTextBox);
            Controls.Add(label1);
            Controls.Add(HumidityTextBox);
            Controls.Add(RainLabel);
            Controls.Add(RainTextBox);
            Controls.Add(TemperatureLabel);
            Controls.Add(TemperatureTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)WMOPictureBox).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TemperatureTextBox;
        private Label TemperatureLabel;
        private Label RainLabel;
        private TextBox RainTextBox;
        private Label label1;
        private TextBox HumidityTextBox;
        private Label label2;
        private TextBox PressureTextBox;
        private Label label3;
        private TextBox WindSpeedTextBox;
        private PictureBox WMOPictureBox;
        private Label WMOLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aplikacjaToolStripMenuItem;
        private ToolStripMenuItem wyjścieToolStripMenuItem;
    }
}
