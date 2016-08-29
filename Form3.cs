using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)//窗体加载时显示列表信息
        {
            ClassSqlConnect sel = new ClassSqlConnect();//构建新的ClassSqlConnect类对象
            string showItems;
            showItems = ("STAF");//关键字段STAF
            DataSet ds = sel.Select(showItems);//调用自定义的Select方法选择STAFF表信息
            this.DataGridView1.DataSource = ds;//绑定数据
            this.DataGridView1.DataMember = "STAFF";
            sel.Close();//关闭sql连接
        }

        private void button2_Click(object sender, EventArgs e)//创建按钮
        {
            ClassSqlConnect add = new ClassSqlConnect();
            string addItems;//存储文本框信息
            addItems = ("STAF" + textBox1.Text.ToString() + "," + textBox2.Text.ToString() + "," + textBox3.Text.ToString() + "," + textBox4.Text.ToString() + ","
                + textBox5.Text.ToString() + "," + textBox6.Text.ToString() + "," + textBox7.Text.ToString() + "," + textBox8.Text.ToString() + ","
                + textBox9.Text.ToString() + "," + textBox10.Text.ToString() + " ");
            add.Insert(addItems);//调用自定义Insert方法在数据库中新增记录
            addItems = ("STAF");
            DataSet ds = add.Select(addItems);//调用Select方法更新列表
            this.DataGridView1.DataSource = ds;//绑定数据
            this.DataGridView1.DataMember = "STAFF";
            add.Close();//关闭sql连接
        }

        private void button3_Click(object sender, EventArgs e)//修改按钮
        {
            ClassSqlConnect upd = new ClassSqlConnect();
            string updItems;
            updItems = ("STAF"  + textBox1.Text.ToString() + "," + textBox2.Text.ToString() + "," + textBox3.Text.ToString() + "," + textBox4.Text.ToString() + ","
                + textBox5.Text.ToString() + "," + textBox6.Text.ToString() + "," + textBox7.Text.ToString() + "," + textBox8.Text.ToString() + ","
                + textBox9.Text.ToString() + "," + textBox10.Text.ToString() + " ");
            upd.Update(updItems);//调用自定义Update方法在数据库中更新STAFF数据
            updItems = ("STAF");
            DataSet ds = upd.Select(updItems);//更新列表
            this.DataGridView1.DataSource = ds;
            this.DataGridView1.DataMember = "STAFF";
            upd.Close();
        }

        private void button4_Click(object sender, EventArgs e)//删除按钮
        {
            ClassSqlConnect del = new ClassSqlConnect();
            string delItems;
            delItems = ("STAF" + textBox1.Text.ToString() + " ");
            del.Delete(delItems);//调用自定义Delete方法在数据库中删除对应记录
            delItems = ("STAF");
            DataSet ds = del.Select(delItems);//更新列表
            this.DataGridView1.DataSource = ds;
            this.DataGridView1.DataMember = "STAFF";
            del.Close();
        }

        private void Button1_Click(object sender, EventArgs e)//注销按钮
        {
            if (MessageBox.Show("确定要注销吗？", "注销提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)//窗体关闭时发送信息
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
