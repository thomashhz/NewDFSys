using Hhz.dbdata;
using SysDF._00基础模块;
using SysDF.SysModule.SysModuleForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SysDF
{
    public partial class zMainForm : Form
    {
        //private int childFormNumber = 0;
       

        private zMainFormMenu frmMenu = new zMainFormMenu();  //定义左靠菜单窗体form
        public zMainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 判断已打开的窗体
        /// </summary>
        /// <param name="formname"></param>
        /// <returns></returns>
        public bool CheckFormIsOpen(string formname)
        {
            bool remark = false;
            for (int a = 0; a < base.MdiChildren.Length; a++)
            {
                if (formname.Equals(base.MdiChildren[a].GetType().Namespace + "." + base.MdiChildren[a].GetType().Name))
                {
                    base.MdiChildren[a].Activate();
                    remark = true;
                }
            }
            return remark;
        }

        //反射通过命名空间.窗体名称，调用窗体  注：  formName 是带有命名空间的例如： 修改密码的窗体是在 BaseFrom 空间，则formName=BaseFrom.修改密码
        public void OpenChildForm(string formName)
        {
            Type t = Type.GetType(formName);
            Assembly asm = Assembly.GetExecutingAssembly();
            //DockContent frm = asm.CreateInstance(formName) as DockContent;
            //if (frm != null)
            //{
            //    frm.Show(this.dockPanel1);
            //}
            if (asm.CreateInstance(formName) is DockContent frm)
            {
                frm.Show(this.dockPanel1);
            }


        }

      

        private void OpenFile(object sender, EventArgs e)
        {
            frmMenu.Show();
            frmMenu.InitTreeView();

            //frmMenu.Show(this.dockPanel1, DockState.DockLeft);

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            //if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = openFileDialog.FileName;
            //}
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void zMainForm_Load(object sender, EventArgs e)
        {

            //初始化登录用户

            zLoginForm logfrm = new zLoginForm();
            logfrm.ShowDialog(this.dockPanel1);

            //logfrm.Show(this.dockPanel1);
            //PubFunVar.LoginUserID = "admin";   // "admin";  // "231";   //
            //PubFunVar.LoginUserName = "admin"; // "admin";  // "梁飞源"; //

            //如果登陆成功，通过定时器加载导航窗体：by 2019.1107 hhz
            ////加载定义的左靠菜单窗体form
            //if (PubFunVar.LoginTrue)
            //{
            //    //登录成功


            //    this.toolStripStatusLabel1.Text = PubFunVar.LoginUserID.ToString();
            //    this.toolStripStatusLabel2.Text = PubFunVar.LoginUserName.ToString();

            //    frmMenu.P_fm = this;

            //    //frmMenu.Show(this.dockPanel1);

            //    frmMenu.Show(this.dockPanel1, DockState.DockLeft);
            //}
            //else
            //{
            //    //this.Close();
            //}

        }

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        private void zMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改密码 frmpw = new 修改密码();
            frmpw.Show(dockPanel1);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(PubFunVar.LoginTrue)
            {
                timer1.Enabled = false;
                    ////加载定义的左靠菜单窗体form
                
                    //登录成功

                    this.toolStripStatusLabel1.Text = PubFunVar.LoginUserID.ToString();
                    this.toolStripStatusLabel2.Text = PubFunVar.LoginUserName.ToString();

                    frmMenu.P_fm = this;

                    //frmMenu.Show(this.dockPanel1);

                    frmMenu.Show(this.dockPanel1, DockState.DockLeft);
                
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            行政区域帮助 frmArea = new 行政区域帮助();

            frmArea.ShowDialog();


        }
    }
}
