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
    public partial class 修改密码 : SysDF.BaseForm.BaseForm
    {
        public 修改密码()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断输入的2次密码是否相同
            string spw1 = textBox1.Text.ToString().Trim();
            string spw2 = textBox2.Text.ToString().Trim();
            string strpwd = "";
            
            if (spw1==spw2)
            {
                strpwd = DESHelper.DesEncrypt(textBox1.Text.ToString());
                var au = new ActUser
                {

                    id = PubFunVar.LoginID.ToInt(),
                    UserID = PubFunVar.LoginUserID.ToString().Trim(),
                    UserName = PubFunVar.LoginUserName.ToString().Trim(),
                    PassWords = strpwd.ToString(),
                    
                };
                au.Save();   //保存

                MessageBox.Show("提示：保存完成！");

            }
            else
            {
                MessageBox.Show("提示：输入2次密码不一致！");
                textBox1.Focus();
                
            }
        }
    }
}
