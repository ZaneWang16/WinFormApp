namespace ExpenseTracker
{
    partial class ViewExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExpense));
            panel1 = new Panel();
            panel2 = new Panel();
            MonthLabel = new Label();
            BackToUsersBtn = new Button();
            pictureBox1 = new PictureBox();
            VeiwDataGridView = new DataGridView();
            label2 = new Label();
            ExpenseCategory = new ComboBox();
            ClearFilterBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VeiwDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-4, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 41);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(MonthLabel);
            panel2.Controls.Add(BackToUsersBtn);
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
            MonthLabel.Location = new Point(46, 3);
            MonthLabel.Name = "MonthLabel";
            MonthLabel.Size = new Size(173, 29);
            MonthLabel.TabIndex = 20;
            MonthLabel.Text = "View Expense";
            MonthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackToUsersBtn
            // 
            BackToUsersBtn.BackColor = Color.Orange;
            BackToUsersBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackToUsersBtn.ForeColor = Color.White;
            BackToUsersBtn.Location = new Point(543, 3);
            BackToUsersBtn.Name = "BackToUsersBtn";
            BackToUsersBtn.Size = new Size(53, 27);
            BackToUsersBtn.TabIndex = 18;
            BackToUsersBtn.Text = "Back";
            BackToUsersBtn.UseVisualStyleBackColor = false;
            BackToUsersBtn.Click += BackToUsersBtn_Click;
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
            // VeiwDataGridView
            // 
            VeiwDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VeiwDataGridView.Location = new Point(12, 133);
            VeiwDataGridView.Name = "VeiwDataGridView";
            VeiwDataGridView.RowTemplate.Height = 25;
            VeiwDataGridView.Size = new Size(660, 316);
            VeiwDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 24;
            label2.Text = "Expense Category";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExpenseCategory
            // 
            ExpenseCategory.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseCategory.FormattingEnabled = true;
            ExpenseCategory.Items.AddRange(new object[] { "Shopping", "Food", "Movie", "Medicine", "Household", "Car", "Travel", "Pets", "Game", "Study", "Other" });
            ExpenseCategory.Location = new Point(12, 86);
            ExpenseCategory.Name = "ExpenseCategory";
            ExpenseCategory.Size = new Size(130, 29);
            ExpenseCategory.TabIndex = 23;
            ExpenseCategory.SelectionChangeCommitted += ExpenseCategory_SelectionChangeCommitted;
            // 
            // ClearFilterBtn
            // 
            ClearFilterBtn.BackColor = Color.Orange;
            ClearFilterBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ClearFilterBtn.ForeColor = Color.White;
            ClearFilterBtn.Location = new Point(148, 86);
            ClearFilterBtn.Name = "ClearFilterBtn";
            ClearFilterBtn.Size = new Size(53, 27);
            ClearFilterBtn.TabIndex = 25;
            ClearFilterBtn.Text = "Clear";
            ClearFilterBtn.UseVisualStyleBackColor = false;
            ClearFilterBtn.Click += ClearFilterBtn_Click;
            // 
            // ViewExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(ClearFilterBtn);
            Controls.Add(label2);
            Controls.Add(ExpenseCategory);
            Controls.Add(VeiwDataGridView);
            Controls.Add(panel1);
            Name = "ViewExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewExpense";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)VeiwDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BackToUsersBtn;
        private PictureBox pictureBox1;
        private DataGridView VeiwDataGridView;
        private Label MonthLabel;
        private Label label2;
        private ComboBox ExpenseCategory;
        private Button ClearFilterBtn;
    }
}