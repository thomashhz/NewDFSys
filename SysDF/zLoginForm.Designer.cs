namespace SysDF
{
    partial class zLoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginUserID = new System.Windows.Forms.TextBox();
            this.txtPassWords = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(73, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户 →";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(73, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码 →";
            // 
            // txtLoginUserID
            // 
            this.txtLoginUserID.Location = new System.Drawing.Point(174, 180);
            this.txtLoginUserID.Name = "txtLoginUserID";
            this.txtLoginUserID.Size = new System.Drawing.Size(313, 34);
            this.txtLoginUserID.TabIndex = 2;
            this.txtLoginUserID.Text = "admin";
            // 
            // txtPassWords
            // 
            this.txtPassWords.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassWords.Location = new System.Drawing.Point(174, 268);
            this.txtPassWords.Name = "txtPassWords";
            this.txtPassWords.PasswordChar = '⚪';
            this.txtPassWords.Size = new System.Drawing.Size(313, 36);
            this.txtPassWords.TabIndex = 3;
            this.txtPassWords.UseSystemPasswordChar = true;
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(526, 173);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(133, 43);
            this.butLogin.TabIndex = 4;
            this.butLogin.Text = "登录";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(526, 262);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(133, 43);
            this.butCancel.TabIndex = 5;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // zLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 459);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.txtPassWords);
            this.Controls.Add(this.txtLoginUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "zLoginForm";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.zLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginUserID;
        private System.Windows.Forms.TextBox txtPassWords;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butCancel;
    }
}