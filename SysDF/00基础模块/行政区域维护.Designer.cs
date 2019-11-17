namespace SysDF._00基础模块
{
    partial class 行政区域维护
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
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolEdit = new System.Windows.Forms.ToolStripButton();
            this.toolDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRef = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateTime = new System.Windows.Forms.TextBox();
            this.UpdateUserID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Createtime = new System.Windows.Forms.TextBox();
            this.CreateUserID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolExit,
            this.toolStripSeparator1,
            this.toolAdd,
            this.toolEdit,
            this.toolDel,
            this.toolStripSeparator2,
            this.toolSave,
            this.toolCancel,
            this.toolStripSeparator3,
            this.toolRef});
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1049, 25);
            this.tools.TabIndex = 8;
            this.tools.Text = "toolStrip1";
            // 
            // toolExit
            // 
            this.toolExit.Image = global::SysDF.Properties.Resources.top;
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(52, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = global::SysDF.Properties.Resources.add;
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(52, 22);
            this.toolAdd.Text = "新增";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolEdit
            // 
            this.toolEdit.Image = global::SysDF.Properties.Resources.edit;
            this.toolEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.Size = new System.Drawing.Size(52, 22);
            this.toolEdit.Text = "修改";
            this.toolEdit.Click += new System.EventHandler(this.toolEdit_Click);
            // 
            // toolDel
            // 
            this.toolDel.Image = global::SysDF.Properties.Resources.delete;
            this.toolDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDel.Name = "toolDel";
            this.toolDel.Size = new System.Drawing.Size(52, 22);
            this.toolDel.Text = "删除";
            this.toolDel.Click += new System.EventHandler(this.toolDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.Image = global::SysDF.Properties.Resources.saveas;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(52, 22);
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Enabled = false;
            this.toolCancel.Image = global::SysDF.Properties.Resources.deletefile;
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(52, 22);
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolRef
            // 
            this.toolRef.Image = global::SysDF.Properties.Resources.refresh;
            this.toolRef.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRef.Name = "toolRef";
            this.toolRef.Size = new System.Drawing.Size(52, 22);
            this.toolRef.Text = "刷新";
            this.toolRef.Click += new System.EventHandler(this.toolRef_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.TreeView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 561);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "区域列表";
            // 
            // TreeView1
            // 
            this.TreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TreeView1.Location = new System.Drawing.Point(6, 34);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Size = new System.Drawing.Size(478, 520);
            this.TreeView1.TabIndex = 1;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            this.TreeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            this.TreeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.UpdateTime);
            this.groupBox2.Controls.Add(this.UpdateUserID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Createtime);
            this.groupBox2.Controls.Add(this.CreateUserID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox0);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(518, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 561);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "区域维护";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "区域简称：";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(126, 211);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(377, 23);
            this.textBox5.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 23);
            this.textBox1.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 321);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(377, 23);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(377, 23);
            this.textBox3.TabIndex = 8;
            this.textBox3.Tag = "";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(126, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(377, 23);
            this.textBox2.TabIndex = 7;
            // 
            // textBox0
            // 
            this.textBox0.Enabled = false;
            this.textBox0.Location = new System.Drawing.Point(126, 46);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(377, 23);
            this.textBox0.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "区域编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "位置排序：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "上级区域：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "区域名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "区域ID：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 14);
            this.label7.TabIndex = 24;
            this.label7.Text = "最后修改时间：";
            // 
            // UpdateTime
            // 
            this.UpdateTime.Enabled = false;
            this.UpdateTime.Location = new System.Drawing.Point(126, 495);
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Size = new System.Drawing.Size(377, 23);
            this.UpdateTime.TabIndex = 23;
            // 
            // UpdateUserID
            // 
            this.UpdateUserID.Enabled = false;
            this.UpdateUserID.Location = new System.Drawing.Point(126, 452);
            this.UpdateUserID.Name = "UpdateUserID";
            this.UpdateUserID.Size = new System.Drawing.Size(377, 23);
            this.UpdateUserID.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "最后修改人：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "创建时间：";
            // 
            // Createtime
            // 
            this.Createtime.Enabled = false;
            this.Createtime.Location = new System.Drawing.Point(126, 409);
            this.Createtime.Name = "Createtime";
            this.Createtime.Size = new System.Drawing.Size(377, 23);
            this.Createtime.TabIndex = 19;
            // 
            // CreateUserID
            // 
            this.CreateUserID.Enabled = false;
            this.CreateUserID.Location = new System.Drawing.Point(126, 366);
            this.CreateUserID.Name = "CreateUserID";
            this.CreateUserID.Size = new System.Drawing.Size(377, 23);
            this.CreateUserID.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "创建人：";
            // 
            // 行政区域维护
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1049, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tools);
            this.Name = "行政区域维护";
            this.Text = "行政区域维护";
            this.Load += new System.EventHandler(this.行政区域维护_Load);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolEdit;
        private System.Windows.Forms.ToolStripButton toolDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolRef;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UpdateTime;
        private System.Windows.Forms.TextBox UpdateUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Createtime;
        private System.Windows.Forms.TextBox CreateUserID;
        private System.Windows.Forms.Label label10;
    }
}
