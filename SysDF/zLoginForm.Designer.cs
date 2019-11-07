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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(zLoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginUserID = new System.Windows.Forms.TextBox();
            this.txtPassWords = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(73, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户 →";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(73, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码 →";
            // 
            // txtLoginUserID
            // 
            this.txtLoginUserID.Location = new System.Drawing.Point(174, 272);
            this.txtLoginUserID.Name = "txtLoginUserID";
            this.txtLoginUserID.Size = new System.Drawing.Size(313, 28);
            this.txtLoginUserID.TabIndex = 5;
            this.txtLoginUserID.Text = "admin";
            this.txtLoginUserID.TextChanged += new System.EventHandler(this.txtLoginUserID_TextChanged);
            this.txtLoginUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginUserID_KeyPress);
            // 
            // txtPassWords
            // 
            this.txtPassWords.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassWords.Location = new System.Drawing.Point(174, 326);
            this.txtPassWords.Name = "txtPassWords";
            this.txtPassWords.PasswordChar = '★';
            this.txtPassWords.Size = new System.Drawing.Size(313, 30);
            this.txtPassWords.TabIndex = 2;
            this.txtPassWords.UseSystemPasswordChar = true;
            this.txtPassWords.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassWords_KeyPress);
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(526, 269);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(133, 37);
            this.butLogin.TabIndex = 3;
            this.butLogin.Text = "登录";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(526, 320);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(130, 38);
            this.butCancel.TabIndex = 4;
            this.butCancel.Text = "取消";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 268);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // zLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 364);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.txtPassWords);
            this.Controls.Add(this.txtLoginUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "zLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.zLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}