using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)//登录按键响应事件
        {
            //新建ClassSqlConnect类，调用重构的ViewCount方法返回从数据库中查询的结果
            ClassSqlConnect log = new ClassSqlConnect();
            SqlDataReader reader = log.ViewCount(ComboxUserName.Text.ToString(),TxtPassword.Text.ToString());
            if (reader.Read())//判断有数据，说明登录成功
            {
                /*保存账号信息，将这部分信息保存在数据库（XML）中更好*/
                ComboxUserName.Items.Add(ComboxUserName.Text.ToString());
                Form nfm;
                //提取用户名信息
                string UName = reader[1].ToString();
                MessageBox.Show("欢迎你，"+ UName);
                //提取权限信息并选择应打开的界面
                switch((int)reader[2])
                {
                    case 0:
                        nfm = new Form2();//系统管理界面
                        this.Hide();
                        if (nfm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        break;
                    case 1:
                        nfm = new Form7();//人事经理管理界面
                        this.Hide();
                        if (nfm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        break;
                    case 2:
                        nfm = new Form3();//人事员工管理界面
                        this.Hide();
                        if (nfm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        break;
                    case 3:
                        nfm = new Form8();//财务经理管理界面
                        this.Hide();
                        if (nfm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        break;
                    case 4:
                        nfm = new Form4();//财务员工管理界面
                        this.Hide();
                        if (nfm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        break;
                    case 5:
                        nfm = new Form9();//销售经理管理界面
                        this.Hide();
                        if (nfm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        break;
                    case 6:
                        nfm = new Form6();//销售员工管理界面
                        this.Hide();
                        if (nfm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        break;
                    case 7:
                        nfm = new Form10();//仓库经理管理界面
                        this.Hide();
                        if (nfm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        break;
                    case 8:
                        nfm = new Form5();//仓库员工管理界面
                        this.Hide();
                        if (nfm.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        break;
                    default:
                        MessageBox.Show("你没有登录权限，" + UName,"没有权限");
                        ComboxUserName.Text = "";
                        TxtPassword.Text = "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("用户名或密码错误！","错误");
                TxtPassword.Text = "";
            }
            //调用自定义的Close方法关闭sql连接
            log.Close();
        }
        private void ButtonReset_Click(object sender, EventArgs e)//重设按键
        {
            ComboxUserName.Text = "";
            TxtPassword.Text = "";
        }
    }
}
