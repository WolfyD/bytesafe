using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfPaw_SimpleByteCrypt2
{
	public partial class f_FileList : Form
	{
		public List<string> files { get; set; }

		public f_FileList()
		{
			InitializeComponent();

			Load += F_FileList_Load;

			lv_List.MouseClick += Lv_List_MouseClick;
		}

		private void Lv_List_MouseClick(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				if(lv_List.FocusedItem != null)
				{
					((myLVI)lv_List.FocusedItem).showcms();
				}
			}
		}

		private void F_FileList_Load(object sender, EventArgs e)
		{
			foreach (String s in files)
			{
				using (var r = File.OpenRead(s))
				{
					long i = r.Length;

					myLVI lvi = new myLVI();
					lvi.parent = lv_List;
					lvi.index = files.IndexOf(s);
					lvi.files = files;
					lvi.Text = s;
					lvi.SubItems.Add(i + "");
					lv_List.Items.Add(lvi);
				}
			}
		}
		
	}

	public partial class myLVI : ListViewItem
	{
		ContextMenuStrip cms = new ContextMenuStrip();
		public ListView parent { get; set; }
		public List<string> files { get; set; }
		public int index { get; set; }
		public myLVI()
		{
			cms.Items.Add("Remove File", null, cmd_onclick);
		}

		public void showcms()
		{
			cms.Show(parent, 0, 0);
		}

		public void cmd_onclick(object sender, EventArgs e)
		{
			try
			{
				parent.Items.Remove(this);
				files.RemoveAt(index);
			}
			catch { }
		}
	}
}
