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
		bool run = false;
		bool decode = false;
		String generatedKey = "";
		List<string> files = new List<string>();

		int allFilesLength = 0;
		int finishedFiles = 0;

		public Form1()
		{
			InitializeComponent();

			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			String lastKey = Properties.Settings.Default.s_LastKey;
			if (lastKey != "" && File.Exists(lastKey))
			{
				openKey(lastKey);
			}

			cb_EncodeDecode.SelectedIndex = 0;
		}

		public string getKeySettings()
		{
			string ret = "";

			passKeySettings pks = new passKeySettings();

			ret += Properties.Settings.Default.y_ShiftByteValues ? pks.keyVal1_FF : pks.keyVal1_00;
			ret += Properties.Settings.Default.y_HiddenPassword ? pks.keyVal2_FF : pks.keyVal2_00;
			ret += Properties.Settings.Default.y_ShiftBytes ? pks.keyVal3_FF : pks.keyVal3_00;
			ret += Properties.Settings.Default.y_ShiftPasswordSections ? pks.keyVal4_FF : pks.keyVal4_00;
			ret += pks.keyValsEnd;

			return ret;
		}

		private void btn_GSK_Click(object sender, EventArgs e)
		{
			f_SecureKeyGen fskg = new f_SecureKeyGen();
			fskg.ShowDialog();
			if (fskg.OK && fskg.generatedKey != "")
			{
				string f = "#==========START OF WOLFPAW SECURE KEY==========#\r\n" + getKeySettings() + fskg.generatedKey + "\r\n#===========END OF WOLFPAW SECURE KEY===========#";
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Title = "Save your secure key file";
				sfd.Filter = "WolfPaw Secure Key  (*.wsk)|*.wsk|" + "Text file  (*.txt)|*.txt|" + "All Files  (*.*)|*.*";
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(sfd.FileName, f);
				}
			}
		}

		private void btn_Input_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.Title = "Select your input file";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				openFile(ofd.FileName);
			}
		}

		public void openFile(String fn)
		{
			files.Add(fn);
		}

		private void btn_Output_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Title = "Select the name and location of your output file";
			if (fileInput != "") { sfd.FileName = fileInput.Substring(fileInput.LastIndexOf("\\") + 1); }

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				fileOutput = sfd.FileName;
			}
		}

		public string getfn(string fn)
		{
			fn = fn.Substring(fn.LastIndexOf("\\") + 1);
			return fn;
		}

		public string getKeySettingsDecode(string key, out string settings)
		{
			string ret = "";
			string set = "";

			ret = key;
			ret = ret.Substring(ret.IndexOf("F0F0") + 4);
			set = key.Substring(0, key.IndexOf("F0F0") + 4);

			settings = set;
			return ret;
		}

		public string[] revealKeySettings(string set)
		{
			String[] settings = new string[4];
			settings[0] = set.Substring(0, 10);
			set = set.Substring(10);
			settings[1] = set.Substring(0, 10);
			set = set.Substring(10);
			settings[2] = set.Substring(0, 10);
			set = set.Substring(10);
			settings[3] = set.Substring(0, 10);
			set = set.Substring(10);

			if (set == "F0F0")
			{
				return settings;
			} else
			{
				return null;
			}
		}

		public void getPassword()
		{
			string settings = "";
			generatedKey = getKeySettingsDecode(generatedKey, out settings);
			string[] __Settings = revealKeySettings(settings);

			passKeySettings psk = new passKeySettings();

			if (__Settings != null)
			{
				if (__Settings[0] == psk.keyVal1_FF)
				{
					generatedKey = c_KeyFunctions.shiftValues(generatedKey, false);
				}
				if (__Settings[1] == psk.keyVal2_FF)
				{
					generatedKey = c_KeyFunctions.getHiddenKey(generatedKey);
				}
				if (__Settings[2] == psk.keyVal3_FF)
				{
					generatedKey = c_KeyFunctions.shiftString(generatedKey, false);
				}
				if (__Settings[3] == psk.keyVal4_FF)
				{
					generatedKey = c_KeyFunctions.sectionShift(generatedKey, false);
				}
			}
			else
			{
				if (Properties.Settings.Default.y_ShiftByteValues)
				{
					generatedKey = c_KeyFunctions.shiftValues(generatedKey, false);
				}
				if (Properties.Settings.Default.y_HiddenPassword)
				{
					generatedKey = c_KeyFunctions.getHiddenKey(generatedKey);
				}
				if (Properties.Settings.Default.y_ShiftBytes)
				{
					generatedKey = c_KeyFunctions.shiftString(generatedKey, false);
				}
				if (Properties.Settings.Default.y_ShiftPasswordSections)
				{
					generatedKey = c_KeyFunctions.sectionShift(generatedKey, false);
				}
			}
			generatedKey = c_KeyFunctions.parityFix(generatedKey);

		}

		public bool decrypt = false;

		private void btn_Start_Click(object sender, EventArgs e)
		{
			run = !run;
			allFilesLength = files.Count;
			pb_Progress.Value = 0;
			pb_Progress.Maximum = allFilesLength;

			if (run)
			{
				btn_Start.Text = "Stop";
			} else
			{
				btn_Start.Text = "Start";
			}

			decrypt = cb_EncodeDecode.SelectedIndex == 1;

			if (tb_Pwd.Text != "")
			{
				generatedKey = tb_Pwd.Text;
				getPassword();
			}

			if (decrypt)
			{
				if (Properties.Settings.Default.s_DecodedDir == "" || !Directory.Exists(Properties.Settings.Default.s_DecodedDir))
				{ MessageBox.Show("It seems that you haven't filled out your Decode output directory.\r\nPlease make sure you do.", "Check your settings!"); button1_Click(null, null); return; }
			}
			else
			{
				if (Properties.Settings.Default.s_EncodedDir == "" || !Directory.Exists(Properties.Settings.Default.s_EncodedDir))
				{ MessageBox.Show("It seems that you haven't filled out your Encode output directory.\r\nPlease make sure you do.", "Check your settings!"); button1_Click(null, null); return; }
			}

			run = true;

			Thread tt = new Thread(new ThreadStart(_start));
			tt.Start();
		}


		public void _start()
		{
			foreach (String s in files)
			{
				if (File.Exists(s))
				{
					string fo = "";
					if (decrypt)
					{
						fo = Properties.Settings.Default.s_DecodedDir + "\\" + getfn(s);
					}
					else
					{
						fo = Properties.Settings.Default.s_EncodedDir + "\\" + getfn(s);
					}

					//fileInput = s;

					codeKey = generatedKey;
					decode = decrypt;

					if (s != "" && File.Exists(s) && fo != "" && codeKey != "")
					{
						Thread t = new Thread(() => start(s, fo));
						t.Start();
					}
				}
			}
		}

		public void start(string input, string output)
		{
			using (var r = new FileStream(input, FileMode.Open))
			{
				long mainBufferLen = Properties.Settings.Default.s_defaultBufferLength;
				long _len = r.Length;
				long preLen = 0;

				byte[] buffer = new byte[1];

				if (preLen + mainBufferLen > _len) { buffer = new byte[_len]; }
				else { buffer = new byte[mainBufferLen]; }

				string tmp = "";
				while (run)
				{
					GC.Collect();
					preLen += buffer.Length;
					int len = r.Read(buffer, 0, buffer.Length);

					if (len == 0)
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

						foreach (byte b in chars)
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
							if (x >= codeKey.Length) { x = 0; }
						}

						if (!File.Exists(output)) { File.Create(output).Close(); }

						using (var w = new FileStream(output, FileMode.Append, FileAccess.Write))
						{
							w.Write(bytes, 0, bytes.Length);
						}
						bytes = null;
						chars = null;
						GC.Collect(100, GCCollectionMode.Forced, true);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex);
					}
				}

				finishedFiles++;

				if (finishedFiles == allFilesLength)
				{
					this.Invoke(new afterrun(after_run));
				}
				else
				{
					this.Invoke(new afterrun(while_run));
				}
			}
		}

		public delegate void afterrun();
		public void after_run()
		{
			btn_Start.Text = "Start";
			pb_Progress.Value = pb_Progress.Maximum;
			MessageBox.Show("Work is finished");
			run = false;
		}
		public void while_run()
		{
			try
			{
				pb_Progress.Value = finishedFiles;
			}
			catch { pb_Progress.Value = pb_Progress.Maximum; }
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			run = false;
			Application.Exit();
		}

		public void openKey(String fn)
		{
			tb_Pwd.Text = "";
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
			ofd.Filter = "WolfPaw Secure Key Files|*.wsk|All Files|*.*";
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
				foreach (String x in ss)
				{
					if (File.Exists(x))
					{
						if (!files.Contains(x))
						{
							files.Add(x);
						}
					}
					else if (Directory.Exists(x))
					{
						foreach (String s in Directory.GetFiles(x, "*.*", SearchOption.AllDirectories))
						{
							if (!files.Contains(s))
							{
								files.Add(s);
							}
						}
					}
				}

				setupFileList();
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
			}
			setupFileList();
		}

		private void btn_Directory_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				files = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories).ToList();
				setupFileList();
			}
		}
		
		private void btn_Test_Click(object sender, EventArgs e)
		{
			string rk = c_KeyFunctions.generateFakeKey();

			Console.WriteLine("----------ORIGINAL KEY----------\r\n" + rk + "\r\n(--------------------------------\r\n");

			string fk = c_KeyFunctions.generateFakeKey();
			string key = c_KeyFunctions.paritySwitch(rk);
			key = c_KeyFunctions.sectionShift(key, true);
			key = c_KeyFunctions.shiftString(key, true);
			key = c_KeyFunctions.hideKey(key, fk);
			key = c_KeyFunctions.shiftValues(key, true);

			Console.WriteLine("----------FULLY HIDDEN KEY----------\r\n" + key + "\r\n------------------------------------\r\n");

			key = c_KeyFunctions.shiftValues(key, false);
			key = c_KeyFunctions.getHiddenKey(key);
			key = c_KeyFunctions.shiftString(key, false);
			key = c_KeyFunctions.sectionShift(key, false);
			key = c_KeyFunctions.parityFix(key);

			Console.WriteLine("----------RECOVERED KEY----------\r\n" + key + "\r\n---------------------------------\r\n");
			
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(e.Location);
			}
		}

		private void btn_OpenFiles_Click(object sender, EventArgs e)
		{
			btn_MultipleFiles_Click(null, null);
		}

		private void btn_OpenFolder_Click(object sender, EventArgs e)
		{
			btn_Directory_Click(null, null);
		}

		private void btn_Settings_Click(object sender, EventArgs e)
		{
			button1_Click(null, null);
		}

		private void btn_GenerateKey_Click(object sender, EventArgs e)
		{
			btn_GSK_Click(null, null);
		}

		public void setupFileList()
		{
			lv_List.Items.Clear();
			pb_Progress.Value = 0;

			bool fs = Properties.Settings.Default.s_ShowFileSize;

			long i = 0;
			float ii = 0;
			float iii = 0;

			foreach (String s in files)
			{
				if (File.Exists(s))
				{
					ListViewItem lvi = new ListViewItem();
					lvi.Text = s;
					lvi.Tag = s;
					lvi.UseItemStyleForSubItems = false;

					if (fs)
					{
						using (var r = File.OpenRead(s))
						{
							i = r.Length;
							ii = (i * 1.0f) / (1024 * 1.0f);
							iii = (ii * 1.0f) / (1024 * 1.0f);

							lvi.SubItems.Add(
								i.ToString().PadRight(12, ' ') + " / " +
								((ii.ToString().Length > 4) ? ii.ToString().Substring(0, 4) : ii.ToString().PadRight(4,' ')) + " / " +
								((iii.ToString().Length > 4) ? iii.ToString().Substring(0, 4) : iii.ToString().PadRight(4, ' ')));
						}
					}
					else
					{
						lvi.SubItems.Add("- / - / -");
					}

					lvi.SubItems[1].Font = new Font("Consolas", 10, FontStyle.Regular);
					lvi.BackColor = lv_List.Items.Count % 2 == 0 ? Color.LightYellow : Color.LightBlue;
					lvi.SubItems[1].BackColor = lvi.BackColor;
					lv_List.Items.Add(lvi);
				}
			}
		}

		private void lv_List_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (lv_List.FocusedItem != null)
				{
					cms_List.Show(lv_List,e.Location);
				}
			}
		}

		private void btn_RemoveSelectedFiles_Click(object sender, EventArgs e)
		{
			if(lv_List.SelectedItems.Count > 0)
			{
				foreach(ListViewItem lvi in lv_List.SelectedItems)
				{
					files.Remove(lvi.Tag.ToString());
				}
			}

			setupFileList();
		}

		private void btn_ClearAllFiles_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem lvi in lv_List.Items)
			{
				files.Remove(lvi.Tag.ToString());
			}

			setupFileList();
		}

		private void btn_ClearFileList_Click(object sender, EventArgs e)
		{
			files.Clear();
			setupFileList();
		}

		private void btn_Open_DropDownOpening(object sender, EventArgs e)
		{
			string toe = Properties.Settings.Default.s_ToEncryptDir;
			string enc = Properties.Settings.Default.s_EncodedDir;
			string dec = Properties.Settings.Default.s_DecodedDir;

			if (toe == "" || !Directory.Exists(toe)) { btn_OpenToEncrypt.Enabled = false; } else { btn_OpenToEncrypt.Enabled = true; }
			if (enc == "" || !Directory.Exists(enc)) { btn_OpenEncrypted.Enabled = false; } else { btn_OpenEncrypted.Enabled = true; }
			if (dec == "" || !Directory.Exists(dec)) { btn_OpenDecrypted.Enabled = false; } else { btn_OpenDecrypted.Enabled = true; }
		}

		private void btn_Browse_DropDownOpening(object sender, EventArgs e)
		{
			string toe = Properties.Settings.Default.s_ToEncryptDir;
			string enc = Properties.Settings.Default.s_EncodedDir;
			string dec = Properties.Settings.Default.s_DecodedDir;

			if (toe == "" || !Directory.Exists(toe)) { btn_BrowseToEncrypt.Enabled = false; } else { btn_BrowseToEncrypt.Enabled = true; }
			if (enc == "" || !Directory.Exists(enc)) { btn_BrowseEncrypted.Enabled = false; } else { btn_BrowseEncrypted.Enabled = true; }
			if (dec == "" || !Directory.Exists(dec)) { btn_BrowseDecrypted.Enabled = false; } else { btn_BrowseDecrypted.Enabled = true; }
		}

		private void btn_OpenToEncrypt_Click(object sender, EventArgs e)
		{
			files = Directory.GetFiles(Properties.Settings.Default.s_ToEncryptDir, "*.*", SearchOption.AllDirectories).ToList();
			setupFileList();
		}

		private void btn_OpenEncrypted_Click(object sender, EventArgs e)
		{
			files = Directory.GetFiles(Properties.Settings.Default.s_EncodedDir, "*.*", SearchOption.AllDirectories).ToList();
			setupFileList();
		}

		private void btn_OpenDecrypted_Click(object sender, EventArgs e)
		{
			files = Directory.GetFiles(Properties.Settings.Default.s_DecodedDir, "*.*", SearchOption.AllDirectories).ToList();
			setupFileList();
		}

		private void btn_BrowseToEncrypt_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Properties.Settings.Default.s_ToEncryptDir);
		}

		private void btn_BrowseEncrypted_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Properties.Settings.Default.s_EncodedDir);
		}

		private void btn_BrowseDecrypted_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start(Properties.Settings.Default.s_DecodedDir);
		}
	}

	public class passKeySettings
	{
		public string keyVal1_FF = "7A690D4575";
		public string keyVal2_FF = "2744867136";
		public string keyVal3_FF = "028641390F";
		public string keyVal4_FF = "3692882096";

		public string keyVal1_00 = "310B86E0B6";
		public string keyVal2_00 = "9F9AF02958";
		public string keyVal3_00 = "E26973E6EE";
		public string keyVal4_00 = "AB7F7B9553";

		public string keyValsEnd = "F0F0";

	}
}
