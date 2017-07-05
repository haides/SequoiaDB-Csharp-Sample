using SequoiaDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public class sample
	{

		public static void SetTreeViewSysAdmin(TreeView treeview1, Sequoiadb sdb)
		{
			treeview1.BeginUpdate();
			treeview1.Nodes.Clear();

			try
			{
				DBCursor dm_cursor = sdb.ListDomains(null, null, null, null);
				String dm_name = null;


					int i = 0;
					while (dm_cursor.Next() != null)
					{
						dm_name = dm_cursor.Current().GetValue("Name").ToString();
					//Console.WriteLine("===debug====" + i +"dm_name"+ dm_name);
						treeview1.Nodes.Add(new TreeNode(dm_name));

						Domain sdb_dm = sdb.GetDomain(dm_name);
						DBCursor cs_cursor = sdb_dm.ListCS();

						int j = 0;
						while (cs_cursor.Next() != null)
						{
							String cs_name = cs_cursor.Current().GetValue("Name").ToString();
						//Console.WriteLine("===debug====" +"i:"+ i +"====cs_name"+"j:"+j+ cs_name);
						treeview1.Nodes[i].Nodes.Add(new TreeNode(cs_name));

							CollectionSpace cs = sdb.GetCollecitonSpace(cs_name);
							DBCursor cl_cursor = sdb.ListCollections();

						//	int j = 0;
							while (cl_cursor.Next() != null)
							{
								String cl_fullname = cl_cursor.Current().GetValue("Name").ToString();
								String cl_shortname = cl_fullname.Split('.')[1];

								if (cl_fullname.Split('.')[0] == cs_name)
								{

									treeview1.Nodes[i].Nodes[j].Nodes.Add(new TreeNode(cl_shortname));
								}
								
							}
							j++;
						}
						i++;
					}
			

			}
			catch (BaseException e)
			{
				Console.WriteLine(e.Message);
			}

			// Begin repainting the TreeView.
			treeview1.EndUpdate();

		}

		public static void SetTreeViewDataAdmin(TreeView treeview1, Sequoiadb sdb)
		{


			// Display a wait cursor while the TreeNodes are being created.
			//		DBCursor cursor = null;

			treeview1.BeginUpdate();
			treeview1.Nodes.Clear();

			// Add a root TreeNode for each Domain object in the ArrayList.

			try
			{

				DBCursor cs_cursor = sdb.ListCollectionSpaces();
				int i = 0;
					while (cs_cursor.Next() != null)
					{
						String cs_name = cs_cursor.Current().GetValue("Name").ToString();
						treeview1.Nodes.Add(new TreeNode(cs_name));

						CollectionSpace cs = sdb.GetCollecitonSpace(cs_name);
						DBCursor cl_cursor = sdb.ListCollections();
						while (cl_cursor.Next() != null)
						{
							String cl_fullname = cl_cursor.Current().GetValue("Name").ToString();
							String cl_shortname = cl_fullname.Split('.')[1];

						if (cl_fullname.Split('.')[0] == cs_name)
						{

							treeview1.Nodes[i].Nodes.Add(new TreeNode(cl_shortname));
						}
					}
					i++;
				}
				

			}
			catch (BaseException e)
			{
				Console.WriteLine(e.Message);
			}


			//foreach(Customer customer2 in customerArray)
			//{
			//	treeview1.Nodes.Add(new TreeNode(customer2.CustomerName));

			//	// Add a child treenode for each Order object in the current Customer object.
			//	foreach(Order order1 in customer2.CustomerOrders)
			//	{
			//		treeview1.Nodes[customerArray.IndexOf(customer2)].Nodes.Add(new TreeNode(customer2.CustomerName + "." + order1.OrderID));
			//	}
			//}

			// Reset the cursor to the default for all controls.
			Cursor.Current = Cursors.Default;

			// Begin repainting the TreeView.
			treeview1.EndUpdate();

		}

	}
}
