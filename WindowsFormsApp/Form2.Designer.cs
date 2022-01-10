
namespace WindowsFormsApp
{
    partial class Form2
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
            this.line = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.Process = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Label();
            this.times = new System.Windows.Forms.Label();
            this.attackCount = new System.Windows.Forms.Label();
            this.madeBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Location = new System.Drawing.Point(-4, 75);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(807, 2);
            this.line.TabIndex = 0;
            this.line.Text = " ";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(11, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(137, 54);
            this.title.TabIndex = 1;
            this.title.Tag = "";
            this.title.Text = "Attack";
            // 
            // Process
            // 
            this.Process.AutoSize = true;
            this.Process.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process.ForeColor = System.Drawing.Color.White;
            this.Process.Location = new System.Drawing.Point(16, 101);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(120, 22);
            this.Process.TabIndex = 3;
            this.Process.Text = "Attacking..";
            // 
            // done
            // 
            this.done.AutoSize = true;
            this.done.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.done.ForeColor = System.Drawing.Color.White;
            this.done.Location = new System.Drawing.Point(14, 152);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(245, 32);
            this.done.TabIndex = 4;
            this.done.Text = "Successfully Attacked";
            // 
            // times
            // 
            this.times.AutoSize = true;
            this.times.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.times.ForeColor = System.Drawing.Color.White;
            this.times.Location = new System.Drawing.Point(424, 152);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(85, 32);
            this.times.TabIndex = 5;
            this.times.Text = "Times!";
            // 
            // attackCount
            // 
            this.attackCount.AutoSize = true;
            this.attackCount.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.attackCount.ForeColor = System.Drawing.Color.White;
            this.attackCount.Location = new System.Drawing.Point(283, 152);
            this.attackCount.Name = "attackCount";
            this.attackCount.Size = new System.Drawing.Size(28, 32);
            this.attackCount.TabIndex = 6;
            this.attackCount.Text = "0";
            // 
            // madeBy
            // 
            this.madeBy.AutoSize = true;
            this.madeBy.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.madeBy.ForeColor = System.Drawing.Color.White;
            this.madeBy.Location = new System.Drawing.Point(715, 428);
            this.madeBy.Name = "madeBy";
            this.madeBy.Size = new System.Drawing.Size(73, 13);
            this.madeBy.TabIndex = 9;
            this.madeBy.Text = "Made by HK";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.madeBy);
            this.Controls.Add(this.attackCount);
            this.Controls.Add(this.times);
            this.Controls.Add(this.done);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.title);
            this.Controls.Add(this.line);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Process;
        private System.Windows.Forms.Label done;
        private System.Windows.Forms.Label times;
        private System.Windows.Forms.Label attackCount;
        private System.Windows.Forms.Label madeBy;
    }
}