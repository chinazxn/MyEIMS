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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string d1 = dateTimePicker1.Value.Date.ToShortDateString();
            string d2 = dateTimePicker2.Value.Date.ToShortDateString();
            ClassSqlConnect saler = new ClassSqlConnect();
            string salItems;
            salItems = ("INST" + d1 + "," + d2 + " ");
            DataSet ds = saler.ViewSelect(salItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "INSTORE";
            saler.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d1 = dateTimePicker3.Value.Date.ToShortDateString();
            string d2 = dateTimePicker4.Value.Date.ToShortDateString();
            ClassSqlConnect saler = new ClassSqlConnect();
            string salItems;
            salItems = ("OUST" + d1 + "," + d2 + " ");
            DataSet ds = saler.ViewSelect(salItems);
            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "OUTSTORE";
            saler.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string d1 = dateTimePicker5.Value.Date.ToShortDateString();
            string d2 = dateTimePicker6.Value.Date.ToShortDateString();
            ClassSqlConnect saler = new ClassSqlConnect();
            string salItems;
            salItems = ("STOR" + d1 + "," + d2 + " ");
            DataSet ds = saler.ViewSelect(salItems);
            this.dataGridView3.DataSource = ds;
            this.dataGridView3.DataMember = "STORE";
            saler.Close();
        }
        private void Form10_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要注销吗？", "注销提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
