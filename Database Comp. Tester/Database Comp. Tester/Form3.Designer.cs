﻿namespace Database_Comp._Tester
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.DrawRandomBtn = new System.Windows.Forms.Button();
            this.leaderboardDataGridView = new System.Windows.Forms.DataGridView();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "$50 Chipotle Gift Card Leaderboard : ";
            // 
            // DrawRandomBtn
            // 
            this.DrawRandomBtn.Location = new System.Drawing.Point(12, 12);
            this.DrawRandomBtn.Name = "DrawRandomBtn";
            this.DrawRandomBtn.Size = new System.Drawing.Size(167, 29);
            this.DrawRandomBtn.TabIndex = 23;
            this.DrawRandomBtn.Text = "Draw Random Student";
            this.DrawRandomBtn.UseVisualStyleBackColor = true;
            this.DrawRandomBtn.Click += new System.EventHandler(this.DrawRandomBtn_Click);
            // 
            // leaderboardDataGridView
            // 
            this.leaderboardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderboardDataGridView.Location = new System.Drawing.Point(12, 82);
            this.leaderboardDataGridView.Name = "leaderboardDataGridView";
            this.leaderboardDataGridView.ReadOnly = true;
            this.leaderboardDataGridView.RowHeadersWidth = 51;
            this.leaderboardDataGridView.RowTemplate.Height = 29;
            this.leaderboardDataGridView.Size = new System.Drawing.Size(429, 302);
            this.leaderboardDataGridView.TabIndex = 22;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(195, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(94, 29);
            this.returnButton.TabIndex = 25;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 401);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawRandomBtn);
            this.Controls.Add(this.leaderboardDataGridView);
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaderboardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button DrawRandomBtn;
        private DataGridView leaderboardDataGridView;
        private Button returnButton;
    }
}