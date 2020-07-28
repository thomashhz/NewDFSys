using Hhz.SysDF.SysModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hhz.dbdata;

namespace SysDF.SysModule.SysModuleForm
{
    public partial class 系统功能维护 : SysDF.BaseForm.BaseForm
    {
        public 系统功能维护()
        {
            InitializeComponent();
        }
        private Boolean IsSaved = false;
        private void toolSetTrue(Boolean t)
        {
            toolAdd.Enabled = t;
            toolEdit.Enabled = t;
            toolDel.Enabled = t;


            toolSave.Enabled = !t;
            toolCancel.Enabled = !t;
            groupBox2.Enabled = !t;


        }
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void toolDel_Click(object sender, EventArgs e)
        {
            //删除
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            //保存
            var aft = new ActFormTree
            {

                ID = textBox1.Text.ToInt(),

                FormID = textBox2.Text.ToString(),
                parenID = textBox3.Tag.ToInt(),
                Pxnum = textBox4.Text.ToString(),
                UrlModle = textBox5.Text.ToString(),
                Sumarry = textBox6.Text.ToString()

            };
            aft.Save();   //保存

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

        private void 系统功能维护_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }

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

        }


        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string fID = e.Node.Name.ToString();
            //bool bnlnull = false;
            //ActFormTree aft = ActFormTree.FindAll(ActFormTree._.ID, fID);
            var aft = ActFormTree.FindAll(ActFormTree._.ID, fID);
            foreach (ActFormTree s in aft)
            {
                try
                {


                    if (!IsSaved)   //查询状态，显示菜单信息
                    {


                        try
                        {
                            textBox1.Text = s.ID.ToString();
                            textBox2.Text = s.FormID.ToString();
                            //bnlnull = e.Node.Parent.Text.ToString().IsNullOrEmpty();
                            if (e.Node.Parent == null)
                            {
                                textBox3.Text = "0";
                            }
                            else
                            {
                                textBox3.Text = s.parenID.ToString() + "|" + e.Node.Parent.Text.ToString();
                            }
                            textBox3.Tag = s.parenID.ToString();
                            textBox4.Text = s.Pxnum.ToString();
                            //bool aa = s.UrlModle.IsNullOrEmpty();
                            if (s.UrlModle == null)
                            {
                                textBox5.Text = "";
                            }
                            else
                            {
                                textBox5.Text = s.UrlModle.ToString();
                            }
                            if (s.Sumarry == null)
                            {
                                textBox6.Text = "";
                            }
                            else
                            {
                                textBox6.Text = s.Sumarry.ToString();
                            }


                        }
                        catch (Exception ex)
                        { MessageBox.Show("提示！" + ex); }  //(Exception ex) MessageBox.Show("提示！"+ex); 

                    }
                    else  //新增（==0） 修改（==ID） 给上级赋值
                    {
                        textBox3.Text = s.ID.ToString() + "|" + e.Node.Text.ToString();
                        textBox3.Tag = s.ID.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex, "提示！");
                }




            }
        }

        private void toolEdit_Click(object sender, EventArgs e)
        {
            //修改
            toolSetTrue(false);
            groupBox2.Text = "修改";
            groupBox2.Tag = textBox1.Text.ToString();
            IsSaved = true; //
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

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolRef_Click(object sender, EventArgs e)
        {
            InitTreeView();
        }

        private void toolExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolDel_Click_1(object sender, EventArgs e)
        {
            //删除订单
            if (textBox1.ToString().Trim() == "")
            {
                //请选定要删除的菜单
                MessageBox.Show("请选定要删除的菜单！", "提示！");
            }
            else
            {
                //判断是否有下级菜单

                Int32 parentID = textBox1.Text.ToInt();

                var acTree = ActFormTree.SearchPara(parentID);
                //int iYes = ActFormTree.FindMax(ActFormTree._.ID, ActFormTree._.parenID == parentID);

                if (acTree.Count > 0)
                //if (iYes==1)
                {
                    MessageBox.Show("此菜单有下级菜单，不允许删除！", "提示！");

                }
                else
                {
                    //删除菜单
                    if ((int)MessageBox.Show("确定删除此菜单，请按确定，否则取消", "提示!", MessageBoxButtons.OKCancel) == 1)
                    {
                        //删除
                        var iID = textBox1.Text.ToInt();
                        //ActFormTree.Delete(iID);

                        var actTr = ActFormTree.FindByKey(iID);
                        actTr.Delete();

                        MessageBox.Show("删除成功！", "提示！");
                    }
                }

            }
        }
    }
}