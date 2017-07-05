using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SequoiaDB;
using SequoiaDB.Bson;


namespace WindowsFormsApp1
{
	public partial class Sdbclass : Form
	{
		public Sequoiadb sdb;

		public Sdbclass()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void b_connect_Click(object sender, EventArgs e)
		{
			string sdb_host = tb_sdbadress.Text;
			string sdb_port = tb_port.Text;

			string sdb_instance = sdb_host + ":" + sdb_port;

			Console.WriteLine(sdb_instance);
			Sequoiadb sdb = new Sequoiadb(sdb_instance);
			Common.Connect(sdb);

			if (rb_sysadmin.Checked)
			{
				sample.SetTreeViewSysAdmin(treeView1, sdb);
			}
			if(rb_dataadmin.Checked)
			{
				sample.SetTreeViewDataAdmin(treeView1, sdb);
			}

		}

		private void tb_sdbadress_TextChanged(object sender, EventArgs e)
		{

		}

		#region FindNodeText method
		private List<TreeNode> FindNodeByText(TreeView treeView, string nodeText, bool matchWholeWord)
		{
			// Store the found node
			List<TreeNode> lstFoundNode = new List<TreeNode>();

			// Traversal stack
			Stack<TreeNode> nodeStack = new Stack<TreeNode>();
			for (int i = 0; i < treeView.Nodes.Count; i++)
			{
				nodeStack.Push(treeView.Nodes[i]);
			}

			while (nodeStack.Count != 0)
			{
				TreeNode treeNode = nodeStack.Pop();
				if (matchWholeWord)
				{
					if (treeNode.Text == nodeText)
					{
						lstFoundNode.Add(treeNode);
					}
				}
				else
				{
					if (treeNode.Text.Contains(nodeText))
					{
						lstFoundNode.Add(treeNode);
					}
				}

				for (int i = 0; i < treeNode.Nodes.Count; i++)
				{
					nodeStack.Push(treeNode.Nodes[i]);
				}
			}
			return lstFoundNode;
		}

		#endregion

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{


		}

		private void treeView1_MouseClick(object sender, MouseEventArgs e)
		{
			
		}

		private void rb_dataadmin_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			
			switch()

		}
	}
}
