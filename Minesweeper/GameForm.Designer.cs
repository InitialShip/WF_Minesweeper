
namespace Minesweeper
{
    partial class GameForm
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.comb_Level = new System.Windows.Forms.ComboBox();
            this.lb_Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_NFlag = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_MineRemain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.Location = new System.Drawing.Point(17, 49);
            this.canvas.Margin = new System.Windows.Forms.Padding(4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1456, 672);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseLeave += new System.EventHandler(this.canvas_MouseLeave);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // comb_Level
            // 
            this.comb_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comb_Level.FormattingEnabled = true;
            this.comb_Level.Location = new System.Drawing.Point(17, 7);
            this.comb_Level.Margin = new System.Windows.Forms.Padding(4);
            this.comb_Level.Name = "comb_Level";
            this.comb_Level.Size = new System.Drawing.Size(288, 33);
            this.comb_Level.TabIndex = 1;
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_Time.ForeColor = System.Drawing.Color.White;
            this.lb_Time.Location = new System.Drawing.Point(463, 7);
            this.lb_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(59, 31);
            this.lb_Time.TabIndex = 2;
            this.lb_Time.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(585, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "No. Flag :";
            // 
            // lb_NFlag
            // 
            this.lb_NFlag.AutoSize = true;
            this.lb_NFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_NFlag.ForeColor = System.Drawing.Color.White;
            this.lb_NFlag.Location = new System.Drawing.Point(735, 6);
            this.lb_NFlag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NFlag.Name = "lb_NFlag";
            this.lb_NFlag.Size = new System.Drawing.Size(29, 31);
            this.lb_NFlag.TabIndex = 5;
            this.lb_NFlag.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(799, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mine Remaining:";
            // 
            // lb_MineRemain
            // 
            this.lb_MineRemain.AutoSize = true;
            this.lb_MineRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_MineRemain.ForeColor = System.Drawing.Color.White;
            this.lb_MineRemain.Location = new System.Drawing.Point(1041, 6);
            this.lb_MineRemain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MineRemain.Name = "lb_MineRemain";
            this.lb_MineRemain.Size = new System.Drawing.Size(29, 31);
            this.lb_MineRemain.TabIndex = 7;
            this.lb_MineRemain.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1489, 731);
            this.Controls.Add(this.lb_MineRemain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_NFlag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.comb_Level);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.ComboBox comb_Level;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_NFlag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_MineRemain;
    }
}

