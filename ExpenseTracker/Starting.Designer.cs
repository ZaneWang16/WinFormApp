namespace ExpenseTracker
{
    partial class Starting
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starting));
            panel1 = new Panel();
            label1 = new Label();
            LoadingProgress = new ProgressBar();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            Loadingtimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 223, 0);
            label1.Location = new Point(153, 28);
            label1.Name = "label1";
            label1.Size = new Size(202, 29);
            label1.TabIndex = 1;
            label1.Text = "Expense Tracker";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoadingProgress
            // 
            LoadingProgress.Location = new Point(7, 314);
            LoadingProgress.Name = "LoadingProgress";
            LoadingProgress.Size = new Size(488, 12);
            LoadingProgress.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Orange;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(0, 282);
            label2.Name = "label2";
            label2.Size = new Size(129, 29);
            label2.TabIndex = 3;
            label2.Text = "Loading...";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Loadingtimer
            // 
            Loadingtimer.Tick += Loadingtimer_Tick;
            // 
            // Starting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(507, 338);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(LoadingProgress);
            Controls.Add(panel1);
            Name = "Starting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Starting";
            Load += Starting_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ProgressBar LoadingProgress;
        private PictureBox pictureBox1;
        private Label label2;
        private System.Windows.Forms.Timer Loadingtimer;
    }
}