namespace ExpenseTracker
{
    partial class AdminLogin
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
            textBox4 = new TextBox();
            BackToLogin = new Button();
            AdminLoginBtn = new Button();
            UserPasswordTable = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(132, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(92, 14);
            textBox4.TabIndex = 14;
            textBox4.Text = "Password";
            // 
            // BackToLogin
            // 
            BackToLogin.BackColor = Color.White;
            BackToLogin.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackToLogin.ForeColor = Color.Orange;
            BackToLogin.Location = new Point(174, 220);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(113, 34);
            BackToLogin.TabIndex = 12;
            BackToLogin.Text = "Back";
            BackToLogin.UseVisualStyleBackColor = false;
            BackToLogin.Click += BackToLogin_Click;
            // 
            // AdminLoginBtn
            // 
            AdminLoginBtn.BackColor = Color.RoyalBlue;
            AdminLoginBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLoginBtn.ForeColor = Color.White;
            AdminLoginBtn.Location = new Point(174, 180);
            AdminLoginBtn.Name = "AdminLoginBtn";
            AdminLoginBtn.Size = new Size(113, 34);
            AdminLoginBtn.TabIndex = 11;
            AdminLoginBtn.Text = "LOGIN";
            AdminLoginBtn.UseVisualStyleBackColor = false;
            AdminLoginBtn.Click += AdminLoginBtn_Click;
            // 
            // UserPasswordTable
            // 
            UserPasswordTable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserPasswordTable.Location = new Point(132, 127);
            UserPasswordTable.Name = "UserPasswordTable";
            UserPasswordTable.PasswordChar = '*';
            UserPasswordTable.Size = new Size(202, 26);
            UserPasswordTable.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 81);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 223, 0);
            label1.Location = new Point(132, 26);
            label1.Name = "label1";
            label1.Size = new Size(202, 29);
            label1.TabIndex = 1;
            label1.Text = "Expense Tracker";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 321);
            Controls.Add(textBox4);
            Controls.Add(BackToLogin);
            Controls.Add(AdminLoginBtn);
            Controls.Add(UserPasswordTable);
            Controls.Add(panel1);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Button BackToLogin;
        private Button AdminLoginBtn;
        private TextBox UserPasswordTable;
        private Panel panel1;
        private Label label1;
    }
}