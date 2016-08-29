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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string d1 = dateTimePicker1.Value.Date.ToShortDateString();
            string d2 = dateTimePicker2.Value.Date.ToShortDateString();
            ClassSqlConnect saler = new ClassSqlConnect();
            string salItems;
            salItems = ("ECOM" + d1 + "," + d2 + " ");
            DataSet ds = saler.ViewSelect(salItems);
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "PROFIT";
            saler.Close();
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
