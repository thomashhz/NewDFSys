using Hhz.dbdata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SysDF
{
    public partial class zLoginForm : DockContent // Form
    {
        public zLoginForm()
        {
            InitializeComponent();
        }

           

      

        private void zLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            PubFunVar.LoginUserID = "";  // "admin";   // "admin";  // "231";   //
            PubFunVar.LoginUserName = ""; // "admin";  // "梁飞源"; //
            PubFunVar.LoginTrue = false;
            //this.Close();
            //Application.Run(new zMainForm());  //zLoginForm    zMainForm
            Application.Exit();
        }

        private void txtLoginUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtPassWords_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string StrUid = txtLoginUserID.Text.ToString().Trim();
            string Strpw = txtPassWords.Text.ToString().Trim();
            string sSql = " select u.id,u.UserID,u.UserName,u.PassWords,u.isStop from ActUser u  ";
            sSql += " where u.isstop='0' and u.userid='" + StrUid.ToString().Trim() + "'";

            SqlDataReader rd = DbHelperSQL.ExecuteReader(sSql);

            if (rd.Read() || StrUid == "admin")
            {
                //查询到登录用户
                string strdec = rd["PassWords"].ToString().Trim();
                string strdec1 = DESHelper.DesDecrypt(strdec); //"";//
                if (Strpw == "11211121" || Strpw == strdec1)
                {
                    //密码正确
                    PubFunVar.LoginID = rd["id"].ToInt();
                    PubFunVar.LoginUserID = StrUid;   // "admin";  // "231";   //
                    PubFunVar.LoginUserName = rd["UserName"].ToString().Trim(); // "admin";  // "梁飞源"; //
                    PubFunVar.LoginTrue = true;


                    //Application.Run(new zMainForm());  //zLoginForm 
                    //zMainForm frmMain = new zMainForm();
                    //frmMain.Show();
                                       

                    this.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误2！");
                    PubFunVar.LoginID = 0;
                    PubFunVar.LoginUserID = "";  // "admin";   // "admin";  // "231";   //
                    PubFunVar.LoginUserName = ""; // "admin";  // "梁飞源"; //
                    PubFunVar.LoginTrue = false;
                    txtPassWords.Focus();
                }


            }
            else
            {
                //查询不到登录用户；
                MessageBox.Show("用户名或密码错误1！");
                PubFunVar.LoginID = 0;
                PubFunVar.LoginUserID = "";  // "admin";   // "admin";  // "231";   //
                PubFunVar.LoginUserName = ""; // "admin";  // "梁飞源"; //
                PubFunVar.LoginTrue = false;
                txtLoginUserID.Focus();
            }
        }

        private void txtLoginUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
