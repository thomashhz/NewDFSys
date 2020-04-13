using Hhz.dbdata;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SysDF._99Other
{
    public partial class 解析Json : SysDF.BaseForm.BaseForm
    {
        public 解析Json()
        {
            InitializeComponent();
        }

        private void toolSetTrue(Boolean t)
        {
            toolAdd.Enabled = t;
            toolEdit.Enabled = t;
            toolDel.Enabled = t;


            toolSave.Enabled = !t;
            toolCancel.Enabled = !t;
            //groupBox2.Enabled = !t;


        }

        private void tools_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                //for(int i=0; i<=files.Count; i++)
                //{

                //}
            }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = textBox2.Text.ToString(); // @"X:\xxx\xxx";
            if (path.ToString() != "")
            {
                //第一种方法
                //string[] files = System.IO.Directory.GetFiles(path, "*.json");

                // string path = @"X:\XXX\XX";
                DirectoryInfo root = new DirectoryInfo(path);
                FileInfo[] files = root.GetFiles();


                foreach (FileInfo file in files)
                {
                    // Console.WriteLine(file);
                    listBox1.Items.Add(file);
                }
            }
    }

    private void comboBox1_Click(object sender, EventArgs e)
        {
           
             
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = textBox2.Text .ToString() + "\\" + listBox1.SelectedItem.ToString();
            //sender.ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string jsonfile = textBox3.Text.ToString(); // "C:\\Users\\zhang\\Desktop\\JsonTemplate\\矢量瓦片服务.json";
            if (jsonfile.ToString() == "")
            {
                //文件路径为空，请选定要读取文件
            }
            else
            {
                using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
                {
                    //using (JsonTextReader reader = new JsonTextReader(file))  //using (StreamReader r = new StreamReader(file))
                    //{
                    string json = file.ReadToEnd();
                    //List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                    //for (int i = 0; i < items.Count; i++)
                    //{
                    //    textBox1.Text += items[i].stamp.ToString() + items[i].light.ToString() + "\r\n";
                    //}
                    //textBox1.Text = json.ToString();
                    json = json.Replace("{", "").Replace("}", "");
                    //textBox1.Text = json.ToString();
                    // json = json.Replace("}", "");
                    //textBox1.Text = json.ToString();
                    //textBox1.Text = "";
                    string[] sArray = Regex.Split(json, ",", RegexOptions.IgnoreCase);
                    //this.listView1.Items.Clear();
                    //this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
                    grid1.Rows = 1;
                    int intRows = 1;
                    grid1.AutoRedraw = false;
                    string sItem = "";
                    foreach (string i in sArray)
                    {

                        intRows += 1;
                        grid1.Rows = intRows;
                        string[] sArea = Regex.Split(i.ToString(), ":", RegexOptions.IgnoreCase);

                        grid1.Cell(intRows - 1, 1).Text = sArea[0].ToString().Replace("\"", "");
                        grid1.Cell(intRows - 1, 2).Text = sArea[1].ToString().Replace("\"", "");
                        grid1.Cell(intRows - 1, 3).Text = sArea[0].ToString().Substring(1, 6);

                        //sItem = sArea[0].ToString().Replace("\"", "");
                        //sItem = sItem + "\t" + sArea[1].ToString().Replace("\"", "");
                        //sItem = sItem + "\t" + sArea[0].ToString().Substring(1, 6);
                        //grid1.AddItem(sItem);

                    }
                    grid1.AutoRedraw = true;
                    grid1.Refresh();
                }

            }      



        }

        private void 解析Json_Load(object sender, EventArgs e)
        {
            //ColumnHeader ch = new ColumnHeader();

            //ch.Text = "列标题1";   //设置列标题

            //ch.Width = 120;    //设置列宽度

            //ch.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式

            //this.listView1.Columns.Add(ch);    //将列头添加到ListView控件。

            //或者
            //listView1.View = View.Details;
            //this.listView1.Columns.Add("Code", 120, HorizontalAlignment.Left); //一步添加
            //this.listView1.Columns.Add("CodeName", 200, HorizontalAlignment.Left); //一步添加
            //this.listView1.Columns.Add("PrveCode", 120, HorizontalAlignment.Left); //一步添加

            grid1.Cell(0, 1).Text = "Code";
            grid1.Column(1).Width = 180;
            grid1.Cell(0, 2).Text = "CodeName";
            grid1.Column(2).Width = 350;
            grid1.Cell(0, 3).Text = "PrvCode";
            grid1.Column(3).Width = 180;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string StrJson = textBox2.Text.ToString();//镇json文件路径
            grid1.Rows = 1;
            int intRows = 1;
            grid1.AutoRedraw = false;

            if (listBox1.Items.Count>0)
            {
                for(int j=0; j<listBox1.Items.Count;j++)
                {
                    //循环遍历所有 镇 的json 文件
                    
                    string jsonfile = StrJson + "\\" + listBox1.Items[j].ToString(); // "C:\\Users\\zhang\\Desktop\\JsonTemplate\\矢量瓦片服务.json";
                    if (jsonfile.ToString() == "")
                    {
                        //文件路径为空，请选定要读取文件
                    }
                    else
                    {
                        using (System.IO.StreamReader file = System.IO.File.OpenText(jsonfile))
                        {
                            //using (JsonTextReader reader = new JsonTextReader(file))  //using (StreamReader r = new StreamReader(file))
                            //{
                            string json = file.ReadToEnd();
                            //List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
                            //for (int i = 0; i < items.Count; i++)
                            //{
                            //    textBox1.Text += items[i].stamp.ToString() + items[i].light.ToString() + "\r\n";
                            //}
                            //textBox1.Text = json.ToString();
                            json = json.Replace("{", "").Replace("}", "");
                            //textBox1.Text = json.ToString();
                            // json = json.Replace("}", "");
                            //textBox1.Text = json.ToString();
                            //textBox1.Text = "";
                            string[] sArray = Regex.Split(json, ",", RegexOptions.IgnoreCase);
                            //this.listView1.Items.Clear();
                            //this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
                            
                            foreach (string i in sArray)
                            {

                                intRows += 1;
                                grid1.Rows = intRows;
                                string[] sArea = Regex.Split(i.ToString(), ":", RegexOptions.IgnoreCase);

                                grid1.Cell(intRows - 1, 1).Text = sArea[0].ToString().Replace("\"", "");
                                grid1.Cell(intRows - 1, 2).Text = sArea[1].ToString().Replace("\"", "");
                                grid1.Cell(intRows - 1, 3).Text = sArea[0].ToString().Substring(1, 6);

                            }
                        }

                    }

                }


            }
            grid1.AutoRedraw = true;
            grid1.Refresh();

        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if(grid1.Rows>1)
            {
                int sqlrow = 0;
                //保存记录到 area_town 表中
                for(int i=1;i<grid1.Rows;i++)
                {
                    string sSql = " insert into area_town (code,name,prvcode)  ";
                    sSql += " select top 1 '" + grid1.Cell(i , 1).Text.ToString() + "'";
                    sSql += " , '" + grid1.Cell(i , 2).Text.ToString() + "'";
                    sSql += " , '" + grid1.Cell(i,3).Text.ToString() + "'";
                    sSql += " from actFormType where not exists(select 1 from area_town where code='" + grid1.Cell(i, 1).Text.ToString() + "')";

                    sqlrow = DbHelperSQL.ExecuteSql(sSql);

                }
            }
        }
    }

    
}
    

    

