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
            this.AddButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MinimizeBox = new System.Windows.Forms.PictureBox();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.leaderboardDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(165, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add To File";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Image = global::Database_Comp._Tester.Properties.Resources._1744044;
            this.MinimizeBox.Location = new System.Drawing.Point(375, 10);
            this.MinimizeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(30, 30);
            this.MinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeBox.TabIndex = 11;
            this.MinimizeBox.TabStop = false;
            this.MinimizeBox.Click += new System.EventHandler(this.MinimizeBox_Click_1);
            // 
            // ExitBox
            // 
            this.ExitBox.Image = global::Database_Comp._Tester.Properties.Resources.img_211963;
            this.ExitBox.Location = new System.Drawing.Point(411, 10);
            this.ExitBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(30, 30);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBox.TabIndex = 12;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // leaderboardDataGridView
            // 
            this.leaderboardDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.leaderboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderboardDataGridView.Location = new System.Drawing.Point(12, 81);
            this.leaderboardDataGridView.Name = "leaderboardDataGridView";
            this.leaderboardDataGridView.ReadOnly = true;
            this.leaderboardDataGridView.RowHeadersWidth = 51;
            this.leaderboardDataGridView.RowTemplate.Height = 29;
            this.leaderboardDataGridView.ShowCellErrors = false;
            this.leaderboardDataGridView.ShowCellToolTips = false;
            this.leaderboardDataGridView.ShowEditingIcon = false;
            this.leaderboardDataGridView.ShowRowErrors = false;
            this.leaderboardDataGridView.Size = new System.Drawing.Size(429, 302);
            this.leaderboardDataGridView.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "$50 Chipotle Gift Card Leaderboard : ";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Gainsboro;
            this.returnButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.returnButton.Location = new System.Drawing.Point(270, 10);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(99, 29);
            this.returnButton.TabIndex = 22;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click_1);
            // 
            // StudentEventTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 398);
            this.ControlBox = false;
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leaderboardDataGridView);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.MinimizeBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentEventTracker";
            this.Text = "        ";
            this.Load += new System.EventHandler(this.StudentEventTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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