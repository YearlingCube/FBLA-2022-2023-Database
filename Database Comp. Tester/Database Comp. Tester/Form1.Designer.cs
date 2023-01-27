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
            this.InputTextBox1 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MinimizeBox = new System.Windows.Forms.PictureBox();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputTextBox2 = new System.Windows.Forms.TextBox();
            this.InputTextBox3 = new System.Windows.Forms.TextBox();
            this.InputTextBox4 = new System.Windows.Forms.TextBox();
            this.InputTextBox5 = new System.Windows.Forms.TextBox();
            this.InputTextBox6 = new System.Windows.Forms.TextBox();
            this.leaderboardDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InputTextBox1
            // 
            this.InputTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputTextBox1.Location = new System.Drawing.Point(29, 120);
            this.InputTextBox1.MaxLength = 1;
            this.InputTextBox1.Name = "InputTextBox1";
            this.InputTextBox1.Size = new System.Drawing.Size(45, 70);
            this.InputTextBox1.TabIndex = 0;
            this.InputTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox2_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(186, 193);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add To File";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(12, 412);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(125, 27);
            this.OutputTextBox.TabIndex = 4;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(12, 390);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(62, 20);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "Output :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // MinimizeBox
            // 
            this.MinimizeBox.Image = global::Database_Comp._Tester.Properties.Resources._1744044;
            this.MinimizeBox.Location = new System.Drawing.Point(734, 2);
            this.MinimizeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox.Name = "MinimizeBox";
            this.MinimizeBox.Size = new System.Drawing.Size(30, 30);
            this.MinimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeBox.TabIndex = 11;
            this.MinimizeBox.TabStop = false;
            this.MinimizeBox.Click += new System.EventHandler(this.MinimizeBox_Click);
            // 
            // ExitBox
            // 
            this.ExitBox.Image = global::Database_Comp._Tester.Properties.Resources.img_211963;
            this.ExitBox.Location = new System.Drawing.Point(768, 2);
            this.ExitBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(30, 30);
            this.ExitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBox.TabIndex = 12;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Database_Comp._Tester.Properties.Resources.generatedtext;
            this.pictureBox1.Location = new System.Drawing.Point(12, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 53);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // InputTextBox2
            // 
            this.InputTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox2.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputTextBox2.Location = new System.Drawing.Point(80, 120);
            this.InputTextBox2.MaxLength = 1;
            this.InputTextBox2.Name = "InputTextBox2";
            this.InputTextBox2.Size = new System.Drawing.Size(45, 70);
            this.InputTextBox2.TabIndex = 14;
            this.InputTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox2_KeyPress);
            // 
            // InputTextBox3
            // 
            this.InputTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox3.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputTextBox3.Location = new System.Drawing.Point(131, 120);
            this.InputTextBox3.MaxLength = 1;
            this.InputTextBox3.Name = "InputTextBox3";
            this.InputTextBox3.Size = new System.Drawing.Size(45, 70);
            this.InputTextBox3.TabIndex = 15;
            this.InputTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox2_KeyPress);
            // 
            // InputTextBox4
            // 
            this.InputTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox4.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputTextBox4.Location = new System.Drawing.Point(182, 120);
            this.InputTextBox4.MaxLength = 1;
            this.InputTextBox4.Name = "InputTextBox4";
            this.InputTextBox4.Size = new System.Drawing.Size(45, 70);
            this.InputTextBox4.TabIndex = 16;
            this.InputTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox2_KeyPress);
            // 
            // InputTextBox5
            // 
            this.InputTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox5.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputTextBox5.Location = new System.Drawing.Point(233, 120);
            this.InputTextBox5.MaxLength = 1;
            this.InputTextBox5.Name = "InputTextBox5";
            this.InputTextBox5.Size = new System.Drawing.Size(45, 70);
            this.InputTextBox5.TabIndex = 17;
            this.InputTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox2_KeyPress);
            // 
            // InputTextBox6
            // 
            this.InputTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox6.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputTextBox6.Location = new System.Drawing.Point(284, 120);
            this.InputTextBox6.MaxLength = 1;
            this.InputTextBox6.Name = "InputTextBox6";
            this.InputTextBox6.Size = new System.Drawing.Size(45, 70);
            this.InputTextBox6.TabIndex = 18;
            this.InputTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputTextBox2_KeyPress);
            // 
            // leaderboardDataGridView
            // 
            this.leaderboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderboardDataGridView.Location = new System.Drawing.Point(335, 120);
            this.leaderboardDataGridView.Name = "leaderboardDataGridView";
            this.leaderboardDataGridView.RowHeadersWidth = 51;
            this.leaderboardDataGridView.RowTemplate.Height = 29;
            this.leaderboardDataGridView.Size = new System.Drawing.Size(453, 302);
            this.leaderboardDataGridView.TabIndex = 19;
            // 
            // StudentEventTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.leaderboardDataGridView);
            this.Controls.Add(this.InputTextBox6);
            this.Controls.Add(this.InputTextBox5);
            this.Controls.Add(this.InputTextBox4);
            this.Controls.Add(this.InputTextBox3);
            this.Controls.Add(this.InputTextBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.MinimizeBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentEventTracker";
            this.Text = "ack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputTextBox1;
        private Button AddButton;
        private TextBox OutputTextBox;
        private Label OutputLabel;
        private ComboBox comboBox1;
        private PictureBox MinimizeBox;
        private PictureBox ExitBox;
        private PictureBox pictureBox1;
        private TextBox InputTextBox2;
        private TextBox InputTextBox3;
        private TextBox InputTextBox4;
        private TextBox InputTextBox5;
        private TextBox InputTextBox6;
        private DataGridView leaderboardDataGridView;
    }
}