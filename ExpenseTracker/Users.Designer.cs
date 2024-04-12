namespace ExpenseTracker
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            panel1 = new Panel();
            panel2 = new Panel();
            MonthLabel = new Label();
            BackToAdminLoginBtn = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            ViewExpenseBtn = new Button();
            UserDOB = new DateTimePicker();
            UserAddressTb = new TextBox();
            UserPhoneTb = new TextBox();
            UserNameTb = new TextBox();
            label6 = new Label();
            UserPasswordTb = new TextBox();
            UsersDataGridView = new DataGridView();
            AddUserBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 41);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(MonthLabel);
            panel2.Controls.Add(BackToAdminLoginBtn);
            panel2.Location = new Point(42, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 33);
            panel2.TabIndex = 1;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MonthLabel.ForeColor = Color.Orange;
            MonthLabel.Location = new Point(15, 3);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(78, 29);
            MonthLabel.TabIndex = 19;
            MonthLabel.Text = "Users";
            MonthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToAdminLoginBtn
            // 
            BackToAdminLoginBtn.BackColor = Color.Orange;
            BackToAdminLoginBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackToAdminLoginBtn.ForeColor = Color.White;
            BackToAdminLoginBtn.Location = new Point(357, 3);
            BackToAdminLoginBtn.Name = "BackToAdminLoginBtn";
            BackToAdminLoginBtn.Size = new Size(53, 27);
            BackToAdminLoginBtn.TabIndex = 18;
            BackToAdminLoginBtn.Text = "Back";
            BackToAdminLoginBtn.UseVisualStyleBackColor = false;
            BackToAdminLoginBtn.Click += BackToAdminLoginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(337, 69);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 36;
            label5.Text = "Address";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(176, 69);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 35;
            label4.Text = "User DOB";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(176, 143);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 34;
            label3.Text = "Phone Number";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(16, 69);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 32;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewExpenseBtn
            // 
            ViewExpenseBtn.BackColor = Color.RoyalBlue;
            ViewExpenseBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewExpenseBtn.ForeColor = Color.White;
            ViewExpenseBtn.Location = new Point(342, 197);
            ViewExpenseBtn.Name = "ViewExpenseBtn";
            ViewExpenseBtn.Size = new Size(130, 36);
            ViewExpenseBtn.TabIndex = 31;
            ViewExpenseBtn.Text = "View Expense";
            ViewExpenseBtn.UseVisualStyleBackColor = false;
            ViewExpenseBtn.Click += ViewExpenseBtn_Click;
            // 
            // UserDOB
            // 
            UserDOB.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserDOB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserDOB.Format = DateTimePickerFormat.Short;
            UserDOB.Location = new Point(176, 90);
            UserDOB.Name = "UserDOB";
            UserDOB.Size = new Size(130, 27);
            UserDOB.TabIndex = 30;
            // 
            // UserAddressTb
            // 
            UserAddressTb.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UserAddressTb.Location = new Point(337, 87);
            UserAddressTb.Multiline = true;
            UserAddressTb.Name = "UserAddressTb";
            UserAddressTb.Size = new Size(130, 104);
            UserAddressTb.TabIndex = 28;
            // 
            // UserPhoneTb
            // 
            UserPhoneTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserPhoneTb.Location = new Point(176, 164);
            UserPhoneTb.Name = "UserPhoneTb";
            UserPhoneTb.Size = new Size(130, 27);
            UserPhoneTb.TabIndex = 27;
            // 
            // UserNameTb
            // 
            UserNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserNameTb.Location = new Point(16, 90);
            UserNameTb.Name = "UserNameTb";
            UserNameTb.Size = new Size(130, 27);
            UserNameTb.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.RoyalBlue;
            label6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(16, 143);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 38;
            label6.Text = "Password";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserPasswordTb
            // 
            UserPasswordTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserPasswordTb.Location = new Point(16, 164);
            UserPasswordTb.Name = "UserPasswordTb";
            UserPasswordTb.Size = new Size(130, 27);
            UserPasswordTb.TabIndex = 37;
            // 
            // UsersDataGridView
            // 
            UsersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGridView.Location = new Point(12, 239);
            UsersDataGridView.Name = "UsersDataGridView";
            UsersDataGridView.RowTemplate.Height = 25;
            UsersDataGridView.Size = new Size(460, 239);
            UsersDataGridView.TabIndex = 39;
            // 
            // AddUserBtn
            // 
            AddUserBtn.BackColor = Color.RoyalBlue;
            AddUserBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddUserBtn.ForeColor = Color.White;
            AddUserBtn.Location = new Point(176, 494);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(130, 36);
            AddUserBtn.TabIndex = 40;
            AddUserBtn.Text = "Adding User";
            AddUserBtn.UseVisualStyleBackColor = false;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(AddUserBtn);
            Controls.Add(UsersDataGridView);
            Controls.Add(label6);
            Controls.Add(UserPasswordTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(ViewExpenseBtn);
            Controls.Add(UserDOB);
            Controls.Add(UserAddressTb);
            Controls.Add(UserPhoneTb);
            Controls.Add(UserNameTb);
            Controls.Add(panel1);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label MonthLabel;
        private Button BackToAdminLoginBtn;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button ViewExpenseBtn;
        private DateTimePicker UserDOB;
        private TextBox UserAddressTb;
        private TextBox UserPhoneTb;
        private TextBox UserNameTb;
        private Label label6;
        private TextBox UserPasswordTb;
        private DataGridView UsersDataGridView;
        private Button AddUserBtn;
    }
}