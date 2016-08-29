namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textUName1 = new System.Windows.Forms.TextBox();
            this.ButtonUpd = new System.Windows.Forms.Button();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.TextUPower1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextUP1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextUID1 = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(24, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 114);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.Indigo;
            this.Label1.Location = new System.Drawing.Point(36, 153);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 12);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "管理员头像";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Location = new System.Drawing.Point(728, 42);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(65, 12);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "当前用户：";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(893, 37);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "注销";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(799, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "小北 123456";
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.ItemSize = new System.Drawing.Size(84, 28);
            this.TabControl1.Location = new System.Drawing.Point(121, 58);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(847, 628);
            this.TabControl1.TabIndex = 10;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.label6);
            this.TabPage2.Controls.Add(this.textUName1);
            this.TabPage2.Controls.Add(this.ButtonUpd);
            this.TabPage2.Controls.Add(this.ButtonDel);
            this.TabPage2.Controls.Add(this.TextUPower1);
            this.TabPage2.Controls.Add(this.Label5);
            this.TabPage2.Controls.Add(this.TextUP1);
            this.TabPage2.Controls.Add(this.Label4);
            this.TabPage2.Controls.Add(this.label10);
            this.TabPage2.Controls.Add(this.TextUID1);
            this.TabPage2.Controls.Add(this.ButtonAdd);
            this.TabPage2.Controls.Add(this.DataGridView1);
            this.TabPage2.Location = new System.Drawing.Point(4, 32);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(839, 592);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "用户信息";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "用户姓名";
            // 
            // textUName1
            // 
            this.textUName1.Location = new System.Drawing.Point(280, 499);
            this.textUName1.Name = "textUName1";
            this.textUName1.Size = new System.Drawing.Size(100, 21);
            this.textUName1.TabIndex = 19;
            // 
            // ButtonUpd
            // 
            this.ButtonUpd.Location = new System.Drawing.Point(556, 546);
            this.ButtonUpd.Name = "ButtonUpd";
            this.ButtonUpd.Size = new System.Drawing.Size(100, 23);
            this.ButtonUpd.TabIndex = 12;
            this.ButtonUpd.Text = "修改用户信息";
            this.ButtonUpd.UseVisualStyleBackColor = true;
            this.ButtonUpd.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // ButtonDel
            // 
            this.ButtonDel.Location = new System.Drawing.Point(693, 546);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(100, 23);
            this.ButtonDel.TabIndex = 9;
            this.ButtonDel.Text = "删除用户信息";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // TextUPower1
            // 
            this.TextUPower1.Location = new System.Drawing.Point(662, 499);
            this.TextUPower1.Name = "TextUPower1";
            this.TextUPower1.Size = new System.Drawing.Size(100, 21);
            this.TextUPower1.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(603, 505);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(53, 12);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "用户权限";
            // 
            // TextUP1
            // 
            this.TextUP1.Location = new System.Drawing.Point(477, 499);
            this.TextUP1.Name = "TextUP1";
            this.TextUP1.Size = new System.Drawing.Size(100, 21);
            this.TextUP1.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(418, 505);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 12);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "用户密码";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "用户编号";
            // 
            // TextUID1
            // 
            this.TextUID1.Location = new System.Drawing.Point(94, 499);
            this.TextUID1.Name = "TextUID1";
            this.TextUID1.Size = new System.Drawing.Size(100, 21);
            this.TextUID1.TabIndex = 3;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAdd.Location = new System.Drawing.Point(420, 546);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(100, 23);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "增加用户信息";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.GridColor = System.Drawing.Color.Black;
            this.DataGridView1.Location = new System.Drawing.Point(21, 36);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(794, 431);
            this.DataGridView1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._226807;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员页面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Button ButtonUpd;
        internal System.Windows.Forms.Button ButtonDel;
        internal System.Windows.Forms.TextBox TextUPower1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextUP1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox TextUID1;
        internal System.Windows.Forms.Button ButtonAdd;
        internal System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox textUName1;
        internal System.Windows.Forms.Label label6;

    }
}