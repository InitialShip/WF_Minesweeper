
namespace Minesweeper
{
    partial class Menu
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
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_ScoreBoard = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Play.Location = new System.Drawing.Point(12, 55);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(360, 40);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "Play";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_ScoreBoard
            // 
            this.btn_ScoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_ScoreBoard.Location = new System.Drawing.Point(12, 115);
            this.btn_ScoreBoard.Name = "btn_ScoreBoard";
            this.btn_ScoreBoard.Size = new System.Drawing.Size(175, 40);
            this.btn_ScoreBoard.TabIndex = 2;
            this.btn_ScoreBoard.Text = "Score Board";
            this.btn_ScoreBoard.UseVisualStyleBackColor = true;
            this.btn_ScoreBoard.Click += new System.EventHandler(this.btn_ScoreBoard_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_Exit.Location = new System.Drawing.Point(197, 115);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(175, 40);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 174);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ScoreBoard);
            this.Controls.Add(this.btn_Play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_ScoreBoard;
        private System.Windows.Forms.Button btn_Exit;
    }
}