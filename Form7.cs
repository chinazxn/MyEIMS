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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ClassSqlConnect sel = new ClassSqlConnect();
            string showItems;
            showItems = ("STAF");
            DataSet ds = sel.Select(showItems);
            this.DataGridView1.DataSource = ds;
            this.DataGridView1.DataMember = "STAFF";
            sel.Close();
        }
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
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
