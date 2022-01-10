
namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.enterWifiName = new System.Windows.Forms.Label();
            this.ssidInput = new System.Windows.Forms.TextBox();
            this.wrongWifi = new System.Windows.Forms.Label();
            this.attack = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.madeBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.title.Font = new System.Drawing.Font("맑은 고딕", 30F);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(11, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(274, 54);
            this.title.TabIndex = 0;
            this.title.Text = "Wifi Deauther";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Location = new System.Drawing.Point(-4, 75);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(807, 2);
            this.line.TabIndex = 1;
            // 
            // enterWifiName
            // 
            this.enterWifiName.AutoSize = true;
            this.enterWifiName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enterWifiName.ForeColor = System.Drawing.Color.White;
            this.enterWifiName.Location = new System.Drawing.Point(16, 101);
            this.enterWifiName.Name = "enterWifiName";
            this.enterWifiName.Size = new System.Drawing.Size(87, 21);
            this.enterWifiName.TabIndex = 2;
            this.enterWifiName.Text = "Enter SSID";
            // 
            // ssidInput
            // 
            this.ssidInput.BackColor = System.Drawing.Color.White;
            this.ssidInput.Location = new System.Drawing.Point(20, 135);
            this.ssidInput.Name = "ssidInput";
            this.ssidInput.Size = new System.Drawing.Size(344, 21);
            this.ssidInput.TabIndex = 3;
            // 
            // wrongWifi
            // 
            this.wrongWifi.AutoSize = true;
            this.wrongWifi.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wrongWifi.ForeColor = System.Drawing.Color.Red;
            this.wrongWifi.Location = new System.Drawing.Point(17, 168);
            this.wrongWifi.Name = "wrongWifi";
            this.wrongWifi.Size = new System.Drawing.Size(0, 17);
            this.wrongWifi.TabIndex = 4;
            // 
            // attack
            // 
            this.attack.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.attack.ForeColor = System.Drawing.Color.Black;
            this.attack.Location = new System.Drawing.Point(20, 220);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(83, 45);
            this.attack.TabIndex = 5;
            this.attack.Text = "Attack";
            this.attack.UseVisualStyleBackColor = true;
            this.attack.Click += new System.EventHandler(this.attack_Click);
            // 
            // confirm
            // 
            this.confirm.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.confirm.Location = new System.Drawing.Point(388, 135);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(61, 21);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stop.Location = new System.Drawing.Point(122, 220);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(83, 45);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // madeBy
            // 
            this.madeBy.AutoSize = true;
            this.madeBy.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.madeBy.ForeColor = System.Drawing.Color.White;
            this.madeBy.Location = new System.Drawing.Point(715, 428);
            this.madeBy.Name = "madeBy";
            this.madeBy.Size = new System.Drawing.Size(73, 13);
            this.madeBy.TabIndex = 8;
            this.madeBy.Text = "Made by HK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.madeBy);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.wrongWifi);
            this.Controls.Add(this.ssidInput);
            this.Controls.Add(this.enterWifiName);
            this.Controls.Add(this.line);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label enterWifiName;
        private System.Windows.Forms.TextBox ssidInput;
        private System.Windows.Forms.Label wrongWifi;
        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label madeBy;
    }
}

