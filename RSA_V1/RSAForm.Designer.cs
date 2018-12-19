namespace RSA_V1
{
    partial class RSAFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_OldStr = new System.Windows.Forms.Label();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.lb_D = new System.Windows.Forms.Label();
            this.txt_Q = new System.Windows.Forms.TextBox();
            this.lb_Q = new System.Windows.Forms.Label();
            this.txt_P = new System.Windows.Forms.TextBox();
            this.lb_P = new System.Windows.Forms.Label();
            this.txt_E = new System.Windows.Forms.TextBox();
            this.lb_E = new System.Windows.Forms.Label();
            this.txt_OldStr = new System.Windows.Forms.TextBox();
            this.lb_RASStr = new System.Windows.Forms.Label();
            this.txt_RasStr = new System.Windows.Forms.TextBox();
            this.btn_CreateKey = new System.Windows.Forms.Button();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_OldStr
            // 
            this.lb_OldStr.AutoSize = true;
            this.lb_OldStr.Location = new System.Drawing.Point(34, 355);
            this.lb_OldStr.Name = "lb_OldStr";
            this.lb_OldStr.Size = new System.Drawing.Size(29, 24);
            this.lb_OldStr.TabIndex = 0;
            this.lb_OldStr.Text = "原字\r\n符串";
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(69, 13);
            this.txt_D.Multiline = true;
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(711, 73);
            this.txt_D.TabIndex = 1;
            // 
            // lb_D
            // 
            this.lb_D.AutoSize = true;
            this.lb_D.Location = new System.Drawing.Point(52, 43);
            this.lb_D.Name = "lb_D";
            this.lb_D.Size = new System.Drawing.Size(11, 12);
            this.lb_D.TabIndex = 0;
            this.lb_D.Text = "D";
            // 
            // txt_Q
            // 
            this.txt_Q.Location = new System.Drawing.Point(69, 92);
            this.txt_Q.Multiline = true;
            this.txt_Q.Name = "txt_Q";
            this.txt_Q.Size = new System.Drawing.Size(711, 73);
            this.txt_Q.TabIndex = 1;
            // 
            // lb_Q
            // 
            this.lb_Q.AutoSize = true;
            this.lb_Q.Location = new System.Drawing.Point(50, 124);
            this.lb_Q.Name = "lb_Q";
            this.lb_Q.Size = new System.Drawing.Size(11, 12);
            this.lb_Q.TabIndex = 0;
            this.lb_Q.Text = "Q";
            // 
            // txt_P
            // 
            this.txt_P.Location = new System.Drawing.Point(69, 171);
            this.txt_P.Multiline = true;
            this.txt_P.Name = "txt_P";
            this.txt_P.Size = new System.Drawing.Size(711, 73);
            this.txt_P.TabIndex = 1;
            // 
            // lb_P
            // 
            this.lb_P.AutoSize = true;
            this.lb_P.Location = new System.Drawing.Point(52, 200);
            this.lb_P.Name = "lb_P";
            this.lb_P.Size = new System.Drawing.Size(11, 12);
            this.lb_P.TabIndex = 0;
            this.lb_P.Text = "P";
            // 
            // txt_E
            // 
            this.txt_E.Location = new System.Drawing.Point(69, 250);
            this.txt_E.Multiline = true;
            this.txt_E.Name = "txt_E";
            this.txt_E.Size = new System.Drawing.Size(711, 73);
            this.txt_E.TabIndex = 1;
            // 
            // lb_E
            // 
            this.lb_E.AutoSize = true;
            this.lb_E.Location = new System.Drawing.Point(52, 280);
            this.lb_E.Name = "lb_E";
            this.lb_E.Size = new System.Drawing.Size(11, 12);
            this.lb_E.TabIndex = 0;
            this.lb_E.Text = "E";
            // 
            // txt_OldStr
            // 
            this.txt_OldStr.Location = new System.Drawing.Point(69, 329);
            this.txt_OldStr.Multiline = true;
            this.txt_OldStr.Name = "txt_OldStr";
            this.txt_OldStr.Size = new System.Drawing.Size(711, 73);
            this.txt_OldStr.TabIndex = 1;
            // 
            // lb_RASStr
            // 
            this.lb_RASStr.AutoSize = true;
            this.lb_RASStr.Location = new System.Drawing.Point(34, 436);
            this.lb_RASStr.Name = "lb_RASStr";
            this.lb_RASStr.Size = new System.Drawing.Size(29, 12);
            this.lb_RASStr.TabIndex = 0;
            this.lb_RASStr.Text = "加密";
            // 
            // txt_RasStr
            // 
            this.txt_RasStr.Location = new System.Drawing.Point(69, 408);
            this.txt_RasStr.Multiline = true;
            this.txt_RasStr.Name = "txt_RasStr";
            this.txt_RasStr.Size = new System.Drawing.Size(711, 73);
            this.txt_RasStr.TabIndex = 1;
            // 
            // btn_CreateKey
            // 
            this.btn_CreateKey.Location = new System.Drawing.Point(116, 494);
            this.btn_CreateKey.Name = "btn_CreateKey";
            this.btn_CreateKey.Size = new System.Drawing.Size(138, 23);
            this.btn_CreateKey.TabIndex = 2;
            this.btn_CreateKey.Text = "生成秘钥对";
            this.btn_CreateKey.UseVisualStyleBackColor = true;
            this.btn_CreateKey.Click += new System.EventHandler(this.btn_CreateKey_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(273, 494);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(138, 23);
            this.btn_Encrypt.TabIndex = 2;
            this.btn_Encrypt.Text = "RAS加密";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(432, 494);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(138, 23);
            this.btn_Decrypt.TabIndex = 2;
            this.btn_Decrypt.Text = "RAS解密";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(591, 494);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(138, 23);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "刷新秘钥";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // RSAFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 529);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.btn_CreateKey);
            this.Controls.Add(this.txt_RasStr);
            this.Controls.Add(this.txt_OldStr);
            this.Controls.Add(this.lb_E);
            this.Controls.Add(this.txt_E);
            this.Controls.Add(this.lb_P);
            this.Controls.Add(this.txt_P);
            this.Controls.Add(this.lb_Q);
            this.Controls.Add(this.txt_Q);
            this.Controls.Add(this.lb_D);
            this.Controls.Add(this.lb_RASStr);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.lb_OldStr);
            this.Name = "RSAFrom";
            this.Text = "RAS加密和解密";
            this.Load += new System.EventHandler(this.RSAFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_OldStr;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.Label lb_D;
        private System.Windows.Forms.TextBox txt_Q;
        private System.Windows.Forms.Label lb_Q;
        private System.Windows.Forms.TextBox txt_P;
        private System.Windows.Forms.Label lb_P;
        private System.Windows.Forms.TextBox txt_E;
        private System.Windows.Forms.Label lb_E;
        private System.Windows.Forms.TextBox txt_OldStr;
        private System.Windows.Forms.Label lb_RASStr;
        private System.Windows.Forms.TextBox txt_RasStr;
        private System.Windows.Forms.Button btn_CreateKey;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Button btn_Refresh;
    }
}

