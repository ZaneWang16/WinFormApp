namespace ExpenseTracker
{
    partial class AdminExpense
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
            ExpenseDataGridView = new DataGridView();
            BackToAdminLogingBtn = new Button();
            ClearFilterBtn = new Button();
            label2 = new Label();
            ExpenseCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ExpenseDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ExpenseDataGridView
            // 
            ExpenseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ExpenseDataGridView.Location = new Point(12, 65);
            ExpenseDataGridView.Name = "ExpenseDataGridView";
            ExpenseDataGridView.RowTemplate.Height = 25;
            ExpenseDataGridView.Size = new Size(660, 384);
            ExpenseDataGridView.TabIndex = 4;
            // 
            // BackToAdminLogingBtn
            // 
            BackToAdminLogingBtn.BackColor = Color.Orange;
            BackToAdminLogingBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackToAdminLogingBtn.ForeColor = Color.White;
            BackToAdminLogingBtn.Location = new Point(619, 30);
            BackToAdminLogingBtn.Name = "BackToAdminLogingBtn";
            BackToAdminLogingBtn.Size = new Size(53, 27);
            BackToAdminLogingBtn.TabIndex = 19;
            BackToAdminLogingBtn.Text = "Back";
            BackToAdminLogingBtn.UseVisualStyleBackColor = false;
            BackToAdminLogingBtn.Click += BackToAdminLogingBtn_Click;
            // 
            // ClearFilterBtn
            // 
            ClearFilterBtn.BackColor = Color.Orange;
            ClearFilterBtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ClearFilterBtn.ForeColor = Color.White;
            ClearFilterBtn.Location = new Point(148, 30);
            ClearFilterBtn.Name = "ClearFilterBtn";
            ClearFilterBtn.Size = new Size(53, 27);
            ClearFilterBtn.TabIndex = 28;
            ClearFilterBtn.Text = "Clear";
            ClearFilterBtn.UseVisualStyleBackColor = false;
            ClearFilterBtn.Click += ClearFilterBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RoyalBlue;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 27;
            label2.Text = "Expense Category";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExpenseCategory
            // 
            ExpenseCategory.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExpenseCategory.FormattingEnabled = true;
            ExpenseCategory.Items.AddRange(new object[] { "Shopping", "Food", "Movie", "Medicine", "Household", "Car", "Travel", "Pets", "Game", "Study", "Other" });
            ExpenseCategory.Location = new Point(12, 30);
            ExpenseCategory.Name = "ExpenseCategory";
            ExpenseCategory.Size = new Size(130, 29);
            ExpenseCategory.TabIndex = 26;
            ExpenseCategory.SelectionChangeCommitted += ExpenseCategory_SelectionChangeCommitted;
            // 
            // AdminExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 461);
            Controls.Add(ClearFilterBtn);
            Controls.Add(label2);
            Controls.Add(ExpenseCategory);
            Controls.Add(BackToAdminLogingBtn);
            Controls.Add(ExpenseDataGridView);
            Name = "AdminExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminExpense";
            ((System.ComponentModel.ISupportInitialize)ExpenseDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ExpenseDataGridView;
        private Button BackToAdminLogingBtn;
        private Button ClearFilterBtn;
        private Label label2;
        private ComboBox ExpenseCategory;
    }
}