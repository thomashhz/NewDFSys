using Hhz.SysDF.SysModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysDF.SysModule.SysModuleForm
{
    public partial class 权限设置 : SysDF.BaseForm.BaseForm
    {
        public 权限设置()
        {
            InitializeComponent();
        }

        public Boolean IsSaved = false;
        //设置标志，防止死循环
        bool check = false;
        //设置子节点状态
        private void setchild(TreeNode node)
        {
            foreach (TreeNode child in node.Nodes)
            {
                child.Checked = node.Checked;
            }
            check = true;
        }

        //设置父节点状态
        private void setparent(TreeNode node)
        {
            //if (node.Parent != null)
            //{
            //    //如果当前节点状态为勾选，则需要所有兄弟节点都勾选才能勾选父节点
            //    if (node.Checked)
            //        foreach (TreeNode brother in node.Parent.Nodes)
            //        {
            //            if (brother.Checked == false)
            //                return;
            //        }
            //    node.Parent.Checked = node.Checked;
            //}



            if (node.Parent != null)
            {
                //如果当前节点状态为 不勾选，则需要所有兄弟节点都不勾选才能不勾选父节点
                if (!node.Checked)
                    foreach (TreeNode brother in node.Parent.Nodes)
                    {
                        if (brother.Checked == true)
                            return;
                    }
                node.Parent.Checked = node.Checked;

            }
        }

        private void toolSetTrue(Boolean t)
        {
            toolAdd.Enabled = t;
            toolEdit.Enabled = t;
            toolDel.Enabled = t;


            toolSave.Enabled = !t;
            toolCancel.Enabled = !t;

        }
        /// <summary>
        /// 初始化TreeView控件
        /// </summary>
        private void InitTreeView()
        {
            TreeView1.Nodes.Clear();

            CreateTreeView(TreeView1.Nodes, "0");

        }

        private void CreateTreeView(TreeNodeCollection nodes, string parentID)
        {

            //var userList = UserInfo.FindAll(UserInfo._.UserName == "张三" & UserInfo._.Age == 19, UserInfo._.UserName.Desc(), string.Join(",", UserInfo._.UserName, UserInfo._.Age), 0, 0);
            // 相当于Select UserName,Age From UserInfo Where UserName='张三' And Age=19 Order By  UserName desc

            //根据用户名称查询
            //var userList = UserInfo.FindAll(UserInfo._.UserName, "张三");

            var acTree = ActFormTree.FindAll(ActFormTree._.parenID == parentID, ActFormTree._.Pxnum, string.Join(",", ActFormTree._.ID, ActFormTree._.FormID, ActFormTree._.UrlModle, ActFormTree._.parenID), 0, 0);
            //var acTree1 = ActFormTree.FindAll(ActFormTree._.parenID,parentID);

            //ArrayList al = TableDictionaryDao.GetDataByParentID(parentID);
            //foreach (MTableDictionary tableDic in al)
            //            if (ds.Tables[0].Rows.Count > 0)
            if (acTree.Count > 0)
            {

                foreach (ActFormTree s in acTree)
                {

                    try
                    {
                        TreeNode tn = new TreeNode();
                        //string aa =acTree1.GetEnumerator(1);

                        tn.Name = s.ID.ToString();      // ds.Tables[0].Rows[i].ItemArray[0].ToString();   //rd["ID"].ToString();
                        tn.Text = s.FormID.ToString();     // ds.Tables[0].Rows[i].ItemArray[1].ToString();   //   rd["formid"].ToString();
                        if (s.UrlModle.IsNullOrEmpty())
                        {
                            tn.Tag = "";   // ds.Tables[0].Rows[i].ItemArray[2].ToString();    //rd["urlmodle"].ToString();
                        }
                        else
                        {
                            tn.Tag = s.UrlModle.ToString();   // ds.Tables[0].Rows[i].ItemArray[2].ToString();    //rd["urlmodle"].ToString();
                        }

                        nodes.Add(tn);

                        tn.Expand();

                        //递归生成一个节点下所有的子节点。
                        CreateTreeView(tn.Nodes, s.ID.ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("提示！:" + ex);
                    }

                }

            }
            else   //末级
            {
                string[] qxSet = new string[] { "查询", "新增", "修改", "删除", "审核", "打印" };
                for (int i = 0; i < 6; i++)
                {

                    try
                    {
                        TreeNode tn = new TreeNode();
                        //string aa =acTree1.GetEnumerator(1);

                        tn.Name = i.ToString();      // ds.Tables[0].Rows[i].ItemArray[0].ToString();   //rd["ID"].ToString();
                        tn.Text = qxSet[i].ToString();  //string[] qxSet = new string[] { "查询", "新增", "修改", "删除", "审核", "打印" };

                        nodes.Add(tn);

                        tn.Expand();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("提示！:" + ex);
                    }
                }
            }


        }


        private void IniGrid1()
        {
            grid1.Cell(0, 0).Text = "序号";
            grid1.Column(0).Width = 40;

            grid1.Cell(0, 1).Text = "用户ID";
            grid1.Column(1).Width = 50;

            grid1.Cell(0, 2).Text = "用户账号";
            grid1.Column(2).Width = 80;

            grid1.Cell(0, 3).Text = "用户名称";
            grid1.Column(3).Width = 100;

            grid1.Cell(0, 4).Text = "用户部门";
            grid1.Column(4).Width = 100;

            grid1.Cell(0, 5).Text = "用户状态";
            grid1.Column(5).Width = 60;

            var au = ActUser.FindAll();
            Int32 ir = 1;

            if (au.Count > 0)
            {
                grid1.Rows = ir;

                foreach (ActUser u in au)
                {
                    if (u.isStop == 0)
                    {
                        ir += 1;
                        grid1.Rows = ir;
                        try
                        {
                            grid1.Cell(ir - 1, 1).Text = u.id.ToString();
                            grid1.Cell(ir - 1, 2).Text = u.UserID.ToString();
                            grid1.Cell(ir - 1, 3).Text = u.UserName.ToString();
                            grid1.Cell(ir - 1, 4).Text = u.Detp.ToString();
                            grid1.Cell(ir - 1, 5).Text = u.isStop.ToString();

                        }
                        catch { }
                    }


                }

            }



        }

        private void 权限设置_Load(object sender, EventArgs e)
        {
            IniGrid1();
            InitTreeView();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            //新增
            toolSetTrue(false);
            groupBox2.Text = "新增";
            groupBox2.Tag = "0";
            IsSaved = true;
            foreach (Control control in this.groupBox2.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void toolEdit_Click(object sender, EventArgs e)
        {
            //修改
            toolSetTrue(false);
            groupBox2.Text = "修改";
            //groupBox2.Tag = textBox1.Text.ToString();
            IsSaved = true; //
        }

        private void toolDel_Click(object sender, EventArgs e)
        {

        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            //保存

            SavTreeViewQX();
            toolSetTrue(true);
            groupBox2.Text = "";
            groupBox2.Tag = "";
            IsSaved = false;


        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            //取消
            toolSetTrue(true);
            IsSaved = false;
        }

        private void grid1_Load(object sender, EventArgs e)
        {

        }

        private void ViewUserQX(TreeNode tn, Boolean[] bqx,string mName)
        {
            //递归循环
            //1.nName菜单功能名称 bqx数组保存的是nName的权限
            if (tn.Text.ToString()==mName.ToString ())
            {
                //找到用户授权的菜单，显示授权，退出
                //最后一级菜单
                //mID = TreeView1.Nodes[i].Name.ToInt();   //菜单ID
                for (int j = 0; j < tn.Nodes.Count; j++)
                {
                    if (j < 6)  //{ "查询", "新增", "修改", "删除", "审核", "打印" };
                    {
                        //超过6个选项修改 j<6 及 selqx   qxSet  数组
                        //if (TreeView1.Nodes[i].Nodes[j].Checked)
                        //{
                        //selqx[j] = TreeView1.Nodes[i].Nodes[j].Checked;
                        tn.Nodes[j].Checked = bqx[j];
                        //}

                    }
                }

            }
            else
            {
                //没找到用户授权的菜单，继续查找
                foreach (TreeNode tnSub in tn.Nodes)
                {
                    ViewUserQX(tnSub, bqx, mName);
                }
            }

            
        }

        private void ViewUserQXIni(TreeNode tn)
        {
            //1.初始化，递归循环
            tn.Checked = false;
                //没找到用户授权的菜单，继续查找
                foreach (TreeNode tnSub in tn.Nodes)
                {
                ViewUserQXIni(tnSub);
                }
            

        }

        private void grid1_EnterRow(object Sender, FlexCell.Grid.EnterRowEventArgs e)
        {
            grid1.Enabled = false;

            int ir = grid1.ActiveCell.Row.ToInt();
            if(UserID.Text.ToString()  != grid1.Cell(ir, 2).Text.ToString())
            {
                //初始化，并显示权限
                foreach (TreeNode tnSub in TreeView1.Nodes)
                {
                    //初始化
                    ViewUserQXIni(tnSub);
                }

                UserID.Text = grid1.Cell(ir, 2).Text.ToString().Trim();
                UserName.Text = grid1.Cell(ir, 3).Text.ToString().Trim();

                string SQL = "select * from ActRel where UserID='" + UserID.Text.ToString().Trim() + "' and Browsed=1";

                SqlDataReader RD = Hhz.dbdata.DbHelperSQL.ExecuteReader(SQL);
                string a1 = "";
                //string a2 = "";// RD[3].ToString();
                Boolean[] selqx = new Boolean[] { false, false, false, false, false, false };

                while (RD.Read())
                {
                    a1 = RD[3].ToString();
                    for (int i = 0; i < 6; i++)
                    {
                        selqx[i] = RD[i + 6].ToBoolean();
                    }
                    //遍历treeview
                    foreach (TreeNode tnSub in TreeView1.Nodes)
                    {
                        ViewUserQX(tnSub, selqx, a1);
                    }
                }
            }


            grid1.Enabled = true;

        }


        private void TreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (check == false)
                setchild(e.Node);
            setparent(e.Node);
            check = false;
        }

        private void SavTreeViewQX()
        {
            //保存权限
            if(UserID.Text.ToString().Trim()!="")
            {
                string strUserID = UserID.Text.ToString().Trim();
                string strnode1 = "";
                string strnode2 = "";
                //遍历treeview 然后保存
                foreach (TreeNode tnSub in TreeView1.Nodes)
                {
                    strnode1=tnSub.Text.ToString().Trim();
                    strnode2 = tnSub.Nodes[0].Text.ToString().Trim();
                    if (tnSub.Checked==true )//找到最后一级的功能权限
                    {
                        SaveViewUserQX(tnSub, strUserID);
                    }
                        
                }

            }
            else
            {
                //用户为空，退出保存
            }

        }

        private void SaveViewUserQX(TreeNode tn,  string sUserID)
        {
            //递归循环  Boolean[] bqx,
            //1.nName菜单功能名称 bqx数组保存的是nName的权限
            string StrNode = tn.Text.ToString().Trim();
            Int32 IntNodesC = tn.Nodes.Count;
            string StrParentname = "";//节点名称，看不到的
            string StrParenttext = "";//节点文本，就是看到的
            Boolean blnSaveQX = false;                

            if (tn.Parent != null)
            {
                 StrParentname = tn.Parent.Name;//节点名称，看不到的
                 StrParenttext = tn.Parent.Text;//节点文本，就是看到的
                blnSaveQX = tn.Checked;
            }            

                if (IntNodesC == 0 && blnSaveQX == true)//找到最后一级的功能权限
                {
                    //找到授权用户的菜单末级，//最后一级菜单
                    
                    //mID = TreeView1.Nodes[i].Name.ToInt();   //菜单ID
                    //Boolean[] bqx = new Boolean[] { false, false, false, false, false, false };
                    string sSql = "";
                    string blnBqx = "0";
                    if (tn.Checked)  //判断权限
                    {
                        blnBqx = "1";
                    }
                    else
                    {
                        blnBqx = "0";
                    }

                    try
                    {
                    //{ "查询", "新增", "修改", "删除", "审核", "打印" }; ,browsed,added,moded,deled,verify,printed

                    //保存权限

                    if (StrNode == "查询") 
                    {
                        //{ "查询", "新增", "修改", "删除", "审核", "打印" }; ,browsed,added,moded,deled,verify,printed
                        sSql = " update ActRel set browsed='"+ blnBqx.ToString().Trim()+ "' ";
                        sSql += " where userid='"+sUserID.ToString().Trim()+ "' and formname='" + StrParenttext.ToString().Trim() + "'";
                        if(Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql)<=0)
                        {
                            //执行更新语句返回0或小于0 ，则作插入操作
                            sSql = "insert into ActRel (userid,formname,accid,accyear,browsed) value (";
                            sSql += "'" + sUserID.ToString().Trim() + "' ";  //用户ＩＤ
                            sSql += ",'" + StrParenttext.ToString().Trim() + "'";  //菜单名称
                            sSql += ",'100','2009' ";
                            sSql += ",'" + blnBqx.ToString().Trim() + "'";   //查询
                            //sSql += ",'" + bqx[1] + "'";   //新增
                            //sSql += ",'" + bqx[2] + "'";   //修改
                            //sSql += ",'" + bqx[3] + "'";   //删除
                            //sSql += ",'" + bqx[4] + "'";   //审核
                            //sSql += ",'" + bqx[5] + "'";   //打印

                            sSql += " )";
                            Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql);

                        }
                    }
                    if (StrNode == "新增") 
                    {
                        //{ "查询", "新增", "修改", "删除", "审核", "打印" }; ,browsed,added,moded,deled,verify,printed
                        sSql = " update ActRel set added='" + blnBqx.ToString().Trim() + "' ";
                        sSql += " where userid='" + sUserID.ToString().Trim() + "' and formname='" + StrParenttext.ToString().Trim() + "'";
                        if (Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql) <= 0)
                        {
                            //执行更新语句返回0或小于0 ，则作插入操作
                            sSql = "insert into ActRel (userid,formname,accid,accyear,added) value (";
                            sSql += "'" + sUserID.ToString().Trim() + "' ";  //用户ＩＤ
                            sSql += ",'" + StrParenttext.ToString().Trim() + "'";  //菜单名称
                            sSql += ",'100','2009' ";
                            sSql += ",'" + blnBqx.ToString().Trim() + "'";   //查询
                            //sSql += ",'" + bqx[1] + "'";   //新增
                            //sSql += ",'" + bqx[2] + "'";   //修改
                            //sSql += ",'" + bqx[3] + "'";   //删除
                            //sSql += ",'" + bqx[4] + "'";   //审核
                            //sSql += ",'" + bqx[5] + "'";   //打印

                            sSql += " )";
                            Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql);

                        }
                    }
                    if (StrNode == "修改")
                    {
                        //{ "查询", "新增", "修改", "删除", "审核", "打印" }; ,browsed,added,moded,deled,verify,printed
                        sSql = " update ActRel set moded='" + blnBqx.ToString().Trim() + "' ";
                        sSql += " where userid='" + sUserID.ToString().Trim() + "' and formname='" + StrParenttext.ToString().Trim() + "'";
                        if (Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql) <= 0)
                        {
                            //执行更新语句返回0或小于0 ，则作插入操作
                            sSql = "insert into ActRel (userid,formname,accid,accyear,moded) value (";
                            sSql += "'" + sUserID.ToString().Trim() + "' ";  //用户ＩＤ
                            sSql += ",'" + StrParenttext.ToString().Trim() + "'";  //菜单名称
                            sSql += ",'100','2009' ";
                            sSql += ",'" + blnBqx.ToString().Trim() + "'";   //查询
                            //sSql += ",'" + bqx[1] + "'";   //新增
                            //sSql += ",'" + bqx[2] + "'";   //修改
                            //sSql += ",'" + bqx[3] + "'";   //删除
                            //sSql += ",'" + bqx[4] + "'";   //审核
                            //sSql += ",'" + bqx[5] + "'";   //打印

                            sSql += " )";
                            Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql);

                        }
                    }
                    if (StrNode == "删除")
                    {
                        //{ "查询", "新增", "修改", "删除", "审核", "打印" }; ,browsed,added,moded,deled,verify,printed
                        sSql = " update ActRel set deled='" + blnBqx.ToString().Trim() + "' ";
                        sSql += " where userid='" + sUserID.ToString().Trim() + "' and formname='" + StrParenttext.ToString().Trim() + "'";
                        if (Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql) <= 0)
                        {
                            //执行更新语句返回0或小于0 ，则作插入操作
                            sSql = "insert into ActRel (userid,formname,accid,accyear,deled) value (";
                            sSql += "'" + sUserID.ToString().Trim() + "' ";  //用户ＩＤ
                            sSql += ",'" + StrParenttext.ToString().Trim() + "'";  //菜单名称
                            sSql += ",'100','2009' ";
                            sSql += ",'" + blnBqx.ToString().Trim() + "'";   //查询
                            //sSql += ",'" + bqx[1] + "'";   //新增
                            //sSql += ",'" + bqx[2] + "'";   //修改
                            //sSql += ",'" + bqx[3] + "'";   //删除
                            //sSql += ",'" + bqx[4] + "'";   //审核
                            //sSql += ",'" + bqx[5] + "'";   //打印

                            sSql += " )";
                            Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql);

                        }
                    }
                    if (StrNode == "审核")
                    {
                        //{ "查询", "新增", "修改", "删除", "审核", "打印" }; ,browsed,added,moded,deled,verify,printed
                        sSql = " update ActRel set verify='" + blnBqx.ToString().Trim() + "' ";
                        sSql += " where userid='" + sUserID.ToString().Trim() + "' and formname='" + StrParenttext.ToString().Trim() + "'";
                        if (Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql) <= 0)
                        {
                            //执行更新语句返回0或小于0 ，则作插入操作
                            sSql = "insert into ActRel (userid,formname,accid,accyear,verify) value (";
                            sSql += "'" + sUserID.ToString().Trim() + "' ";  //用户ＩＤ
                            sSql += ",'" + StrParenttext.ToString().Trim() + "'";  //菜单名称
                            sSql += ",'100','2009' ";
                            sSql += ",'" + blnBqx.ToString().Trim() + "'";   //查询
                            //sSql += ",'" + bqx[1] + "'";   //新增
                            //sSql += ",'" + bqx[2] + "'";   //修改
                            //sSql += ",'" + bqx[3] + "'";   //删除
                            //sSql += ",'" + bqx[4] + "'";   //审核
                            //sSql += ",'" + bqx[5] + "'";   //打印

                            sSql += " )";
                            Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql);

                        }
                    }
                    if (StrNode == "打印")
                    {
                        //{ "查询", "新增", "修改", "删除", "审核", "打印" }; ,browsed,added,moded,deled,verify,printed
                        sSql = " update ActRel set printed='" + blnBqx.ToString().Trim() + "' ";
                        sSql += " where userid='" + sUserID.ToString().Trim() + "' and formname='" + StrParenttext.ToString().Trim() + "'";
                        if (Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql) <= 0)
                        {
                            //执行更新语句返回0或小于0 ，则作插入操作
                            sSql = "insert into ActRel (userid,formname,accid,accyear,printed) value (";
                            sSql += "'" + sUserID.ToString().Trim() + "' ";  //用户ＩＤ
                            sSql += ",'" + StrParenttext.ToString().Trim() + "'";  //菜单名称
                            sSql += ",'100','2009' ";
                            sSql += ",'" + blnBqx.ToString().Trim() + "'";   //查询
                            //sSql += ",'" + bqx[1] + "'";   //新增
                            //sSql += ",'" + bqx[2] + "'";   //修改
                            //sSql += ",'" + bqx[3] + "'";   //删除
                            //sSql += ",'" + bqx[4] + "'";   //审核
                            //sSql += ",'" + bqx[5] + "'";   //打印

                            sSql += " )";
                            Hhz.dbdata.DbHelperSQL.ExecuteSql(sSql);

                        }
                    }

                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("提示！:" + ex);
                    }


                }
                else
                {
                    //没找到用户授权的菜单，继续查找
                    foreach (TreeNode tnSub in tn.Nodes)
                    {
                        SaveViewUserQX(tnSub, sUserID);
                    }
                }
            
            


        }

    }
}
