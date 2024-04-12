namespace ExpenseTracker
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            LogoutBtn = new Button();
            ViewRepBtn = new Button();
            VeiwExpBtn = new Button();
            AddExpenseBtn = new Button();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            UserNameLabel = new Label();
            pictureBox2 = new PictureBox();
            MonthLabel = new Label();
            DayLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(LogoutBtn);
            panel1.Controls.Add(ViewRepBtn);
            panel1.Controls.Add(VeiwExpBtn);
            panel1.Controls.Add(AddExpenseBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 41);
            panel1.TabIndex = 0;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.RoyalBlue;
            LogoutBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(491, -1);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(126, 40);
            LogoutBtn.TabIndex = 8;
            LogoutBtn.Text = "Log Out";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // ViewRepBtn
            // 
            ViewRepBtn.BackColor = Color.RoyalBlue;
            ViewRepBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewRepBtn.ForeColor = Color.White;
            ViewRepBtn.Location = new Point(335, -1);
            ViewRepBtn.Name = "ViewRepBtn";
            ViewRepBtn.Size = new Size(126, 40);
            ViewRepBtn.TabIndex = 7;
            ViewRepBtn.Text = "Reports";
            ViewRepBtn.UseVisualStyleBackColor = false;
            ViewRepBtn.Click += ViewRepBtn_Click;
            // 
            // VeiwExpBtn
            // 
            VeiwExpBtn.BackColor = Color.RoyalBlue;
            VeiwExpBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            VeiwExpBtn.ForeColor = Color.White;
            VeiwExpBtn.Location = new Point(179, -1);
            VeiwExpBtn.Name = "VeiwExpBtn";
            VeiwExpBtn.Size = new Size(126, 40);
            VeiwExpBtn.TabIndex = 6;
            VeiwExpBtn.Text = "View Expenses";
            VeiwExpBtn.UseVisualStyleBackColor = false;
            VeiwExpBtn.Click += VeiwExpBtn_Click;
            // 
            // AddExpenseBtn
            // 
            AddExpenseBtn.BackColor = Color.RoyalBlue;
            AddExpenseBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddExpenseBtn.ForeColor = Color.White;
            AddExpenseBtn.Location = new Point(27, -1);
            AddExpenseBtn.Name = "AddExpenseBtn";
            AddExpenseBtn.Size = new Size(126, 40);
            AddExpenseBtn.TabIndex = 5;
            AddExpenseBtn.Text = "Add Expenses";
            AddExpenseBtn.UseVisualStyleBackColor = false;
            AddExpenseBtn.Click += AddExpenseBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(636, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(244, 253, 255);
            panel4.Controls.Add(UserNameLabel);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(MonthLabel);
            panel4.Controls.Add(DayLabel);
            panel4.Controls.Add(panel1);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(685, 438);
            panel4.TabIndex = 1;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.BackColor = Color.FromArgb(244, 253, 255);
            UserNameLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            UserNameLabel.ForeColor = Color.RoyalBlue;
            UserNameLabel.Location = new Point(31, 398);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(136, 29);
            UserNameLabel.TabIndex = 21;
            UserNameLabel.Text = "User Name";
            UserNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(244, 253, 255);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(183, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(282, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MonthLabel.Location = new Point(274, 97);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(87, 29);
            MonthLabel.TabIndex = 2;
            MonthLabel.Text = "Month";
            MonthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DayLabel
            // 
            DayLabel.AutoSize = true;
            DayLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            DayLabel.Location = new Point(305, 59);
            DayLabel.Name = "DayLabel";
            DayLabel.Size = new Size(56, 29);
            DayLabel.TabIndex = 1;
            DayLabel.Text = "Day";
            DayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 253, 255);
            ClientSize = new Size(709, 462);
            Controls.Add(panel4);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label MonthLabel;
        private Label DayLabel;
        private PictureBox pictureBox2;
        private Button AddExpenseBtn;
        private Button LogoutBtn;
        private Button ViewRepBtn;
        private Button VeiwExpBtn;
        private Label UserNameLabel;
    }
}