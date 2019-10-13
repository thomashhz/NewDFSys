using Hhz.dbdata;
using Hhz.SysDF.SysModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysDF.SysModule.SysModuleForm
{
    public partial class 用户管理 : SysDF.BaseForm.BaseForm
    {
        public 用户管理()
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
        private void 用户管理_Load(object sender, EventArgs e)
        {
            IniGrid1();
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
            grid1.Column(3).Width = 180;

            grid1.Cell(0, 4).Text = "用户部门";
            grid1.Column(4).Width = 120;

            grid1.Cell(0, 5).Text = "用户状态";
            grid1.Column(5).Width = 60;

            var au = ActUser.FindAll();
            Int32 ir = 1;

            if (au.Count > 0)
            {
                grid1.Rows = ir;

                foreach (ActUser u in au)
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

        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            //保存
            var itrue = Convert.ToInt16(checkBox1.Checked);
            string strpwd = "";
            strpwd = DESHelper.DesEncrypt(textBox5.Text.ToString());
            var au = new ActUser
            {

                id = textBox1.Text.ToInt(),

                UserID = textBox2.Text.ToString(),
                UserName = textBox3.Text.ToString(),
                Detp = textBox4.Text.ToString(),
                Pwd = strpwd.ToString(),
                isStop = itrue
            };

            au.Save();   //保存

            toolSetTrue(true);
            groupBox2.Text = "";
            groupBox2.Tag = "";
            IsSaved = false;

            
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            //取消
            toolSetTrue(true);
        }

        private void grid1_RowColChange(object Sender, FlexCell.Grid.RowColChangeEventArgs e)
        {
            try
            {
                Int32 uid = 0;
                uid = grid1.Cell(e.Row, 1).Text.ToInt();

                var au = ActUser.Find(ActUser._.id, uid);
                textBox1.Text = au.id.ToString();
                textBox2.Text = au.UserID.ToString();
                textBox3.Text = au.UserName.ToString();
                textBox4.Text = au.Detp.ToString();
                textBox5.Text = DESHelper.DesDecrypt(au.Pwd.ToString());
                checkBox1.Checked = au.isStop.ToBoolean();
            }
            catch { }
        }
    }
}
