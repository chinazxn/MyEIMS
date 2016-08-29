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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)//创建销售记录按钮事件
        {
            ClassSqlConnect add = new ClassSqlConnect();
            string addItems;
            addItems = ("SALE" + textBox1.Text.ToString() + "," + textBox2.Text.ToString() + "," + textBox3.Text.ToString() + "," + textBox4.Text.ToString() + ","
                + textBox5.Text.ToString() + "," + textBox6.Text.ToString() + "," + textBox7.Text.ToString() +  " ");
            add.Insert(addItems);
            addItems = ("SALE");
            DataSet ds = add.Select(addItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "SALE";
            add.Close();
        }

        private void Form6_Load(object sender, EventArgs e)//窗体加载时显示列表信息
        {
            ClassSqlConnect sel = new ClassSqlConnect();
            string showItems;
            showItems = ("SALE");
            DataSet ds = sel.Select(showItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "SALE";
            sel.Close();
        }

        private void button3_Click(object sender, EventArgs e)//更新销售记录按钮事件
        {
            ClassSqlConnect upd = new ClassSqlConnect();
            string updItems;
            updItems = ("SALE" + textBox1.Text.ToString() + "," + textBox2.Text.ToString() + "," + textBox3.Text.ToString() + "," + textBox4.Text.ToString() + ","
                + textBox5.Text.ToString() + "," + textBox6.Text.ToString() + "," + textBox7.Text.ToString() + " ");
            upd.Update(updItems);
            updItems = ("SALE");
            DataSet ds = upd.Select(updItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "SALE";
            upd.Close();
        }

        private void button4_Click(object sender, EventArgs e)//删除销售记录按钮事件
        {
            ClassSqlConnect del = new ClassSqlConnect();
            string delItems;
            delItems = ("SALE" + textBox1.Text.ToString() + "," + textBox5.Text.ToString() + "," + textBox7.Text.ToString() + " ");
            del.Delete(delItems);
            delItems = ("SALE");
            DataSet ds = del.Select(delItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "SALE";
            del.Close();
        }

        private void button5_Click(object sender, EventArgs e)//按员工统计按钮事件
        {
            string d1 = dateTimePicker1.Value.Date.ToShortDateString();
            string d2 = dateTimePicker2.Value.Date.ToShortDateString();
            ClassSqlConnect saler = new ClassSqlConnect();
            string salItems;
            salItems = ("SALR" + d1 + "," + d2 + " ");
            DataSet ds = saler.ViewSelect(salItems);
            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "SALER";
            saler.Close();
        }

        private void button6_Click(object sender, EventArgs e)//按商品统计按钮事件
        {
            string d1 = dateTimePicker1.Value.Date.ToShortDateString();
            string d2 = dateTimePicker2.Value.Date.ToShortDateString();
            ClassSqlConnect product = new ClassSqlConnect();
            string proItems;
            proItems = ("SALE" + d1 + "," + d2 + " ");
            DataSet ds = product.ViewSelect(proItems);
            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "PRODUCT";
            product.Close();
        }

        private void Button1_Click(object sender, EventArgs e)//注销按钮事件
        {
            if (MessageBox.Show("确定要注销吗？", "注销提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)//窗体关闭时传递消息
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
