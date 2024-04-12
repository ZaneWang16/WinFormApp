namespace ExpenseTracker
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            panel1 = new Panel();
            panel2 = new Panel();
            MonthLabel = new Label();
            BackToMainBtn = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            MaxLabel = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            MinLabel = new Label();
            panel6 = new Panel();
            label2 = new Label();
            panel7 = new Panel();
            AvgLabel = new Label();
            panel8 = new Panel();
            label3 = new Label();
            panel9 = new Panel();
            TotalLabel = new Label();
            panel10 = new Panel();
            label4 = new Label();
            panel11 = new Panel();
            HighestCate = new Label();
            panel12 = new Panel();
            label5 = new Label();
            panel13 = new Panel();
            LowestCate = new Label();
            panel14 = new Panel();
            label6 = new Label();
            ExpenseCate2 = new ComboBox();
            label13 = new Label();
            TotalByCate = new Label();
            CountLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 41);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(MonthLabel);
            panel2.Controls.Add(BackToMainBtn);
            panel2.Location = new Point(42, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(647, 33);
            panel2.TabIndex = 1;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MonthLabel.ForeColor = Color.Orange;
            MonthLabel.Location = new Point(46, 1);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(103, 29);
            MonthLabel.TabIndex = 19;
            MonthLabel.Text = "Reports";
            MonthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToMainBtn
            // 
            BackToMainBtn.BackColor = Color.Orange;
            BackToMainBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackToMainBtn.ForeColor = Color.White;
            BackToMainBtn.Location = new Point(542, 3);
            BackToMainBtn.Name = "BackToMainBtn";
            BackToMainBtn.Size = new Size(53, 27);
            BackToMainBtn.TabIndex = 18;
            BackToMainBtn.Text = "Back";
            BackToMainBtn.UseVisualStyleBackColor = false;
            BackToMainBtn.Click += BackToMainBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(MaxLabel);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(56, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(132, 78);
            panel3.TabIndex = 4;
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MaxLabel.ForeColor = Color.Red;
            MaxLabel.Location = new Point(15, 37);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(41, 23);
            MaxLabel.TabIndex = 21;
            MaxLabel.Text = "Max";
            MaxLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(130, 27);
            panel4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(15, 2);
            label1.Name = "label1";
            label1.Size = new Size(97, 22);
            label1.TabIndex = 20;
            label1.Text = "Max Cost";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(MinLabel);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(291, 103);
            panel5.Name = "panel5";
            panel5.Size = new Size(132, 78);
            panel5.TabIndex = 5;
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MinLabel.ForeColor = Color.Red;
            MinLabel.Location = new Point(21, 37);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(37, 23);
            MinLabel.TabIndex = 22;
            MinLabel.Text = "Min";
            MinLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.RoyalBlue;
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(130, 27);
            panel6.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(21, 2);
            label2.Name = "label2";
            label2.Size = new Size(92, 22);
            label2.TabIndex = 21;
            label2.Text = "Min Cost";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(AvgLabel);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(55, 214);
            panel7.Name = "panel7";
            panel7.Size = new Size(132, 78);
            panel7.TabIndex = 6;
            // 
            // AvgLabel
            // 
            AvgLabel.AutoSize = true;
            AvgLabel.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AvgLabel.ForeColor = Color.Red;
            AvgLabel.Location = new Point(15, 37);
            AvgLabel.Name = "AvgLabel";
            AvgLabel.Size = new Size(40, 23);
            AvgLabel.TabIndex = 22;
            AvgLabel.Text = "Avg";
            AvgLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = Color.RoyalBlue;
            panel8.Controls.Add(label3);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(130, 27);
            panel8.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(15, 2);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 21;
            label3.Text = "Avg Cost";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(TotalLabel);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(291, 214);
            panel9.Name = "panel9";
            panel9.Size = new Size(132, 78);
            panel9.TabIndex = 7;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.ForeColor = Color.Red;
            TotalLabel.Location = new Point(21, 37);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(48, 23);
            TotalLabel.TabIndex = 22;
            TotalLabel.Text = "Total";
            TotalLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.BackColor = Color.RoyalBlue;
            panel10.Controls.Add(label4);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(130, 27);
            panel10.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(38, 2);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 21;
            label4.Text = "Total";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightGray;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(HighestCate);
            panel11.Controls.Add(panel12);
            panel11.Location = new Point(55, 325);
            panel11.Name = "panel11";
            panel11.Size = new Size(132, 78);
            panel11.TabIndex = 8;
            // 
            // HighestCate
            // 
            HighestCate.AutoSize = true;
            HighestCate.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HighestCate.ForeColor = Color.DimGray;
            HighestCate.Location = new Point(15, 39);
            HighestCate.Name = "HighestCate";
            HighestCate.Size = new Size(68, 23);
            HighestCate.TabIndex = 22;
            HighestCate.Text = "Highest";
            HighestCate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            panel12.BackColor = Color.RoyalBlue;
            panel12.Controls.Add(label5);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(130, 27);
            panel12.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(1, 2);
            label5.Name = "label5";
            label5.Size = new Size(128, 22);
            label5.TabIndex = 21;
            label5.Text = "Highest Cost";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            panel13.BackColor = Color.LightGray;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(LowestCate);
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(291, 325);
            panel13.Name = "panel13";
            panel13.Size = new Size(132, 78);
            panel13.TabIndex = 9;
            // 
            // LowestCate
            // 
            LowestCate.AutoSize = true;
            LowestCate.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LowestCate.ForeColor = Color.DimGray;
            LowestCate.Location = new Point(21, 37);
            LowestCate.Name = "LowestCate";
            LowestCate.Size = new Size(65, 23);
            LowestCate.TabIndex = 22;
            LowestCate.Text = "Lowest";
            LowestCate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            panel14.BackColor = Color.RoyalBlue;
            panel14.Controls.Add(label6);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(130, 27);
            panel14.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.RoyalBlue;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(4, 3);
            label6.Name = "label6";
            label6.Size = new Size(125, 22);
            label6.TabIndex = 21;
            label6.Text = "Lowest Cost";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExpenseCate2
            // 
            ExpenseCate2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseCate2.FormattingEnabled = true;
            ExpenseCate2.Items.AddRange(new object[] { "Shopping", "Food", "Movie", "Medicine", "Household", "Car", "Travel", "Pets", "Game", "Study", "Other" });
            ExpenseCate2.Location = new Point(504, 121);
            ExpenseCate2.Name = "ExpenseCate2";
            ExpenseCate2.Size = new Size(130, 29);
            ExpenseCate2.TabIndex = 16;
            ExpenseCate2.SelectionChangeCommitted += ExpenseCate2_SelectionChangeCommitted;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.RoyalBlue;
            label13.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Orange;
            label13.Location = new Point(516, 103);
            label13.Name = "label13";
            label13.Size = new Size(107, 15);
            label13.TabIndex = 23;
            label13.Text = "Expense Category";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TotalByCate
            // 
            TotalByCate.AutoSize = true;
            TotalByCate.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            TotalByCate.ForeColor = Color.Red;
            TotalByCate.Location = new Point(504, 153);
            TotalByCate.Name = "TotalByCate";
            TotalByCate.Size = new Size(61, 18);
            TotalByCate.TabIndex = 24;
            TotalByCate.Text = "Amount";
            TotalByCate.TextAlign = ContentAlignment.MiddleCenter;
            TotalByCate.Visible = false;
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CountLabel.ForeColor = Color.Orange;
            CountLabel.Location = new Point(12, 56);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(44, 16);
            CountLabel.TabIndex = 25;
            CountLabel.Text = "Count";
            CountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 461);
            Controls.Add(CountLabel);
            Controls.Add(TotalByCate);
            Controls.Add(label13);
            Controls.Add(ExpenseCate2);
            Controls.Add(panel13);
            Controls.Add(panel11);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BackToMainBtn;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private ComboBox ExpenseCate2;
        private Label MonthLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label MaxLabel;
        private Label MinLabel;
        private Label AvgLabel;
        private Label TotalLabel;
        private Label HighestCate;
        private Label LowestCate;
        private Label label13;
        private Label TotalByCate;
        private Label CountLabel;
    }
}