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
		List<string> files { get; set; }

		public f_FileList()
		{
			InitializeComponent();

			Load += F_FileList_Load;
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

		private void cmd_onclick(object sender, EventArgs e)
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
