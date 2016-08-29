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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//添加入库记录按钮事件
        {
            ClassSqlConnect add = new ClassSqlConnect();
            string addItems;
            addItems = ("INST" + textBox1.Text.ToString() + "," + textBox2.Text.ToString() + "," + textBox3.Text.ToString()
                + "," + textBox4.Text.ToString() + "," + textBox5.Text.ToString() + " ");
            add.Insert(addItems);
            addItems = ("INST");
            DataSet ds = add.Select(addItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "INSTORE";
            add.Close();
        }

        private void button4_Click(object sender, EventArgs e)//删除入库记录按钮事件
        {
            ClassSqlConnect del = new ClassSqlConnect();
            string delItems;
            delItems = ("INST" + textBox1.Text.ToString() + "," + textBox4.Text.ToString() + " ");
            del.Delete(delItems);
            delItems = ("INST");
            DataSet ds = del.Select(delItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "INSTORE";
            del.Close();
        }

        private void button5_Click(object sender, EventArgs e)//修改入库记录按钮事件
        {
            ClassSqlConnect upd = new ClassSqlConnect();
            string updItems;
            updItems = ("INST" + textBox1.Text.ToString() + "," + textBox2.Text.ToString() + "," + textBox3.Text.ToString() + "," + textBox4.Text.ToString() + ","
                + textBox5.Text.ToString() + " ");
            upd.Update(updItems);
            updItems = ("INST");
            DataSet ds = upd.Select(updItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "INSTORE";
            upd.Close();
        }

        private void button8_Click(object sender, EventArgs e)//添加出库记录按钮事件
        {
            ClassSqlConnect add = new ClassSqlConnect();
            string addItems;
            addItems = ("OUST" + textBox7.Text.ToString() + "," + textBox8.Text.ToString() + "," + textBox9.Text.ToString()
                + "," + textBox10.Text.ToString() + " ");
            add.Insert(addItems);
            addItems = ("OUST");
            DataSet ds = add.Select(addItems);
            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "OUTSTORE";
            add.Close();
        }

        private void button7_Click(object sender, EventArgs e)//删除出库记录按钮事件
        {
            ClassSqlConnect del = new ClassSqlConnect();
            string delItems;
            delItems = ("OUST" + textBox7.Text.ToString() + "," + textBox10.Text.ToString() + " ");
            del.Delete(delItems);
            delItems = ("OUST");
            DataSet ds = del.Select(delItems);
            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "OUTSTORE";
            del.Close();
        }

        private void button6_Click(object sender, EventArgs e)//修改出库记录按钮事件
        {
            ClassSqlConnect upd = new ClassSqlConnect();
            string updItems;
            updItems = ("OUST" + textBox7.Text.ToString() + "," + textBox8.Text.ToString() + "," + textBox9.Text.ToString() + "," + textBox10.Text.ToString() + " ");
            upd.Update(updItems);
            updItems = ("OUST");
            DataSet ds = upd.Select(updItems);
            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "OUTSTORE";
            upd.Close();
        }

        private void Form5_Load(object sender, EventArgs e)//窗体加载时显示列表信息
        {
            ClassSqlConnect sel = new ClassSqlConnect();
            string showItems;
            showItems = ("INST");
            DataSet ds = sel.Select(showItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "INSTORE";
            sel.Close();
            showItems = ("OUST");
            ds = sel.Select(showItems);
            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "OUTSTORE";
            sel.Close();
        }

        private void button2_Click(object sender, EventArgs e)//库存清算按钮事件
        {
            ClassSqlConnect check = new ClassSqlConnect();
            string cekItems;
            cekItems = ("STOR");
            DataSet ds = check.ViewSelect(cekItems);
            this.dataGridView3.DataSource = ds;
            this.dataGridView3.DataMember = "STORE";
            check.Close();
        }

        private void Button1_Click(object sender, EventArgs e)//注销按钮事件
        {
            if (MessageBox.Show("确定要注销吗？", "注销提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)//窗体关闭时传递消息
        {
            this.DialogResult = DialogResult.OK;
        }
        private void TabPage1_Click(object sender, EventArgs e)
        {

        }


    }
}
