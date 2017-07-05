namespace WindowsFormsApp1
{
	partial class Sdbclass
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.b_connect = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.rb_sysadmin = new System.Windows.Forms.RadioButton();
			this.rb_dataadmin = new System.Windows.Forms.RadioButton();
			this.tb_sdbadress = new System.Windows.Forms.TextBox();
			this.tb_port = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.l_status = new System.Windows.Forms.Label();
			this.tb_cl = new System.Windows.Forms.TextBox();
			this.tb_cs = new System.Windows.Forms.TextBox();
			this.tb_ = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_domain = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(622, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(460, 523);
			this.dataGridView1.TabIndex = 0;
			// 
			// b_connect
			// 
			this.b_connect.Location = new System.Drawing.Point(56, 424);
			this.b_connect.Name = "b_connect";
			this.b_connect.Size = new System.Drawing.Size(75, 23);
			this.b_connect.TabIndex = 1;
			this.b_connect.Text = "连接";
			this.b_connect.UseVisualStyleBackColor = true;
			this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(194, 12);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(400, 523);
			this.treeView1.TabIndex = 3;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.rb_sysadmin);
			this.flowLayoutPanel1.Controls.Add(this.rb_dataadmin);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 23);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 30);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// rb_sysadmin
			// 
			this.rb_sysadmin.AutoSize = true;
			this.rb_sysadmin.Location = new System.Drawing.Point(3, 3);
			this.rb_sysadmin.Name = "rb_sysadmin";
			this.rb_sysadmin.Size = new System.Drawing.Size(71, 16);
			this.rb_sysadmin.TabIndex = 22;
			this.rb_sysadmin.Text = "系统管理";
			this.rb_sysadmin.UseVisualStyleBackColor = true;
			// 
			// rb_dataadmin
			// 
			this.rb_dataadmin.AutoSize = true;
			this.rb_dataadmin.Checked = true;
			this.rb_dataadmin.Location = new System.Drawing.Point(80, 3);
			this.rb_dataadmin.Name = "rb_dataadmin";
			this.rb_dataadmin.Size = new System.Drawing.Size(71, 16);
			this.rb_dataadmin.TabIndex = 23;
			this.rb_dataadmin.TabStop = true;
			this.rb_dataadmin.Text = "数据管理";
			this.rb_dataadmin.UseVisualStyleBackColor = true;
			this.rb_dataadmin.CheckedChanged += new System.EventHandler(this.rb_dataadmin_CheckedChanged);
			// 
			// tb_sdbadress
			// 
			this.tb_sdbadress.Location = new System.Drawing.Point(56, 470);
			this.tb_sdbadress.Name = "tb_sdbadress";
			this.tb_sdbadress.Size = new System.Drawing.Size(124, 21);
			this.tb_sdbadress.TabIndex = 7;
			this.tb_sdbadress.TextChanged += new System.EventHandler(this.tb_sdbadress_TextChanged);
			// 
			// tb_port
			// 
			this.tb_port.Location = new System.Drawing.Point(56, 514);
			this.tb_port.Name = "tb_port";
			this.tb_port.Size = new System.Drawing.Size(124, 21);
			this.tb_port.TabIndex = 8;
			this.tb_port.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 475);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 9;
			this.label1.Text = "SDB地址";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 519);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "端口";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// l_status
			// 
			this.l_status.AutoSize = true;
			this.l_status.Location = new System.Drawing.Point(56, 579);
			this.l_status.Name = "l_status";
			this.l_status.Size = new System.Drawing.Size(0, 12);
			this.l_status.TabIndex = 11;
			// 
			// tb_cl
			// 
			this.tb_cl.Location = new System.Drawing.Point(56, 296);
			this.tb_cl.Name = "tb_cl";
			this.tb_cl.Size = new System.Drawing.Size(123, 21);
			this.tb_cl.TabIndex = 12;
			// 
			// tb_cs
			// 
			this.tb_cs.Location = new System.Drawing.Point(56, 252);
			this.tb_cs.Name = "tb_cs";
			this.tb_cs.Size = new System.Drawing.Size(123, 21);
			this.tb_cs.TabIndex = 13;
			// 
			// tb_
			// 
			this.tb_.Location = new System.Drawing.Point(56, 207);
			this.tb_.Name = "tb_";
			this.tb_.Size = new System.Drawing.Size(123, 21);
			this.tb_.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 210);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 15;
			this.label3.Text = "分区组";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 255);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 16;
			this.label4.Text = "集合空间";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 299);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 17;
			this.label5.Text = "集合";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 161);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 12);
			this.label6.TabIndex = 19;
			this.label6.Text = "域";
			// 
			// tb_domain
			// 
			this.tb_domain.Location = new System.Drawing.Point(56, 158);
			this.tb_domain.Name = "tb_domain";
			this.tb_domain.Size = new System.Drawing.Size(123, 21);
			this.tb_domain.TabIndex = 18;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(5, 342);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "删除";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(103, 342);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 21;
			this.button2.Text = "创建";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Sdbclass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1127, 603);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_domain);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_);
			this.Controls.Add(this.tb_cs);
			this.Controls.Add(this.tb_cl);
			this.Controls.Add(this.l_status);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_port);
			this.Controls.Add(this.tb_sdbadress);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.b_connect);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Sdbclass";
			this.Text = "巨杉数据库";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button b_connect;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TextBox tb_sdbadress;
		private System.Windows.Forms.TextBox tb_port;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label l_status;
		private System.Windows.Forms.TextBox tb_cl;
		private System.Windows.Forms.TextBox tb_cs;
		private System.Windows.Forms.TextBox tb_;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_domain;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton rb_sysadmin;
		private System.Windows.Forms.RadioButton rb_dataadmin;
	}
}

