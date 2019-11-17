using Hhz.dbdata;
using Hhz.SysDF.SysModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysDF._00基础模块
{
    public partial class 行政区域维护 : SysDF.BaseForm.BaseForm
    {
        public 行政区域维护()
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

        private void 行政区域维护_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }
        private void InitTreeView()
        {

            //tvTable为TreeView控件
            //tvTable.Nodes.Clear();
            TreeView1.Nodes.Clear();

            CreateTreeView(TreeView1.Nodes, string.Empty);
            //CreateTreeView(TreeView1.Nodes, "6");

        }
        private void CreateTreeView(TreeNodeCollection nodes, string parentID)
        {
            string sSql = " ";

            //
            sSql = "select d.did,d.dName,d.Layer,d.PrevID from Area_District_New d  where d.Layer<4 and  isnull(d.PrevID,'')='" + parentID + "' order by d.did ";

            DataSet ds = DbHelperSQL.Query(sSql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        TreeNode tn = new TreeNode();

                        tn.Name = ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim();   //rd["did"].ToString();  d.did
                        tn.Text = ds.Tables[0].Rows[i].ItemArray[1].ToString().Trim();   //   rd["dName"].ToString(); d.dName
                        tn.Tag = ds.Tables[0].Rows[i].ItemArray[2].ToString().Trim();    //rd["Layer"].ToString();  层级
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

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolEdit_Click(object sender, EventArgs e)
        {
            //修改
            toolSetTrue(false);
            groupBox2.Text = "修改";
            groupBox2.Tag = textBox1.Text.ToString();
            IsSaved = true; //
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            //取消
            toolSetTrue(true);
            IsSaved = false;
        }

        private void toolRef_Click(object sender, EventArgs e)
        {
            InitTreeView();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            //保存
            var atr = new AreaDistrictNew
            {
                ID = textBox0.Text.ToInt(),

                Did = textBox1.Text.ToString(),
                Dname = textBox2.Text.ToString(),
                PrevID = textBox3.Tag.ToString(),
                Pxno = textBox4.Text.ToString(),
                Dname2 = textBox5.Text.ToString()
                
            };
            atr.Save();
            textBox0.Text = atr.ID.ToString();

            toolSetTrue(true);
            groupBox2.Text = "";
            groupBox2.Tag = "";
            IsSaved = false;
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string fID = e.Node.Name.ToString();
            //TreeView1.Nodes

            //TreeNodeCollection atre = e.Node;
            //bool bnlnull = false;
            //ActFormTree aft = ActFormTree.FindAll(ActFormTree._.ID, fID);
            //var aft = AreaDistrictNew.FindAll(AreaDistrictNew._.Did, fID);
            //var aft = Area_District_New.SearchDid(fID, null,null);
            var aft = AreaDistrictNew.FindBydID(fID);   // FindBydID
            if(aft.ID>0)   //foreach (var s in aft)
            {
                try
                {


                    if (!IsSaved)   //查询状态，显示菜单信息
                    {


                        try
                        {
                            textBox0.Text = aft.ID.ToString();
                            textBox1.Text = aft.Did.ToString();
                            textBox2.Text = aft.Dname.ToString();

                            //bnlnull = e.Node.Parent.Text.ToString().IsNullOrEmpty();
                            if (e.Node.Parent == null)
                            {
                                textBox3.Text = "0";
                            }
                            else
                            {
                                textBox3.Text = aft.Did.ToString() + "|" + e.Node.Parent.Text.ToString();
                            }
                            textBox3.Tag = aft.PrevID.ToString();
                            if(!aft.Pxno.IsNullOrEmpty())
                            {
                                textBox4.Text = aft.Pxno.ToString();
                            }
                            else
                            {
                                textBox4.Text = "";
                            }
                            
                            if(!aft.Dname2.IsNullOrEmpty())
                            {
                                textBox5.Text = aft.Dname2.ToString();
                            }
                            else
                            {
                                textBox5.Text ="";
                            }
                            //bool aa = s.UrlModle.IsNullOrEmpty();

                            if (!aft.CreateUserID.IsNullOrEmpty())
                            {
                                CreateUserID.Text = aft.CreateUserID.ToString();
                                Createtime.Text = aft.CreateTime.ToString();
                            }
                            else
                            {
                                CreateUserID.Text = "";
                                Createtime.Text = "";


                            }


                            if (!aft.UpdateUserID.IsNullOrEmpty())
                            {
                                UpdateUserID.Text = aft.UpdateUserID.ToString();
                                UpdateTime.Text = aft.UpdateTime.ToString();
                            }
                            else
                            {
                                UpdateUserID.Text = "";
                                UpdateTime.Text = "";
                            }

                        }
                        catch (Exception ex)
                        { MessageBox.Show("提示！" + ex); }  //(Exception ex) MessageBox.Show("提示！"+ex); 

                    }
                    else  //新增（==0） 修改（==ID） 给上级赋值
                    {
                        textBox3.Text = aft.ID.ToString() + "|" + e.Node.Text.ToString();
                        textBox3.Tag = aft.ID.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex, "提示！");
                }

            }
        }

        private void toolDel_Click(object sender, EventArgs e)
        {
            //删除
            if (!IsSaved) //编辑状态
            {
                if (textBox1.Text.ToString() == "")
                {
                    MessageBox.Show("请选择要删除的区域");
                }
                else
                {
                    string sSql = "select top 1 id from customer where cityid='" + textBox1.Text.ToString() + "'";

                    int i = DbHelperSQL.ExecuteSql(sSql);
                    if (i > 0)
                    {
                        MessageBox.Show("区域已在单据customer[客户档案]使用，不能删除!");
                    }
                    else
                    {
                        var atr = new AreaDistrictNew
                        {
                            ID = textBox0.Text.ToInt(),

                            Did = textBox1.Text.ToString(),
                            Dname = textBox2.Text.ToString(),
                        };
                        atr.Delete();
                        MessageBox.Show("删除成功！");
                    }
                }


            }//编辑状态
            else
            {
                MessageBox.Show("编辑状态不允许删除");
            }

        }



        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //动态加载下级行政区域
            if(e.Node.Nodes.Count==0)//下级为空，可以加载下级
            {
                //TreeNode tn = new TreeNode();
                CreateTreeViewNexNode(e.Node.Nodes, e.Node.Name);
            }
           
        }
        private void CreateTreeViewNexNode(TreeNodeCollection nodes, string parentID)
        {
            string sSql = " ";

            //
            sSql = "select d.did,d.dName,d.Layer,d.PrevID from Area_District_New d  where  isnull(d.PrevID,'')='" + parentID + "' order by d.did ";

            DataSet ds = DbHelperSQL.Query(sSql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        TreeNode tn = new TreeNode();

                        tn.Name = ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim();   //rd["did"].ToString();  d.did
                        tn.Text = ds.Tables[0].Rows[i].ItemArray[1].ToString().Trim();   //   rd["dName"].ToString(); d.dName
                        tn.Tag = ds.Tables[0].Rows[i].ItemArray[2].ToString().Trim();    //rd["Layer"].ToString();  层级
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
    }
}
