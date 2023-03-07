namespace Database_Comp._Tester
{
    partial class StudentEventTracker
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
            AddButton = new Button();
            comboBox1 = new ComboBox();
            MinimizeBox = new PictureBox();
            ExitBox = new PictureBox();
            leaderboardDataGridView = new DataGridView();
            label1 = new Label();
            returnButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MinimizeBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leaderboardDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.Control;
            AddButton.Location = new Point(169, 12);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add To File";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // MinimizeBox
            // 
            MinimizeBox.Image = Properties.Resources._1744044;
            MinimizeBox.Location = new Point(377, 10);
            MinimizeBox.Margin = new Padding(3, 4, 3, 4);
            MinimizeBox.Name = "MinimizeBox";
            MinimizeBox.Size = new Size(30, 30);
            MinimizeBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MinimizeBox.TabIndex = 11;
            MinimizeBox.TabStop = false;
            MinimizeBox.Click += MinimizeBox_Click;
            // 
            // ExitBox
            // 
            ExitBox.Image = Properties.Resources.img_211963;
            ExitBox.Location = new Point(411, 10);
            ExitBox.Margin = new Padding(3, 4, 3, 4);
            ExitBox.Name = "ExitBox";
            ExitBox.Size = new Size(30, 30);
            ExitBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ExitBox.TabIndex = 12;
            ExitBox.TabStop = false;
            ExitBox.Click += pictureBox2_Click;
            // 
            // leaderboardDataGridView
            // 
            leaderboardDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leaderboardDataGridView.Location = new Point(12, 81);
            leaderboardDataGridView.Name = "leaderboardDataGridView";
            leaderboardDataGridView.ReadOnly = true;
            leaderboardDataGridView.RowHeadersWidth = 51;
            leaderboardDataGridView.RowTemplate.Height = 29;
            leaderboardDataGridView.ShowCellErrors = false;
            leaderboardDataGridView.ShowCellToolTips = false;
            leaderboardDataGridView.ShowEditingIcon = false;
            leaderboardDataGridView.ShowRowErrors = false;
            leaderboardDataGridView.Size = new Size(429, 302);
            leaderboardDataGridView.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(410, 31);
            label1.TabIndex = 21;
            label1.Text = "$50 Chipotle Gift Card Leaderboard : ";
            // 
            // returnButton
            // 
            returnButton.Location = new Point(269, 12);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(94, 29);
            returnButton.TabIndex = 22;
            returnButton.Text = "Return";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // StudentEventTracker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 398);
            ControlBox = false;
            Controls.Add(returnButton);
            Controls.Add(label1);
            Controls.Add(leaderboardDataGridView);
            Controls.Add(ExitBox);
            Controls.Add(MinimizeBox);
            Controls.Add(comboBox1);
            Controls.Add(AddButton);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "StudentEventTracker";
            Text = "Student Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)MinimizeBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)leaderboardDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddButton;
        private ComboBox comboBox1;
        private PictureBox MinimizeBox;
        private PictureBox ExitBox;
        private DataGridView leaderboardDataGridView;
        private Label label1;
        private Button returnButton;
    }
}