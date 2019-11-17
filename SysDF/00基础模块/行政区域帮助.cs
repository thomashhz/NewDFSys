using Hhz.dbdata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysDF._00基础模块
{
    public partial class 行政区域帮助 : Form
    {
        public 行政区域帮助()
        {
            InitializeComponent();
        }

        private void 行政区域帮助_Load(object sender, EventArgs e)
        {
            InitTreeView();
        }

        private void InitTreeView()
        {

            //tvTable为TreeView控件
            //tvTable.Nodes.Clear();
            treeView1.Nodes.Clear();
           
            CreateTreeView(treeView1.Nodes, string.Empty);
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

  

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //动态加载下级行政区域
            if (e.Node.Nodes.Count == 0)//下级为空，可以加载下级
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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Checked )
            {
                textBox1.Text = e.Node.Text.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //确定选择
        }
    }
}
