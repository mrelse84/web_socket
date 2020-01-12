namespace ws_test
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
            this.btnStartSrv = new System.Windows.Forms.Button();
            this.btnStopSrv = new System.Windows.Forms.Button();
            this.richTxtLog = new System.Windows.Forms.RichTextBox();
            this.richTxtClientLog = new System.Windows.Forms.RichTextBox();
            this.btnStartClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartSrv
            // 
            this.btnStartSrv.Location = new System.Drawing.Point(41, 28);
            this.btnStartSrv.Name = "btnStartSrv";
            this.btnStartSrv.Size = new System.Drawing.Size(82, 34);
            this.btnStartSrv.TabIndex = 0;
            this.btnStartSrv.Text = "Start Srv";
            this.btnStartSrv.UseVisualStyleBackColor = true;
            this.btnStartSrv.Click += new System.EventHandler(this.btnStartSrv_Click);
            // 
            // btnStopSrv
            // 
            this.btnStopSrv.Location = new System.Drawing.Point(41, 82);
            this.btnStopSrv.Name = "btnStopSrv";
            this.btnStopSrv.Size = new System.Drawing.Size(82, 34);
            this.btnStopSrv.TabIndex = 1;
            this.btnStopSrv.Text = "Stop Srv";
            this.btnStopSrv.UseVisualStyleBackColor = true;
            this.btnStopSrv.Click += new System.EventHandler(this.btnStopSrv_Click);
            // 
            // richTxtLog
            // 
            this.richTxtLog.Location = new System.Drawing.Point(163, 28);
            this.richTxtLog.Name = "richTxtLog";
            this.richTxtLog.Size = new System.Drawing.Size(506, 143);
            this.richTxtLog.TabIndex = 2;
            this.richTxtLog.Text = "";
            // 
            // richTxtClientLog
            // 
            this.richTxtClientLog.Location = new System.Drawing.Point(163, 227);
            this.richTxtClientLog.Name = "richTxtClientLog";
            this.richTxtClientLog.Size = new System.Drawing.Size(506, 143);
            this.richTxtClientLog.TabIndex = 3;
            this.richTxtClientLog.Text = "";
            // 
            // btnStartClient
            // 
            this.btnStartClient.Location = new System.Drawing.Point(41, 227);
            this.btnStartClient.Name = "btnStartClient";
            this.btnStartClient.Size = new System.Drawing.Size(82, 34);
            this.btnStartClient.TabIndex = 4;
            this.btnStartClient.Text = "Start Client";
            this.btnStartClient.UseVisualStyleBackColor = true;
            this.btnStartClient.Click += new System.EventHandler(this.btnStartClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.btnStartClient);
            this.Controls.Add(this.richTxtClientLog);
            this.Controls.Add(this.richTxtLog);
            this.Controls.Add(this.btnStopSrv);
            this.Controls.Add(this.btnStartSrv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartSrv;
        private System.Windows.Forms.Button btnStopSrv;
        private System.Windows.Forms.RichTextBox richTxtLog;
        public System.Windows.Forms.RichTextBox richTxtClientLog;
        private System.Windows.Forms.Button btnStartClient;
    }
}

