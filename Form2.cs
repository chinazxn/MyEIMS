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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)//新增用户按钮事件
        {
            ClassSqlConnect add = new ClassSqlConnect();
            string addItems;
            addItems = ("USER" + TextUID1.Text.ToString() + "," + textUName1.Text.ToString()
                + "," + TextUPower1.Text.ToString() + "," + TextUP1.Text.ToString() + " ");
            add.Insert(addItems);
            addItems = ("USER");
            DataSet ds = add.Select(addItems);
            this.DataGridView1.DataSource = ds;
            this.DataGridView1.DataMember = "USERS";
            add.Close();
        }
        private void ButtonUpd_Click(object sender, EventArgs e)//修改用户按钮事件
        {
            ClassSqlConnect upd = new ClassSqlConnect();
            string updItems;
            updItems = ("USER" + TextUID1.Text.ToString() + "," + textUName1.Text.ToString()
                + "," + TextUPower1.Text.ToString() + "," + TextUP1.Text.ToString() + " ");
            upd.Update(updItems);
            updItems = ("USER");
            DataSet ds = upd.Select(updItems);
            this.DataGridView1.DataSource = ds;
            this.DataGridView1.DataMember = "USERS";
            upd.Close();
        }

        private void ButtonDel_Click(object sender, EventArgs e)//删除用户按钮事件
        {
            ClassSqlConnect del = new ClassSqlConnect();
            string delItems;
            delItems = ("USER" + TextUID1.Text.ToString() + " ");
            del.Delete(delItems);
            delItems = ("USER");
            DataSet ds = del.Select(delItems);
            this.DataGridView1.DataSource = ds;
            this.DataGridView1.DataMember = "USERS";
            del.Close();
        }

        private void Form2_Load(object sender, EventArgs e)//窗体加载时显示用户信息
        {
            ClassSqlConnect sel = new ClassSqlConnect();
            string showItems;
            showItems = ("USER");
            DataSet ds = sel.Select(showItems);
            this.DataGridView1.DataSource = ds;
            this.DataGridView1.DataMember = "USERS";
            sel.Close();
        }

        private void Button1_Click(object sender, EventArgs e)//注销按钮事件
        {
            if (MessageBox.Show("确定要注销吗？", "注销提示", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)//窗体关闭时传递消息
        {
            this.DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form nfm = new Form11();
            this.Hide();
            if (nfm.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
