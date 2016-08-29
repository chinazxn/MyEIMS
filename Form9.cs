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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            ClassSqlConnect sel = new ClassSqlConnect();
            string showItems;
            showItems = ("SALE");
            DataSet ds = sel.Select(showItems);
            this.dataGridView2.DataSource = ds;
            this.dataGridView2.DataMember = "SALE";

            sel.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d1 = dateTimePicker1.Value.Date.ToShortDateString();
            string d2 = dateTimePicker2.Value.Date.ToShortDateString();
            ClassSqlConnect sale = new ClassSqlConnect();
            string salItems;
            salItems = ("SALR" + d1 + "," + d2 + " ");
            DataSet ds = sale.ViewSelect(salItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "SALER";
            salItems = ("SALE" + d1 + "," + d2 + " ");
            ds = sale.ViewSelect(salItems);
            this.dataGridView3.DataSource = ds;
            this.dataGridView3.DataMember = "PRODUCT";
            sale.Close();

        }
        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
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
