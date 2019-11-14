using Hhz.dbdata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SysDF
{
    public partial class zMainFormMenu :DockContent  // : Form
    {
        private zMainForm fm;
        public zMainForm P_fm
        {
            get { return fm; }
            set { fm = value; }
        }

        public zMainFormMenu()
        {
            InitializeComponent();
            //this.ControlBox = false;   // 设置不出现关闭按钮
        }
        //private const int CP_NOCLOSE_BUTTON = 0x200;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}

        private void zMainFormMenu_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }
        public void InitTreeView()
        {

            //tvTable为TreeView控件
            //tvTable.Nodes.Clear();
            treeView1.Nodes.Clear();
            //TreeNode tn = new TreeNode();
            //tn.Name = "0";
            //tn.Text = "系统功能";
            //TreeView1.Nodes.Add(tn);
            //获取父节点，父节点
            //CreateTreeView(tvTable.Nodes, string.Empty);
            CreateTreeView(treeView1.Nodes, string.Empty);
            //CreateTreeView(TreeView1.Nodes, "6");

        }
        private void CreateTreeView(TreeNodeCollection nodes, string parentID)
        {
            string sSql = " ";
            //判断--如果是管理员权限，则加载所有功能
            if(PubFunVar.LoginUserName.ToString().Trim()=="admin")
            {
                sSql = " select id,formid,urlmodle,t.parenid  from ActFormTree t where isnull(t.parenid,'')='" + parentID + "' order by t.pxnum ";
            }
            else
            {
                //sSql = " select id,formid,urlmodle,t.parenid  from ActFormTree t where isnull(t.parenid,'')='" + parentID + "' order by t.pxnum ";

                sSql = " select t.id,t.formid,t.urlmodle,t.parenid ";
                sSql += " from ( ";
                sSql += " select t.id, t.formid, t.urlmodle, t.parenID, t.pxnum ";
                sSql += " , r.UserID, r.FormName, r.Browsed, r.Added, r.Moded, r.Deled, r.Printed, r.Verify, r.Mastered ";
                sSql += " from ActFormTree t left join ActRel r on t.FormID = r.FormName ";
                sSql += " where isnull(t.parenid, '') = '0' ";
                sSql += " and exists(select 1 from ActRel r1 left join ActFormTree t1 on r1.FormName = t1.FormName ";
                sSql += "            where r1.UserID = '" + PubFunVar.LoginUserID.ToString().Trim() + "' and r1.Browsed = '1' and t1.parenID = t.ID) ";
                sSql += " union all ";
                sSql += " select t.ID, t.FormID, t.UrlModle, t.parenID, t.pxnum ";
                sSql += " , r.UserID, r.FormName, r.Browsed, r.Added, r.Moded, r.Deled, r.Printed, r.Verify, r.Mastered ";
                sSql += " from ActRel r left join ActFormTree t on r.FormName = t.FormName ";
                sSql += " where r.UserID = '" + PubFunVar.LoginUserID.ToString().Trim() + "' and r.Browsed = '1' ";
                sSql += " ) t ";
                sSql += " where isnull(t.parenid,'')= '" + parentID + "' order by t.pxnum ";

            }
            
            DataSet ds = DbHelperSQL.Query(sSql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        TreeNode tn = new TreeNode();

                        tn.Name = ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim();   //rd["ID"].ToString();
                        tn.Text = ds.Tables[0].Rows[i].ItemArray[1].ToString().Trim();   //   rd["formid"].ToString();
                        tn.Tag = ds.Tables[0].Rows[i].ItemArray[2].ToString().Trim();    //rd["urlmodle"].ToString();
                        nodes.Add(tn);

                        //tn.Expand();

                        //递归生成一个节点下所有的子节点。
                        CreateTreeView(tn.Nodes, ds.Tables[0].Rows[i].ItemArray[0].ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("提示！:" + ex);
                    }

                }

            }
          

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                //FormSub:
                //在需要对其调用者（父）刷新时

                if (this.treeView1.SelectedNode.Text != null)
                {
                    if (this.treeView1.SelectedNode.Tag.ToString().Trim() != "")
                    {
                        string formname = this.treeView1.SelectedNode.Tag.ToString();
                        if (!fm.CheckFormIsOpen(formname))
                        {
                            fm.OpenChildForm(formname);
                        }

                    }
                }
                fm.Text =  this.treeView1.SelectedNode.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开窗体信息:" + ex);
            }
            //    try
            //    {
            //        if (this.TreeView1.SelectedIndices.Count > 0)
            //        {
            //            //反射动态实例化窗口
            //            object FrmWindow = this.TreeView1.SelectedItems[0].Tag;
            //            object MenuID = this.listView1.SelectedItems[0].Name;
            //            if (CheckFormIsOpen(FrmWindow.ToString()))
            //            {
            //                //DockContent doc = (DockContent)Assembly.Load("YX").CreateInstance("YX." + FrmWindow);
            //                //doc.Show(_frmMain.dockPanel1, DockState.Document);

            //                Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集                   
            //                object[] parameters = new object[1];
            //                parameters[0] = MenuID;
            //                DockContent obj = (DockContent)assembly.CreateInstance("YX." + FrmWindow, true, System.Reflection.BindingFlags.Default, null, parameters, null, null);// 创建类的实例 
            //                obj.Show(TestMdi2015);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show("还没有配置:"+ ex);
            //    }

            //    //---------------------
            //    //作者：Sam萨姆
            //    //来源：CSDN
            //    //原文：https://blog.csdn.net/zzzzzzzert/article/details/87875374 
            //    //版权声明：本文为博主原创文章，转载请附上博文链接！
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
                //if (e.KeyChar == (char)Keys.Enter)
                //{
                //    SendKeys.Send("{tab}");
                //}
            
        }
    }
}
