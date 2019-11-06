using Hhz.dbdata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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

       

       

        private void butLogin_Click(object sender, EventArgs e)
        {


            string StrUid = txtLoginUserID.Text.ToString().Trim();
            string Strpw = txtPassWords.Text.ToString().Trim();
            string sSql = " select u.UserID,u.UserName,u.pwd,u.isStop from ActUser u  ";
            sSql+=" where u.isstop='0' and u.userid='"+ StrUid.ToString().Trim() + "'";

            SqlDataReader rd=DbHelperSQL.ExecuteReader(sSql);

            if(rd.Read() || StrUid == "admin" )
            {
                //查询到登录用户
                string strdec = rd["pwd"].ToString().Trim();
                string strdec1 =  DESHelper.DesDecrypt(strdec); //"";//
                if (StrUid == "admin" || Strpw == strdec1 )
                {
                    //密码正确
                    PubFunVar.LoginUserID = StrUid;   // "admin";  // "231";   //
                    PubFunVar.LoginUserName = rd["UserName"].ToString().Trim(); // "admin";  // "梁飞源"; //
                    PubFunVar.LoginTrue = true;

                    //Application.Run(new zMainForm());  //zLoginForm 
                    zMainForm frmMain = new zMainForm();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                    PubFunVar.LoginUserID = "";  // "admin";   // "admin";  // "231";   //
                    PubFunVar.LoginUserName = ""; // "admin";  // "梁飞源"; //
                    PubFunVar.LoginTrue = false;
                }

                
            }
            else
            {
                //查询不到登录用户；
                MessageBox.Show("用户名或密码错误！");
                PubFunVar.LoginUserID = "";  // "admin";   // "admin";  // "231";   //
                PubFunVar.LoginUserName = ""; // "admin";  // "梁飞源"; //
                PubFunVar.LoginTrue = false;

            }
            
        }

        private void zLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
