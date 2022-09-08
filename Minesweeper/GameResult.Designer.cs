
namespace Minesweeper
{
    partial class GameResult
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
            this.btn_Replay = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.lb_Mine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Level = new System.Windows.Forms.Label();
            this.lb_Result = new System.Windows.Forms.Label();
            this.lb_Top = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Replay
            // 
            this.btn_Replay.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btn_Replay.Location = new System.Drawing.Point(12, 161);
            this.btn_Replay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Replay.Name = "btn_Replay";
            this.btn_Replay.Size = new System.Drawing.Size(271, 48);
            this.btn_Replay.TabIndex = 0;
            this.btn_Replay.Text = "Replay";
            this.btn_Replay.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Next.Location = new System.Drawing.Point(291, 161);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(271, 48);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next Level";
            this.btn_Next.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(285, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mine Remaining :";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Time.Location = new System.Drawing.Point(106, 111);
            this.lb_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(45, 25);
            this.lb_Time.TabIndex = 4;
            this.lb_Time.Text = "000";
            // 
            // lb_Mine
            // 
            this.lb_Mine.AutoSize = true;
            this.lb_Mine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Mine.Location = new System.Drawing.Point(468, 111);
            this.lb_Mine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Mine.Name = "lb_Mine";
            this.lb_Mine.Size = new System.Drawing.Size(45, 25);
            this.lb_Mine.TabIndex = 5;
            this.lb_Mine.Text = "000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Top :";
            // 
            // lb_Level
            // 
            this.lb_Level.AutoSize = true;
            this.lb_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_Level.Location = new System.Drawing.Point(16, 11);
            this.lb_Level.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Level.Name = "lb_Level";
            this.lb_Level.Size = new System.Drawing.Size(79, 31);
            this.lb_Level.TabIndex = 7;
            this.lb_Level.Text = "Level";
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_Result.Location = new System.Drawing.Point(257, 11);
            this.lb_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(92, 31);
            this.lb_Result.TabIndex = 8;
            this.lb_Result.Text = "Result";
            // 
            // lb_Top
            // 
            this.lb_Top.AutoSize = true;
            this.lb_Top.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Top.Location = new System.Drawing.Point(83, 65);
            this.lb_Top.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Top.Name = "lb_Top";
            this.lb_Top.Size = new System.Drawing.Size(47, 25);
            this.lb_Top.TabIndex = 9;
            this.lb_Top.Text = "Top";
            // 
            // GameResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 260);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Top);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.lb_Level);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Mine);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Replay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameResult";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Replay;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Label lb_Mine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Level;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Label lb_Top;
    }
}