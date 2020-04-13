using Hhz.dbdata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hhz.SysDF.SysModule;

namespace SysDF._00基础模块
{
    public partial class 管理区域维护 : SysDF.BaseForm.BaseForm
    {
        public 管理区域维护()
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

        private void 管理区域维护_Load(object sender, EventArgs e)
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

            // AreaID,AreaName,PrevID
            sSql = "select AreaID,AreaName,PrevID from Area_new d  where isnull(d.PrevID,'')='" + parentID + "' order by d.AreaID ";

            DataSet ds = DbHelperSQL.Query(sSql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    try
                    {
                        TreeNode tn = new TreeNode();

                        tn.Name = ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim();   //rd["AreaID"].ToString();  d.AreaID
                        tn.Text = ds.Tables[0].Rows[i].ItemArray[1].ToString().Trim();   //   rd["AreaName"].ToString(); d.AreaName  AreaName
                        tn.Tag = ds.Tables[0].Rows[i].ItemArray[0].ToString().Trim();    //
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

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string fID = e.Node.Name.ToString();
            //TreeView1.Nodes

            //TreeNodeCollection atre = e.Node;
            //bool bnlnull = false;
            //ActFormTree aft = ActFormTree.FindAll(ActFormTree._.ID, fID);
            //var aft = AreaDistrictNew.FindAll(AreaDistrictNew._.Did, fID);
            var aft = AreaNew.SearchDid(fID, null);
            foreach (var s in aft)
            {
                try
                {


                    if (!IsSaved)   //查询状态，显示菜单信息
                    {


                        try
                        {
                            textBox0.Text = s.ID.ToString();
                            textBox1.Text = s.AreaID.ToString();
                            textBox2.Text = s.AreaName.ToString();

                            //bnlnull = e.Node.Parent.Text.ToString().IsNullOrEmpty();
                            if (e.Node.Parent == null)
                            {
                                textBox3.Text = "0";
                            }
                            else
                            {
                                textBox3.Text = s.AreaID.ToString() + "|" + e.Node.Parent.Text.ToString();
                                textBox3.Tag = s.PrevID.ToString();
                            }

                            

                            if (!s.CreateUserID.IsNullOrEmpty())
                            {
                                CreateUserID.Text = s.CreateUserID.ToString();
                                Createtime.Text = s.CreateTime.ToString();
                            }
                            else
                            {
                                CreateUserID.Text = "";
                                Createtime.Text = "";


                            }
                                                        
                                
                            if (!s.UpdateUserID.IsNullOrEmpty())
                            {
                                UpdateUserID.Text = s.UpdateUserID.ToString();
                                UpdateTime.Text = s.UpdateTime.ToString();
                            }
                            else
                            {
                                UpdateUserID.Text = "";
                                UpdateTime.Text = "";
                            }
                            
                            //bool aa = s.UrlModle.IsNullOrEmpty();



                        }
                        catch (Exception ex)
                        { MessageBox.Show("提示！" + ex); }  //(Exception ex) MessageBox.Show("提示！"+ex); 

                    }
                    else  //新增（==0） 修改（==ID） 给上级赋值
                    {
                        textBox3.Text = s.AreaID.ToString() + "|" + e.Node.Text.ToString();
                        textBox3.Tag = s.AreaID.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex, "提示！");
                }

            }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            //保存
            var atr = new AreaNew
            {
                ID = textBox0.Text.ToInt(),

                AreaID = textBox1.Text.ToString(),
                AreaName = textBox2.Text.ToString(),
                PrevID = textBox3.Tag.ToString(),

            };
            atr.Save();
            textBox0.Text = atr.AreaID.ToString();

            toolSetTrue(true);
            groupBox2.Text = "";
            groupBox2.Tag = "";
            IsSaved = false;
        }

        private void toolDel_Click(object sender, EventArgs e)
        {
            //删除，判断区域是否已使用，在inv_evi 单据的 areaid 字段
            //删除
            if (!IsSaved) //编辑状态
            {
                if (textBox1.Text.ToString() == "")
                {
                    MessageBox.Show("请选择要删除的区域");
                }
                else
                {
                    string sSql = "select top 1 id from inv_Evi where areaid='" + textBox1.Text.ToString() + "'";

                    int i = DbHelperSQL.ExecuteSql(sSql);
                    if (i > 0)
                    {
                        MessageBox.Show("区域已在单据inv_evi【订单】使用，不能删除!");
                    }
                    else
                    {
                        var atr = new AreaNew
                        {
                            ID = textBox0.Text.ToInt(),

                            AreaID = textBox1.Text.ToString(),
                            AreaName = textBox2.Text.ToString(),


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

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
