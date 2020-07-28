namespace SysDF.BaseForm
{
    partial class BsdrFormDJ
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
            this.gBFindWhere = new System.Windows.Forms.GroupBox();
            this.butFind = new System.Windows.Forms.Button();
            this.gdFindWhere = new FlexCell.Grid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPList = new System.Windows.Forms.TabPage();
            this.gBoxgdFindList = new System.Windows.Forms.GroupBox();
            this.gdFindList = new FlexCell.Grid();
            this.tabPMX = new System.Windows.Forms.TabPage();
            this.gBFindWhere.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPList.SuspendLayout();
            this.gBoxgdFindList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBFindWhere
            // 
            this.gBFindWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gBFindWhere.Controls.Add(this.butFind);
            this.gBFindWhere.Controls.Add(this.gdFindWhere);
            this.gBFindWhere.Location = new System.Drawing.Point(12, 40);
            this.gBFindWhere.Name = "gBFindWhere";
            this.gBFindWhere.Size = new System.Drawing.Size(283, 556);
            this.gBFindWhere.TabIndex = 7;
            this.gBFindWhere.TabStop = false;
            this.gBFindWhere.Text = "查询条件";
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(110, 24);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(98, 36);
            this.butFind.TabIndex = 2;
            this.butFind.Text = "查询";
            this.butFind.UseVisualStyleBackColor = true;
            // 
            // gdFindWhere
            // 
            this.gdFindWhere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdFindWhere.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gdFindWhere.CheckedImage = null;
            this.gdFindWhere.Cols = 2;
            this.gdFindWhere.DefaultFont = new System.Drawing.Font("宋体", 10.8F);
            this.gdFindWhere.DefaultRowHeight = ((short)(30));
            this.gdFindWhere.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gdFindWhere.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gdFindWhere.Location = new System.Drawing.Point(7, 67);
            this.gdFindWhere.Margin = new System.Windows.Forms.Padding(4);
            this.gdFindWhere.Name = "gdFindWhere";
            this.gdFindWhere.Rows = 10;
            this.gdFindWhere.Size = new System.Drawing.Size(269, 475);
            this.gdFindWhere.TabIndex = 1;
            this.gdFindWhere.UncheckedImage = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPList);
            this.tabControl1.Controls.Add(this.tabPMX);
            this.tabControl1.Location = new System.Drawing.Point(301, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 556);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPList
            // 
            this.tabPList.Controls.Add(this.gBoxgdFindList);
            this.tabPList.Location = new System.Drawing.Point(4, 24);
            this.tabPList.Name = "tabPList";
            this.tabPList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPList.Size = new System.Drawing.Size(693, 528);
            this.tabPList.TabIndex = 0;
            this.tabPList.Text = "列表";
            this.tabPList.UseVisualStyleBackColor = true;
            // 
            // gBoxgdFindList
            // 
            this.gBoxgdFindList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBoxgdFindList.Controls.Add(this.gdFindList);
            this.gBoxgdFindList.Location = new System.Drawing.Point(6, 6);
            this.gBoxgdFindList.Name = "gBoxgdFindList";
            this.gBoxgdFindList.Size = new System.Drawing.Size(681, 512);
            this.gBoxgdFindList.TabIndex = 1;
            this.gBoxgdFindList.TabStop = false;
            // 
            // gdFindList
            // 
            this.gdFindList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdFindList.CheckedImage = null;
            this.gdFindList.Cols = 2;
            this.gdFindList.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.gdFindList.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gdFindList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gdFindList.Location = new System.Drawing.Point(6, 22);
            this.gdFindList.Name = "gdFindList";
            this.gdFindList.Rows = 2;
            this.gdFindList.Size = new System.Drawing.Size(669, 484);
            this.gdFindList.TabIndex = 1;
            this.gdFindList.UncheckedImage = null;
            // 
            // tabPMX
            // 
            this.tabPMX.Location = new System.Drawing.Point(4, 24);
            this.tabPMX.Name = "tabPMX";
            this.tabPMX.Padding = new System.Windows.Forms.Padding(3);
            this.tabPMX.Size = new System.Drawing.Size(693, 528);
            this.tabPMX.TabIndex = 1;
            this.tabPMX.Text = "明细";
            this.tabPMX.UseVisualStyleBackColor = true;
            // 
            // BsdrFormDJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(1014, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gBFindWhere);
            this.Name = "BsdrFormDJ";
            this.Text = "BaseFormDJ";
            this.Load += new System.EventHandler(this.BsdrFormDJ_Load);
            this.gBFindWhere.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPList.ResumeLayout(false);
            this.gBoxgdFindList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gBFindWhere;
        public System.Windows.Forms.Button butFind;
        public FlexCell.Grid gdFindWhere;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPList;
        public System.Windows.Forms.TabPage tabPMX;
        public FlexCell.Grid gdFindList;
        public System.Windows.Forms.GroupBox gBoxgdFindList;
    }
}
