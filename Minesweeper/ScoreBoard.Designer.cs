
namespace Minesweeper
{
    partial class ScoreBoard
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
            this.grid_Easy = new System.Windows.Forms.DataGridView();
            this.grid_Medium = new System.Windows.Forms.DataGridView();
            this.grid_Hard = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Hard)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Easy
            // 
            this.grid_Easy.AllowUserToAddRows = false;
            this.grid_Easy.AllowUserToDeleteRows = false;
            this.grid_Easy.AllowUserToResizeRows = false;
            this.grid_Easy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Easy.Location = new System.Drawing.Point(17, 64);
            this.grid_Easy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_Easy.Name = "grid_Easy";
            this.grid_Easy.ReadOnly = true;
            this.grid_Easy.RowHeadersWidth = 51;
            this.grid_Easy.Size = new System.Drawing.Size(439, 444);
            this.grid_Easy.TabIndex = 0;
            // 
            // grid_Medium
            // 
            this.grid_Medium.AllowUserToAddRows = false;
            this.grid_Medium.AllowUserToDeleteRows = false;
            this.grid_Medium.AllowUserToResizeRows = false;
            this.grid_Medium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Medium.Location = new System.Drawing.Point(464, 64);
            this.grid_Medium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_Medium.Name = "grid_Medium";
            this.grid_Medium.ReadOnly = true;
            this.grid_Medium.RowHeadersWidth = 51;
            this.grid_Medium.Size = new System.Drawing.Size(439, 444);
            this.grid_Medium.TabIndex = 1;
            // 
            // grid_Hard
            // 
            this.grid_Hard.AllowUserToAddRows = false;
            this.grid_Hard.AllowUserToDeleteRows = false;
            this.grid_Hard.AllowUserToResizeRows = false;
            this.grid_Hard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Hard.Location = new System.Drawing.Point(911, 64);
            this.grid_Hard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_Hard.Name = "grid_Hard";
            this.grid_Hard.ReadOnly = true;
            this.grid_Hard.RowHeadersWidth = 51;
            this.grid_Hard.Size = new System.Drawing.Size(439, 444);
            this.grid_Hard.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(189, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "EASY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(617, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "MEDIUM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(1079, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "HARD";
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_Hard);
            this.Controls.Add(this.grid_Medium);
            this.Controls.Add(this.grid_Easy);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScoreBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoreBoard";
            this.Load += new System.EventHandler(this.ScoreBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Hard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_Easy;
        private System.Windows.Forms.DataGridView grid_Medium;
        private System.Windows.Forms.DataGridView grid_Hard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}