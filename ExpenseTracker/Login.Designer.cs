namespace ExpenseTracker
{
    partial class Login
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
            panel1 = new Panel();
            label1 = new Label();
            UserNameTable = new TextBox();
            UserPasswordTable = new TextBox();
            LoginBtn = new Button();
            AdminLoginBtn = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 81);
            panel1.TabIndex = 1;
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
            // UserNameTable
            // 
            UserNameTable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTable.Location = new Point(132, 143);
            UserNameTable.Name = "UserNameTable";
            UserNameTable.Size = new Size(202, 26);
            UserNameTable.TabIndex = 2;
            // 
            // UserPasswordTable
            // 
            UserPasswordTable.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserPasswordTable.Location = new Point(132, 195);
            UserPasswordTable.Name = "UserPasswordTable";
            UserPasswordTable.PasswordChar = '*';
            UserPasswordTable.Size = new Size(202, 26);
            UserPasswordTable.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.RoyalBlue;
            LoginBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(173, 227);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(113, 34);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // AdminLoginBtn
            // 
            AdminLoginBtn.BackColor = Color.White;
            AdminLoginBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLoginBtn.ForeColor = Color.Gold;
            AdminLoginBtn.Location = new Point(173, 267);
            AdminLoginBtn.Name = "AdminLoginBtn";
            AdminLoginBtn.Size = new Size(113, 34);
            AdminLoginBtn.TabIndex = 5;
            AdminLoginBtn.Text = "Admin";
            AdminLoginBtn.UseVisualStyleBackColor = false;
            AdminLoginBtn.Click += AdminLoginBtn_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(132, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(92, 14);
            textBox3.TabIndex = 6;
            textBox3.Text = "UserName";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(132, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(92, 14);
            textBox4.TabIndex = 7;
            textBox4.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 321);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(AdminLoginBtn);
            Controls.Add(LoginBtn);
            Controls.Add(UserPasswordTable);
            Controls.Add(UserNameTable);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox UserNameTable;
        private TextBox UserPasswordTable;
        private Button LoginBtn;
        private Button AdminLoginBtn;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}