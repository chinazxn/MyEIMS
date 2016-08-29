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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)//员工工资选项卡查询按钮事件
        {
            string d1 = dateTimePicker1.Value.Date.ToShortDateString();
            string d2 = dateTimePicker2.Value.Date.ToShortDateString();
            ClassSqlConnect salary = new ClassSqlConnect();
            string salItems;
            salItems = ("SALY" + d1 + "," + d2 + " ");
            DataSet ds = salary.ViewSelect(salItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "SALARYS";
            salary.Close();
        }

        private void button6_Click(object sender, EventArgs e)//产品成本选项卡查询按钮事件
        {
            string d1 = dateTimePicker3.Value.Date.ToShortDateString();
            string d2 = dateTimePicker4.Value.Date.ToShortDateString();
            ClassSqlConnect saler = new ClassSqlConnect();
            string salItems;
            salItems = ("COST" + d1 + "," + d2 + " ");
            DataSet ds = saler.ViewSelect(salItems);
            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "COST";
            saler.Close();
        }

        private void button7_Click(object sender, EventArgs e)//利润分析选项卡查询按钮事件
        {
            string d1 = dateTimePicker5.Value.Date.ToShortDateString();
            string d2 = dateTimePicker6.Value.Date.ToShortDateString();
            ClassSqlConnect saler = new ClassSqlConnect();
            string salItems;
            salItems = ("PROF" + d1 + "," + d2 + " ");
            DataSet ds = saler.ViewSelect(salItems);
            this.dataGridView3.DataSource = ds;
            this.dataGridView3.DataMember = "PROFIT";
            saler.Close();
        }

        private void Button4_Click(object sender, EventArgs e)//员工工资选项卡核算按钮事件
        {
            string d1 = dateTimePicker1.Value.Date.ToShortDateString();
            string d2 = dateTimePicker2.Value.Date.ToShortDateString();
            ClassSqlConnect salary = new ClassSqlConnect();
            string salItems;
            salItems = ("TSAY" + d1 + "," + d2 + " ");
            string ds = salary.ViewCount(salItems);
            this.textBox1.Text = ds;
            salary.Close();
        }

        private void button2_Click(object sender, EventArgs e)//产品成本选项卡核算按钮事件
        {
            string d1 = dateTimePicker3.Value.Date.ToShortDateString();
            string d2 = dateTimePicker4.Value.Date.ToShortDateString();
            ClassSqlConnect salary = new ClassSqlConnect();
            string salItems;
            salItems = ("TCST" + d1 + "," + d2 + " ");
            string ds = salary.ViewCount(salItems);
            this.textBox2.Text = ds;
            salary.Close();
        }

        private void Button1_Click(object sender, EventArgs e)//注销按钮
        {
            if (MessageBox.Show("确定要注销吗？", "注销提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
        private void Form4_FormClosing_1(object sender, FormClosingEventArgs e)//窗体关闭返回消息
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
