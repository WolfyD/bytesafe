using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfPaw_SimpleByteCrypt2
{
	public partial class Form1 : Form
	{
		String fileInput = "";
		String fileOutput = "";
		String codeKey = "";
		byte[] shifter = { 0, 1, 1, 0 };
		long fileSize = 0;
		bool run = false;
		bool decode = false;
		List<string> files = new List<string>();

		public Form1()
		{
			InitializeComponent();

			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			String lastKey = Properties.Settings.Default.s_LastKey;
			if(lastKey != "" && File.Exists(lastKey))
			{
				openKey(lastKey);
			}
		}

		private void btn_GSK_Click(object sender, EventArgs e)
		{
			f_SecureKeyGen fskg = new f_SecureKeyGen();
			fskg.ShowDialog();
            if (fskg.OK && fskg.generatedKey != "")
            {
                string f = "#==========START OF WOLFPAW SECURE KEY==========#\r\n" + fskg.generatedKey + "\r\n#===========END OF WOLFPAW SECURE KEY===========#";
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save your secure key file";
                sfd.Filter = "WolfPaw Secure Key  (*.wsk)|*.wsk|" + "Text file  (*.txt)|*.txt|" + "All Files  (*.*)|*.*";
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, f);
                }
            }
		}

		private void btn_Input_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Title = "Select your input file";

			if(ofd.ShowDialog() == DialogResult.OK)
			{
				openFile(ofd.FileName);
			}
		}

		public void openFile(String fn)
		{
			files.Add(fn);
			setLabels();
		}

		public void setLabels()
		{
			if (files.Count == 1)
			{
				lbl_Input.Text = files[0];
			}
			else
			{
				lbl_Input.Text = files.Count + " files";
			}
		}

		private void btn_Output_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Select the name and location of your output file";
			if(fileInput != "") { sfd.FileName = fileInput.Substring(fileInput.LastIndexOf("\\") + 1); }

			if(sfd.ShowDialog() == DialogResult.OK)
			{
				fileOutput = sfd.FileName;
				lbl_Output.Text = fileOutput;
			}
		}

		public string getfn(string fn)
		{
			fn = fn.Substring(fn.LastIndexOf("\\") + 1);
			return fn;
		}

		private void btn_Start_Click(object sender, EventArgs e)
		{
			if (cb_Decode.Checked)
			{
				if(Properties.Settings.Default.s_DecodedDir == "" || !Directory.Exists(Properties.Settings.Default.s_DecodedDir))
				{ MessageBox.Show("It seems that you haven't filled out your Decode output directory.\r\nPlease make sure you do.","Check your settings!"); button1_Click(null, null); return; }
			}
			else
			{
				if (Properties.Settings.Default.s_EncodedDir == "" || !Directory.Exists(Properties.Settings.Default.s_EncodedDir))
				{ MessageBox.Show("It seems that you haven't filled out your Encode output directory.\r\nPlease make sure you do.", "Check your settings!"); button1_Click(null, null); return; }
			}
			foreach (String s in files)
			{
				if (File.Exists(s))
				{
					string fo = "";
					if (cb_Decode.Checked)
					{
						fo = Properties.Settings.Default.s_DecodedDir + "\\" + getfn(s);
					}
					else
					{
						fo = Properties.Settings.Default.s_EncodedDir + "\\" + getfn(s);
					}

					//fileInput = s;

					_start(s, fo);
				}
			}
		}

		public void _start(string s, string outs)
		{
			codeKey = tb_Pwd.Text;
			decode = cb_Decode.Checked;

			if (s != "" && File.Exists(s) && outs != "" && codeKey != "")
			{
				run = true;
				Thread t = new Thread(() => start(s, outs));
				t.Start();
			}
		}

		public void start(string input, string output)
		{
			using(var r = new FileStream(input,FileMode.Open))
			{
				long mainBufferLen = Properties.Settings.Default.s_defaultBufferLength;
				long _len = r.Length;
				long preLen = 0;

				byte[] buffer = new byte[1];
				
				if (preLen + mainBufferLen > _len) { buffer = new byte[_len]; }
				else { buffer = new byte[mainBufferLen]; }

				string tmp = "";
				while (true)
				{
					GC.Collect();
					preLen += buffer.Length;
                    int len = r.Read(buffer, 0, buffer.Length);

                    if(len == 0)
                    {
                        break;
                    }

                    try
					{
                        var chars = (IEnumerable<byte>)buffer;
						byte[] bytes = new byte[chars.Count()];
						int tmpByte = 0;
						//tmp += new string(((IEnumerable<char>)buffer).ToArray());	--AZT A KURVA EZ GYORS VOLT....

						int i = 0;
						int x = 0;

						foreach(byte b in chars)
						{
							if (decode)
							{
								tmpByte = b - codeKey[x];
							}
							else
							{
								tmpByte = b + codeKey[x];
							}
							bytes[i] = (byte)tmpByte;
							i++;
							x++;
							//pb_Progress.Invoke(new mydelegate(incrementPB));
							if(x >= codeKey.Length) { x = 0; }
						}

						if (!File.Exists(output)) { File.Create(output).Close(); }

						using (var w = new FileStream(output, FileMode.Append,FileAccess.Write))
						{
							w.Write(bytes, 0, bytes.Length);
						}
						bytes = null;
						chars = null;
						GC.Collect(100, GCCollectionMode.Forced, true);
					}
					catch(Exception ex)
					{
						Console.WriteLine(ex);
					}
				}

				MessageBox.Show("reading finished\r\n" + tmp);
			}
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			run = false;
			Application.Exit();
		}

		public void openKey(String fn)
		{
			string[] f = File.ReadAllLines(fn);
			foreach (String s in f)
			{
				if (s.Length > 0 && !s.StartsWith("#"))
				{
					tb_Pwd.Text += s.Trim();
				}
			}
		}

        private void btn_OpenKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
				openKey(ofd.FileName);
				Properties.Settings.Default.s_LastKey = ofd.FileName;
				Properties.Settings.Default.Save();
            }
        }

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				String[] ss = (string[])e.Data.GetData(DataFormats.FileDrop);
				string s = "";
				foreach (String x in ss)
				{
					if (File.Exists(x))
					{
						files.Add(x);
					}
					else if (Directory.Exists(x))
					{
						files.AddRange(Directory.GetFiles(x, "*.*", SearchOption.AllDirectories));
					}
				}
			}
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if(e.Data.GetData(DataFormats.FileDrop) != null)
			{
				String s = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				if (s.Substring(s.LastIndexOf(".") + 1).ToLower() != "wsk")
				{
					e.Effect = DragDropEffects.All;
				}
			}
		}

		private void tb_Pwd_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(DataFormats.FileDrop) != null)
			{
				String s = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				if (s.Substring(s.LastIndexOf(".") + 1).ToLower() == "wsk")
				{
					e.Effect = DragDropEffects.All;
				}
			}
		}

		private void tb_Pwd_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(DataFormats.FileDrop) != null)
			{
				String s = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
				if (s.Substring(s.LastIndexOf(".") + 1).ToLower() == "wsk")
				{
					openKey(s);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			f_Settings fs = new f_Settings();
			fs.ShowDialog();
		}

		private void btn_MultipleFiles_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Multiselect = true;
			ofd.Title = "Select your input file";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				files = ofd.FileNames.ToList();
				setLabels();
			}
		}

		private void btn_Directory_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				files = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories).ToList();
				setLabels();
			}
		}

		private void btn_OpenMulti_Click(object sender, EventArgs e)
		{
			contextMenuStrip1.Show(btn_OpenMulti, new Point(0, 0));
		}

		private void btn_FileList_Click(object sender, EventArgs e)
		{
			if (files.Count > 0)
			{
				f_FileList fl = new f_FileList();
				fl.files = files;
				fl.ShowDialog();
				files = fl.files;
				setLabels();
			}
		}
	}
}
