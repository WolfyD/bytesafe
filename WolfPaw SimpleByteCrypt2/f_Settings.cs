﻿using System;
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
	public partial class f_Settings : Form
	{
		public f_Settings()
		{
			InitializeComponent();

			Load += F_Settings_Load;
		}

		private void F_Settings_Load(object sender, EventArgs e)
		{
			tb_Encoded.Text = Properties.Settings.Default.s_EncodedDir;
			tb_Decoded.Text = Properties.Settings.Default.s_DecodedDir;
			tb_ToEncrypt.Text = Properties.Settings.Default.s_ToEncryptDir;
			cb_AddDate.Checked = Properties.Settings.Default.s_DateToFilename;
			num_BufferSize.Value = Properties.Settings.Default.s_defaultBufferLength;

			cb_ShiftSections.Checked = Properties.Settings.Default.y_ShiftPasswordSections;
			cb_ShiftChars.Checked = Properties.Settings.Default.y_ShiftBytes;
			cb_HidePass.Checked = Properties.Settings.Default.y_HiddenPassword;
			cb_ChangeByteValues.Checked = Properties.Settings.Default.y_ShiftByteValues;

			cb_FileSize.Checked = Properties.Settings.Default.s_ShowFileSize;
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.s_EncodedDir = tb_Encoded.Text;
			Properties.Settings.Default.s_DecodedDir = tb_Decoded.Text;
			Properties.Settings.Default.s_ToEncryptDir = tb_ToEncrypt.Text;
			Properties.Settings.Default.s_DateToFilename = cb_AddDate.Checked;
			Properties.Settings.Default.s_defaultBufferLength = (int)num_BufferSize.Value;

			Properties.Settings.Default.y_ShiftPasswordSections = cb_ShiftSections.Checked;
			Properties.Settings.Default.y_ShiftBytes = cb_ShiftChars.Checked;
			Properties.Settings.Default.y_HiddenPassword = cb_HidePass.Checked;
			Properties.Settings.Default.y_ShiftByteValues = cb_ChangeByteValues.Checked;

			Properties.Settings.Default.s_ShowFileSize = cb_FileSize.Checked;

			Properties.Settings.Default.Save();
			this.Close();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_BrowseEncoded_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (tb_Encoded.Text != "" && Directory.Exists(tb_Encoded.Text)) { sfd.FileName = tb_Encoded.Text + "\\SELECT FOLDER"; }
			sfd.FileName = "SELECT FOLDER";
			sfd.CheckFileExists = false;
			sfd.Filter = "*.*|*.*";
			if(sfd.ShowDialog() == DialogResult.OK)
			{
				tb_Encoded.Text = Directory.GetParent(sfd.FileName).ToString();
			}
		}

		private void btn_BrowseDecoded_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (tb_Decoded.Text != "" && Directory.Exists(tb_Decoded.Text)) { sfd.FileName = tb_Decoded.Text + "\\SELECT FOLDER"; }
			sfd.FileName = "SELECT FOLDER";
			sfd.CheckFileExists = false;
			sfd.Filter = "*.*|*.*";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				tb_Decoded.Text = Directory.GetParent(sfd.FileName).ToString();
			}
		}

		private void btn_BrowseToEncrypt_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if(tb_ToEncrypt.Text != "" && Directory.Exists(tb_ToEncrypt.Text)) { sfd.FileName = tb_ToEncrypt.Text + "\\SELECT FOLDER"; }
			sfd.FileName = "SELECT FOLDER";
			sfd.CheckFileExists = false;
			sfd.Filter = "*.*|*.*";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				tb_ToEncrypt.Text = Directory.GetParent(sfd.FileName).ToString();
			}
		}
	}
}
