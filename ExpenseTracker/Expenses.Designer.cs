namespace ExpenseTracker
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            panel1 = new Panel();
            panel2 = new Panel();
            MonthLabel = new Label();
            ExpBackToMainBtn = new Button();
            pictureBox1 = new PictureBox();
            ExpenseName = new TextBox();
            ExpenseAmount = new TextBox();
            ExpenseDescription = new TextBox();
            ExpenseCategory = new ComboBox();
            ExpenseDate = new DateTimePicker();
            AddExpBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 41);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(MonthLabel);
            panel2.Controls.Add(ExpBackToMainBtn);
            panel2.Location = new Point(42, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 33);
            panel2.TabIndex = 1;
            // 
            // MonthLabel
            // 
            MonthLabel.AutoSize = true;
            MonthLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            MonthLabel.ForeColor = Color.Orange;
            MonthLabel.Location = new Point(17, 3);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(165, 29);
            MonthLabel.TabIndex = 20;
            MonthLabel.Text = "Add Expense";
            MonthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExpBackToMainBtn
            // 
            ExpBackToMainBtn.BackColor = Color.Orange;
            ExpBackToMainBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ExpBackToMainBtn.ForeColor = Color.White;
            ExpBackToMainBtn.Location = new Point(295, 3);
            ExpBackToMainBtn.Name = "ExpBackToMainBtn";
            ExpBackToMainBtn.Size = new Size(53, 27);
            ExpBackToMainBtn.TabIndex = 18;
            ExpBackToMainBtn.Text = "Back";
            ExpBackToMainBtn.UseVisualStyleBackColor = false;
            ExpBackToMainBtn.Click += ExpBackToMainBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ExpenseName
            // 
            ExpenseName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseName.Location = new Point(55, 117);
            ExpenseName.Name = "ExpenseName";
            ExpenseName.Size = new Size(130, 27);
            ExpenseName.TabIndex = 2;
            // 
            // ExpenseAmount
            // 
            ExpenseAmount.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseAmount.Location = new Point(55, 187);
            ExpenseAmount.Name = "ExpenseAmount";
            ExpenseAmount.Size = new Size(130, 27);
            ExpenseAmount.TabIndex = 9;
            // 
            // ExpenseDescription
            // 
            ExpenseDescription.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseDescription.Location = new Point(153, 253);
            ExpenseDescription.Multiline = true;
            ExpenseDescription.Name = "ExpenseDescription";
            ExpenseDescription.Size = new Size(130, 80);
            ExpenseDescription.TabIndex = 11;
            // 
            // ExpenseCategory
            // 
            ExpenseCategory.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseCategory.FormattingEnabled = true;
            ExpenseCategory.Items.AddRange(new object[] { "Shopping", "Food", "Movie", "Medicine", "Household", "Car", "Travel", "Pets", "Game", "Study", "Other" });
            ExpenseCategory.Location = new Point(251, 117);
            ExpenseCategory.Name = "ExpenseCategory";
            ExpenseCategory.Size = new Size(130, 29);
            ExpenseCategory.TabIndex = 14;
            // 
            // ExpenseDate
            // 
            ExpenseDate.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseDate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseDate.Format = DateTimePickerFormat.Short;
            ExpenseDate.Location = new Point(251, 187);
            ExpenseDate.Name = "ExpenseDate";
            ExpenseDate.Size = new Size(130, 27);
            ExpenseDate.TabIndex = 16;
            // 
            // AddExpBtn
            // 
            AddExpBtn.BackColor = Color.RoyalBlue;
            AddExpBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddExpBtn.ForeColor = Color.White;
            AddExpBtn.Location = new Point(153, 355);
            AddExpBtn.Name = "AddExpBtn";
            AddExpBtn.Size = new Size(130, 36);
            AddExpBtn.TabIndex = 17;
            AddExpBtn.Text = "Adding";
            AddExpBtn.UseVisualStyleBackColor = false;
            AddExpBtn.Click += AddExpBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(55, 96);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 21;
            label1.Text = "Expense Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(251, 96);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 22;
            label2.Text = "Expense Category";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(55, 166);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 23;
            label3.Text = "Expense Amount";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(251, 166);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 24;
            label4.Text = "Expense Date";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RoyalBlue;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(182, 235);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 25;
            label5.Text = "Description";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(424, 451);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddExpBtn);
            Controls.Add(ExpenseDate);
            Controls.Add(ExpenseCategory);
            Controls.Add(ExpenseDescription);
            Controls.Add(ExpenseAmount);
            Controls.Add(ExpenseName);
            Controls.Add(panel1);
            Name = "Expenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expenses";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox ExpenseName;
        private TextBox ExpenseAmount;
        private TextBox ExpenseDescription;
        private ComboBox ExpenseCategory;
        private DateTimePicker ExpenseDate;
        private Button AddExpBtn;
        private Button ExpBackToMainBtn;
        private Label MonthLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}