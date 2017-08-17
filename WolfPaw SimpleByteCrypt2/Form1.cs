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

		public Form1()
		{
			InitializeComponent();
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
				fileInput = ofd.FileName;
				lbl_Input.Text = fileInput;
				FileInfo fi = new FileInfo(fileInput);
				fileSize = fi.Length;

				try
				{
					pb_Progress.Value = 0;
					pb_Progress.Maximum = (int)fileSize;
				}
				catch
				{

				}

				fi = null;
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

		private void btn_Start_Click(object sender, EventArgs e)
		{
			codeKey = tb_Pwd.Text;
			decode = cb_Decode.Checked;

			if (fileInput != "" && File.Exists(fileInput) && fileOutput != "" && codeKey != "")
			{
				run = true;
				Thread t = new Thread(new ThreadStart(start));
				t.Start();
			}
		}

		public void start()
		{
            

			using(var r = new FileStream(fileInput,FileMode.Open))
			{
				byte[] buffer = new byte[1000000];
				if(buffer.Length > fileSize) { buffer = new byte[fileSize]; }
				string tmp = "";
				while (r.Read(buffer, 0, buffer.Length) > 0)
				{
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
								//while (tmpByte < 0) { tmpByte += 255; }
							}
							else
							{
								tmpByte = b + codeKey[x];
								//while (tmpByte > 255) { tmpByte -= 255; }
							}
							bytes[i] = (byte)tmpByte;
							i++;
							x++;
							//pb_Progress.Invoke(new mydelegate(incrementPB));
							if(x >= codeKey.Length) { x = 0; }
						}

						if (!File.Exists(fileOutput)) { File.Create(fileOutput).Close(); }

						using (var w = new FileStream(fileOutput, FileMode.Append,FileAccess.Write))
						{
							w.Write(bytes, 0, bytes.Length);
						}
						
					}
					catch(Exception ex)
					{
						Console.WriteLine(ex);

					}
				}

				MessageBox.Show("reading finished\r\n" + tmp);
			}
		}

		public delegate void mydelegate();
		public void incrementPB()
		{
			try
			{
				pb_Progress.Value++;
			}
			catch
			{

			}
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			run = false;
			Application.Exit();
		}
	}
}
