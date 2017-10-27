﻿namespace WolfPaw_SimpleByteCrypt2
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.btn_Input = new System.Windows.Forms.Button();
			this.btn_Output = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_Pwd = new System.Windows.Forms.TextBox();
			this.lbl_Input = new System.Windows.Forms.Label();
			this.lbl_Output = new System.Windows.Forms.Label();
			this.btn_Start = new System.Windows.Forms.Button();
			this.btn_Stop = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_GSK = new System.Windows.Forms.Button();
			this.cb_Decode = new System.Windows.Forms.CheckBox();
			this.btn_OpenKey = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btn_OpenMulti = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_MultipleFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Directory = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_FileList = new System.Windows.Forms.Button();
			this.btn_Test = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Input
			// 
			this.btn_Input.Location = new System.Drawing.Point(12, 12);
			this.btn_Input.Name = "btn_Input";
			this.btn_Input.Size = new System.Drawing.Size(57, 23);
			this.btn_Input.TabIndex = 0;
			this.btn_Input.Text = "Input";
			this.btn_Input.UseVisualStyleBackColor = true;
			this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
			// 
			// btn_Output
			// 
			this.btn_Output.Location = new System.Drawing.Point(12, 41);
			this.btn_Output.Name = "btn_Output";
			this.btn_Output.Size = new System.Drawing.Size(75, 23);
			this.btn_Output.TabIndex = 1;
			this.btn_Output.Text = "Output";
			this.btn_Output.UseVisualStyleBackColor = true;
			this.btn_Output.Click += new System.EventHandler(this.btn_Output_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Password: ";
			// 
			// tb_Pwd
			// 
			this.tb_Pwd.AllowDrop = true;
			this.tb_Pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Pwd.Location = new System.Drawing.Point(101, 70);
			this.tb_Pwd.Multiline = true;
			this.tb_Pwd.Name = "tb_Pwd";
			this.tb_Pwd.Size = new System.Drawing.Size(440, 24);
			this.tb_Pwd.TabIndex = 3;
			this.tb_Pwd.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_Pwd_DragDrop);
			this.tb_Pwd.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_Pwd_DragEnter);
			// 
			// lbl_Input
			// 
			this.lbl_Input.AutoSize = true;
			this.lbl_Input.Location = new System.Drawing.Point(98, 17);
			this.lbl_Input.Name = "lbl_Input";
			this.lbl_Input.Size = new System.Drawing.Size(10, 13);
			this.lbl_Input.TabIndex = 4;
			this.lbl_Input.Text = "-";
			// 
			// lbl_Output
			// 
			this.lbl_Output.AutoSize = true;
			this.lbl_Output.Location = new System.Drawing.Point(98, 46);
			this.lbl_Output.Name = "lbl_Output";
			this.lbl_Output.Size = new System.Drawing.Size(10, 13);
			this.lbl_Output.TabIndex = 5;
			this.lbl_Output.Text = "-";
			// 
			// btn_Start
			// 
			this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Start.Location = new System.Drawing.Point(12, 108);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(75, 23);
			this.btn_Start.TabIndex = 7;
			this.btn_Start.Text = "Start";
			this.btn_Start.UseVisualStyleBackColor = true;
			this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
			// 
			// btn_Stop
			// 
			this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Stop.Location = new System.Drawing.Point(93, 108);
			this.btn_Stop.Name = "btn_Stop";
			this.btn_Stop.Size = new System.Drawing.Size(75, 23);
			this.btn_Stop.TabIndex = 8;
			this.btn_Stop.Text = "Stop";
			this.btn_Stop.UseVisualStyleBackColor = true;
			// 
			// btn_Exit
			// 
			this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Exit.Location = new System.Drawing.Point(672, 108);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(75, 23);
			this.btn_Exit.TabIndex = 9;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_GSK
			// 
			this.btn_GSK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_GSK.Location = new System.Drawing.Point(547, 71);
			this.btn_GSK.Name = "btn_GSK";
			this.btn_GSK.Size = new System.Drawing.Size(118, 23);
			this.btn_GSK.TabIndex = 10;
			this.btn_GSK.Text = "Generate Secure Key";
			this.btn_GSK.UseVisualStyleBackColor = true;
			this.btn_GSK.Click += new System.EventHandler(this.btn_GSK_Click);
			// 
			// cb_Decode
			// 
			this.cb_Decode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_Decode.AutoSize = true;
			this.cb_Decode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cb_Decode.Location = new System.Drawing.Point(702, 2);
			this.cb_Decode.Name = "cb_Decode";
			this.cb_Decode.Size = new System.Drawing.Size(64, 17);
			this.cb_Decode.TabIndex = 11;
			this.cb_Decode.Text = "Decode";
			this.cb_Decode.UseVisualStyleBackColor = true;
			// 
			// btn_OpenKey
			// 
			this.btn_OpenKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_OpenKey.Location = new System.Drawing.Point(671, 70);
			this.btn_OpenKey.Name = "btn_OpenKey";
			this.btn_OpenKey.Size = new System.Drawing.Size(76, 23);
			this.btn_OpenKey.TabIndex = 12;
			this.btn_OpenKey.Text = "Open File";
			this.btn_OpenKey.UseVisualStyleBackColor = true;
			this.btn_OpenKey.Click += new System.EventHandler(this.btn_OpenKey_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(547, 108);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "Settings";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_OpenMulti
			// 
			this.btn_OpenMulti.Location = new System.Drawing.Point(67, 12);
			this.btn_OpenMulti.Name = "btn_OpenMulti";
			this.btn_OpenMulti.Size = new System.Drawing.Size(20, 23);
			this.btn_OpenMulti.TabIndex = 14;
			this.btn_OpenMulti.Text = "↓";
			this.btn_OpenMulti.UseVisualStyleBackColor = true;
			this.btn_OpenMulti.Click += new System.EventHandler(this.btn_OpenMulti_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_MultipleFiles,
            this.btn_Directory});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(175, 48);
			// 
			// btn_MultipleFiles
			// 
			this.btn_MultipleFiles.Name = "btn_MultipleFiles";
			this.btn_MultipleFiles.Size = new System.Drawing.Size(174, 22);
			this.btn_MultipleFiles.Text = "Open multiple files";
			this.btn_MultipleFiles.Click += new System.EventHandler(this.btn_MultipleFiles_Click);
			// 
			// btn_Directory
			// 
			this.btn_Directory.Name = "btn_Directory";
			this.btn_Directory.Size = new System.Drawing.Size(174, 22);
			this.btn_Directory.Text = "Open directory";
			this.btn_Directory.Click += new System.EventHandler(this.btn_Directory_Click);
			// 
			// btn_FileList
			// 
			this.btn_FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_FileList.Location = new System.Drawing.Point(466, 108);
			this.btn_FileList.Name = "btn_FileList";
			this.btn_FileList.Size = new System.Drawing.Size(75, 23);
			this.btn_FileList.TabIndex = 16;
			this.btn_FileList.Text = "File List";
			this.btn_FileList.UseVisualStyleBackColor = true;
			this.btn_FileList.Click += new System.EventHandler(this.btn_FileList_Click);
			// 
			// btn_Test
			// 
			this.btn_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Test.Location = new System.Drawing.Point(331, 110);
			this.btn_Test.Name = "btn_Test";
			this.btn_Test.Size = new System.Drawing.Size(75, 23);
			this.btn_Test.TabIndex = 17;
			this.btn_Test.Text = "TEST";
			this.btn_Test.UseVisualStyleBackColor = true;
			this.btn_Test.Visible = false;
			this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 143);
			this.Controls.Add(this.btn_Test);
			this.Controls.Add(this.btn_FileList);
			this.Controls.Add(this.btn_OpenMulti);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_OpenKey);
			this.Controls.Add(this.cb_Decode);
			this.Controls.Add(this.btn_GSK);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Stop);
			this.Controls.Add(this.btn_Start);
			this.Controls.Add(this.lbl_Output);
			this.Controls.Add(this.lbl_Input);
			this.Controls.Add(this.tb_Pwd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Output);
			this.Controls.Add(this.btn_Input);
			this.MinimumSize = new System.Drawing.Size(425, 182);
			this.Name = "Form1";
			this.Text = "WolfPaw Simple Keyed Byte Encryption";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Input;
		private System.Windows.Forms.Button btn_Output;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_Pwd;
		private System.Windows.Forms.Label lbl_Input;
		private System.Windows.Forms.Label lbl_Output;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.Button btn_Stop;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_GSK;
		private System.Windows.Forms.CheckBox cb_Decode;
        private System.Windows.Forms.Button btn_OpenKey;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_OpenMulti;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btn_MultipleFiles;
		private System.Windows.Forms.ToolStripMenuItem btn_Directory;
		private System.Windows.Forms.Button btn_FileList;
		private System.Windows.Forms.Button btn_Test;
	}
}

