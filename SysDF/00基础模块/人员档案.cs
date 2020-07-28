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
    public partial class 人员档案 : SysDF.BaseForm.BaseForm
    {
        public 人员档案()
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
        private void 人员档案_Load(object sender, EventArgs e)
        {
            IniGrid1();
        }
        private void IniGrid1()
        {

            grid1.Cell(0, 0).Text = "序号";
            grid1.Column(0).Width = 40;

            grid1.Cell(0, 1).Text = "ID";
            grid1.Column(1).Width = 50;
            grid1.Column(1).Alignment = FlexCell.AlignmentEnum.CenterCenter;

            grid1.Cell(0, 2).Text = "人员姓名";
            grid1.Column(2).Width = 100;
            grid1.Column(2).Alignment = FlexCell.AlignmentEnum.CenterCenter;

            grid1.Cell(0, 3).Text = "职位";
            grid1.Column(3).Width = 80;
            grid1.Column(3).Alignment = FlexCell.AlignmentEnum.CenterCenter;

            grid1.Cell(0, 4).Text = "部门";
            grid1.Column(4).Width = 150;
            grid1.Column(4).Alignment = FlexCell.AlignmentEnum.CenterCenter;

            grid1.Cell(0, 5).Text = "用户状态";
            grid1.Column(5).Width = 80;
            grid1.Column(5).Alignment = FlexCell.AlignmentEnum.CenterCenter;

            //var au = Person.FindAll();
            //var au = Person.FindAll(Person._.Status,'1');
            string sSql = " select Deptid,DeptName from Dept order by deptID";
            var dau = Dept.FindAll(sSql);
            comDeptID.Items.Clear();
            foreach (Dept dau1 in dau)
            {
                comDeptID.Items.Add(dau1.DeptID.ToString().Trim() + "|" + dau1.DeptName.ToString().Trim());
            }
            

             sSql = " select p.ID,p.Pname,p.Job,p.Areaid,p.[Status] ,p.deptid,d.deptname from Person p ";
            sSql += " inner join dept d on p.deptid=d.deptid";
            sSql += " where p.[Status]='1' order by p.Job";
            var au = Person.FindAll(sSql);
            Int32 ir = 1;

            if (au.Count > 0)
            {
                grid1.Rows = ir;

                foreach (Person u in au)
                {
                    ir += 1;
                    grid1.Rows = ir;
                    try
                    {
                        grid1.Cell(ir - 1, 1).Text = u.ID.ToString();
                        grid1.Cell(ir - 1, 2).Text = u.Pname.ToString().Trim();
                        grid1.Cell(ir - 1, 3).Text = u.Job.ToString().Trim();
                        grid1.Cell(ir - 1, 4).Text = u.DeptID.ToString().Trim();
                        grid1.Cell(ir - 1, 5).Text = u.Status.ToString().Trim();

                    }
                    catch { }

                }

            }

        }

        private void grid1_RowColChange(object Sender, FlexCell.Grid.RowColChangeEventArgs e)
        {
            try
            {
                Int32 uid = 0;
                uid = grid1.Cell(e.Row, 1).Text.ToInt();
                if (uid != textBox1.Text.ToInt())
                {
                    var au = Person.Find(Person._.ID, uid);
                    textBox1.Text = au.ID.ToString();
                    txtPname.Text = au.Pname.ToString().Trim();
                    comSex.Text = au.Sex.ToString().Trim();
                    comJob.Text = au.Job.ToString().Trim();
                    comPaper.Text = au.Paper.ToString().Trim();
                    txtPaperNum.Text = au.PaperNum.ToString().Trim();
                    comDeptID.Text = au.DeptID.ToString().Trim();

                    var deptau = Dept.Find(Dept._.DeptID, au.DeptID.ToString().Trim());
                    textDeptName.Text = deptau.DeptName.ToString().Trim();   //部门名称

                    dtIndate.Value = au.InDate;//入职日期
                    if (au.Status.ToString().Trim() == "1")
                    {
                        checkIsStatus.Checked = true;

                    }
                    else
                    {
                        checkIsStatus.Checked = false;
                        dtOutdate.Value = au.OutDate;//离职日期
                    }

                    txtPsbz.Text = au.Psbz.ToString();
                    txtPsdzbz.Text = au.Psdzbz.ToString();

                    txtZzjs.Text = au.Zzjs.ToString();
                    txtZzbl.Text = au.Zzbl.ToString();

                    dtQsrq.Value = au.Qsrq;

                    if (!au.Zwpdbh.IsNullOrEmpty())
                    {
                        comZwpdbh.Text = au.Zwpdbh.ToString() + "|" + au.Zwpdmc.ToString();
                    }
                    else
                    {
                        comZwpdbh.Text = "";
                    }
                    if (!au.Pdpxbh.IsNullOrEmpty())
                    {
                        txtPdpxbh.Text = au.Pdpxbh.ToString();
                    } else
                    {
                        txtPdpxbh.Text = "";
                    }

                    if (!au.Driverfz.IsNullOrEmpty())
                    {
                        txtDriverfz.Text = au.Driverfz.ToString();

                    }
                    else
                    {
                        txtDriverfz.Text = "";
                    }

                    if (!au.CreateUserID.IsNullOrEmpty())
                    {
                        CreateUserID.Text = au.CreateUserID.ToString();
                        Createtime.Text = au.CreateTime.ToString();
                    }
                    else
                    {
                        CreateUserID.Text = "";
                        Createtime.Text = "";


                    }


                    if (!au.UpdateUserID.IsNullOrEmpty())
                    {
                        UpdateUserID.Text = au.UpdateUserID.ToString();
                        UpdateTime.Text = au.UpdateTime.ToString();
                    }
                    else
                    {
                        UpdateUserID.Text = "";
                        UpdateTime.Text = "";
                    }


                    //textBox5.Text = DESHelper.DesDecrypt(au.Pwd.ToString());
                    //checkBox1.Checked = au.isStop.ToBoolean();
                }

            }
            catch { }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            //保存

            var au = new Person
            {
                ID = textBox1.Text.ToInt(), // = au.ID.ToString();
                Pname = txtPname.Text.ToString(),  // = au.Pname.ToString(),
                Sex = comSex.Text.ToString(),  // = au.Sex.ToString(),
                Job = comJob.Text.ToString(), // = au.Job.ToString();
                Paper = comPaper.Text.ToString(), // = au.Paper.ToString();
                PaperNum = txtPaperNum.Text.ToString(),// = au.PaperNum.ToString();

                DeptID = PubFun.GetSplit(comDeptID.Text.ToString(),0),     // = au.DeptID.ToString();
                                                                        //textDeptName.Text = "";   //部门名称
                InDate = dtIndate.Value, // = au.InDate;//入职日期
                //if (checkIsStatus.Checked)
                //{
                //    //checkIsStatus.Checked = true;
                //    au.Statu= "1",

                //}
                //else
                //{
                //    au.Statu = "1",   //checkIsStatus.Checked = false;
                //    dtOutdate.Value = au.OutDate;//离职日期
                //}

                Psbz = Convert.ToDecimal(txtPsbz.Text.ToString()), // = au.Psbz.ToString();
                Psdzbz = Convert.ToDecimal(txtPsdzbz.Text.ToString()),// = au.Psdzbz.ToString();

                Zzjs = txtZzjs.Text.ToInt(),// = au.Zzjs.ToString();
                Zzbl = Convert.ToDecimal(txtZzbl.Text.ToString()),// = au.Zzbl.ToString();

                Qsrq = dtQsrq.Value, // = au.Qsrq;

                Zwpdbh = PubFun.GetSplit(comZwpdbh.Text.ToString(),0),
                Pdpxbh = txtPdpxbh.Text.ToString(),
                
                Driverfz = txtDriverfz.Text.ToString(),

            };
               
            if (checkIsStatus.Checked)
            {
                //checkIsStatus.Checked = true;
                au.Status = "1";

            }
            else
            {
                au.Status = "0";   //checkIsStatus.Checked = false;
                au.OutDate =dtOutdate.Value  ;//离职日期
            }

            au.Save();


            toolSetTrue(true);
            groupBox2.Text = "";
            groupBox2.Tag = "";
            IsSaved = false;
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
            groupBox2.Tag = textBox1.Text.ToString();
            IsSaved = true; //
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
                    string sSql = "select top 1 id from inv_Evi where person='" + textBox1.Text.ToString() + "'";

                    int i = DbHelperSQL.ExecuteSql(sSql);
                    if (i > 0)
                    {
                        MessageBox.Show("人员已在单据inv_evi【订单】使用，不能删除，只可作离职处理!");
                    }
                    else
                    {
                        var atr = new Person
                        {
                            ID = textBox1.Text.ToInt(),

                            Pname = txtPname.Text.ToString(),

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

        private void toolCancel_Click(object sender, EventArgs e)
        {
            //取消
            toolSetTrue(true);
            IsSaved = false;
        }

        private void toolRef_Click(object sender, EventArgs e)
        {
            IniGrid1();
        }

        private void grid1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
