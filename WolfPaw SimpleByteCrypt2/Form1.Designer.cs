namespace WolfPaw_SimpleByteCrypt2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.tb_Pwd = new System.Windows.Forms.TextBox();
			this.btn_Start = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_OpenKey = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_MultipleFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Directory = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Test = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_OpenFiles = new System.Windows.Forms.ToolStripButton();
			this.btn_OpenFolder = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Open = new System.Windows.Forms.ToolStripSplitButton();
			this.btn_OpenToEncrypt = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_OpenEncrypted = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_OpenDecrypted = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Browse = new System.Windows.Forms.ToolStripSplitButton();
			this.btn_BrowseToEncrypt = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_BrowseEncrypted = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_BrowseDecrypted = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cb_EncodeDecode = new System.Windows.Forms.ToolStripComboBox();
			this.btn_Settings = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_GenerateKey = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_ClearFileList = new System.Windows.Forms.ToolStripButton();
			this.lv_List = new System.Windows.Forms.ListView();
			this.ch_Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label2 = new System.Windows.Forms.Label();
			this.cms_List = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_RemoveSelectedFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_ClearAllFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.pb_Progress = new System.Windows.Forms.ProgressBar();
			this.lbl_NumOfFiles = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.cms_List.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 213);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Password: ";
			// 
			// tb_Pwd
			// 
			this.tb_Pwd.AllowDrop = true;
			this.tb_Pwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Pwd.Location = new System.Drawing.Point(101, 207);
			this.tb_Pwd.Multiline = true;
			this.tb_Pwd.Name = "tb_Pwd";
			this.tb_Pwd.Size = new System.Drawing.Size(733, 24);
			this.tb_Pwd.TabIndex = 3;
			this.tb_Pwd.DragDrop += new System.Windows.Forms.DragEventHandler(this.tb_Pwd_DragDrop);
			this.tb_Pwd.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_Pwd_DragEnter);
			// 
			// btn_Start
			// 
			this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Start.Location = new System.Drawing.Point(12, 245);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(75, 23);
			this.btn_Start.TabIndex = 7;
			this.btn_Start.Text = "Start";
			this.btn_Start.UseVisualStyleBackColor = true;
			this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
			// 
			// btn_Exit
			// 
			this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Exit.Location = new System.Drawing.Point(841, 245);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(75, 23);
			this.btn_Exit.TabIndex = 9;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
			// 
			// btn_OpenKey
			// 
			this.btn_OpenKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_OpenKey.Location = new System.Drawing.Point(840, 207);
			this.btn_OpenKey.Name = "btn_OpenKey";
			this.btn_OpenKey.Size = new System.Drawing.Size(76, 23);
			this.btn_OpenKey.TabIndex = 12;
			this.btn_OpenKey.Text = "Open File";
			this.btn_OpenKey.UseVisualStyleBackColor = true;
			this.btn_OpenKey.Click += new System.EventHandler(this.btn_OpenKey_Click);
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
			// btn_Test
			// 
			this.btn_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Test.Location = new System.Drawing.Point(759, 245);
			this.btn_Test.Name = "btn_Test";
			this.btn_Test.Size = new System.Drawing.Size(75, 23);
			this.btn_Test.TabIndex = 17;
			this.btn_Test.Text = "TEST";
			this.btn_Test.UseVisualStyleBackColor = true;
			this.btn_Test.Visible = false;
			this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_OpenFiles,
            this.btn_OpenFolder,
            this.toolStripSeparator4,
            this.btn_Open,
            this.btn_Browse,
            this.toolStripSeparator1,
            this.cb_EncodeDecode,
            this.btn_Settings,
            this.toolStripSeparator2,
            this.btn_GenerateKey,
            this.toolStripSeparator3,
            this.btn_ClearFileList});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(937, 25);
			this.toolStrip1.TabIndex = 18;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_OpenFiles
			// 
			this.btn_OpenFiles.Image = global::WolfPaw_SimpleByteCrypt2.Properties.Resources.openfile;
			this.btn_OpenFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_OpenFiles.Name = "btn_OpenFiles";
			this.btn_OpenFiles.Size = new System.Drawing.Size(90, 22);
			this.btn_OpenFiles.Text = "Open File(s)";
			this.btn_OpenFiles.Click += new System.EventHandler(this.btn_OpenFiles_Click);
			// 
			// btn_OpenFolder
			// 
			this.btn_OpenFolder.Image = global::WolfPaw_SimpleByteCrypt2.Properties.Resources.folder_magnify;
			this.btn_OpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_OpenFolder.Name = "btn_OpenFolder";
			this.btn_OpenFolder.Size = new System.Drawing.Size(92, 22);
			this.btn_OpenFolder.Text = "Open Folder";
			this.btn_OpenFolder.Click += new System.EventHandler(this.btn_OpenFolder_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_Open
			// 
			this.btn_Open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_OpenToEncrypt,
            this.btn_OpenEncrypted,
            this.btn_OpenDecrypted});
			this.btn_Open.Image = global::WolfPaw_SimpleByteCrypt2.Properties.Resources.browse_folder;
			this.btn_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Open.Name = "btn_Open";
			this.btn_Open.Size = new System.Drawing.Size(65, 22);
			this.btn_Open.Text = "Load";
			this.btn_Open.DropDownOpening += new System.EventHandler(this.btn_Open_DropDownOpening);
			// 
			// btn_OpenToEncrypt
			// 
			this.btn_OpenToEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenToEncrypt.Image")));
			this.btn_OpenToEncrypt.Name = "btn_OpenToEncrypt";
			this.btn_OpenToEncrypt.Size = new System.Drawing.Size(131, 22);
			this.btn_OpenToEncrypt.Text = "To Encrypt";
			this.btn_OpenToEncrypt.Click += new System.EventHandler(this.btn_OpenToEncrypt_Click);
			// 
			// btn_OpenEncrypted
			// 
			this.btn_OpenEncrypted.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenEncrypted.Image")));
			this.btn_OpenEncrypted.Name = "btn_OpenEncrypted";
			this.btn_OpenEncrypted.Size = new System.Drawing.Size(131, 22);
			this.btn_OpenEncrypted.Text = "Encrypted";
			this.btn_OpenEncrypted.Click += new System.EventHandler(this.btn_OpenEncrypted_Click);
			// 
			// btn_OpenDecrypted
			// 
			this.btn_OpenDecrypted.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenDecrypted.Image")));
			this.btn_OpenDecrypted.Name = "btn_OpenDecrypted";
			this.btn_OpenDecrypted.Size = new System.Drawing.Size(131, 22);
			this.btn_OpenDecrypted.Text = "Decrypted";
			this.btn_OpenDecrypted.Click += new System.EventHandler(this.btn_OpenDecrypted_Click);
			// 
			// btn_Browse
			// 
			this.btn_Browse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_BrowseToEncrypt,
            this.btn_BrowseEncrypted,
            this.btn_BrowseDecrypted});
			this.btn_Browse.Image = global::WolfPaw_SimpleByteCrypt2.Properties.Resources.folder_go;
			this.btn_Browse.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Browse.Name = "btn_Browse";
			this.btn_Browse.Size = new System.Drawing.Size(77, 22);
			this.btn_Browse.Text = "Browse";
			this.btn_Browse.DropDownOpening += new System.EventHandler(this.btn_Browse_DropDownOpening);
			// 
			// btn_BrowseToEncrypt
			// 
			this.btn_BrowseToEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("btn_BrowseToEncrypt.Image")));
			this.btn_BrowseToEncrypt.Name = "btn_BrowseToEncrypt";
			this.btn_BrowseToEncrypt.Size = new System.Drawing.Size(131, 22);
			this.btn_BrowseToEncrypt.Text = "To Encrypt";
			this.btn_BrowseToEncrypt.Click += new System.EventHandler(this.btn_BrowseToEncrypt_Click);
			// 
			// btn_BrowseEncrypted
			// 
			this.btn_BrowseEncrypted.Image = ((System.Drawing.Image)(resources.GetObject("btn_BrowseEncrypted.Image")));
			this.btn_BrowseEncrypted.Name = "btn_BrowseEncrypted";
			this.btn_BrowseEncrypted.Size = new System.Drawing.Size(131, 22);
			this.btn_BrowseEncrypted.Text = "Encrypted";
			this.btn_BrowseEncrypted.Click += new System.EventHandler(this.btn_BrowseEncrypted_Click);
			// 
			// btn_BrowseDecrypted
			// 
			this.btn_BrowseDecrypted.Image = ((System.Drawing.Image)(resources.GetObject("btn_BrowseDecrypted.Image")));
			this.btn_BrowseDecrypted.Name = "btn_BrowseDecrypted";
			this.btn_BrowseDecrypted.Size = new System.Drawing.Size(131, 22);
			this.btn_BrowseDecrypted.Text = "Decrypted";
			this.btn_BrowseDecrypted.Click += new System.EventHandler(this.btn_BrowseDecrypted_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// cb_EncodeDecode
			// 
			this.cb_EncodeDecode.AutoSize = false;
			this.cb_EncodeDecode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_EncodeDecode.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
			this.cb_EncodeDecode.Items.AddRange(new object[] {
            "Encrypt",
            "Decrypt"});
			this.cb_EncodeDecode.Name = "cb_EncodeDecode";
			this.cb_EncodeDecode.Size = new System.Drawing.Size(80, 23);
			// 
			// btn_Settings
			// 
			this.btn_Settings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btn_Settings.Image = global::WolfPaw_SimpleByteCrypt2.Properties.Resources.settings;
			this.btn_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Settings.Margin = new System.Windows.Forms.Padding(10, 1, 5, 2);
			this.btn_Settings.Name = "btn_Settings";
			this.btn_Settings.Size = new System.Drawing.Size(69, 22);
			this.btn_Settings.Text = "Options";
			this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_GenerateKey
			// 
			this.btn_GenerateKey.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btn_GenerateKey.Image = global::WolfPaw_SimpleByteCrypt2.Properties.Resources.key;
			this.btn_GenerateKey.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_GenerateKey.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
			this.btn_GenerateKey.Name = "btn_GenerateKey";
			this.btn_GenerateKey.Size = new System.Drawing.Size(134, 22);
			this.btn_GenerateKey.Text = "Generate Secure Key";
			this.btn_GenerateKey.Click += new System.EventHandler(this.btn_GenerateKey_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// btn_ClearFileList
			// 
			this.btn_ClearFileList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btn_ClearFileList.Image = global::WolfPaw_SimpleByteCrypt2.Properties.Resources.clear1;
			this.btn_ClearFileList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_ClearFileList.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
			this.btn_ClearFileList.Name = "btn_ClearFileList";
			this.btn_ClearFileList.Size = new System.Drawing.Size(96, 22);
			this.btn_ClearFileList.Text = "Clear File List";
			this.btn_ClearFileList.Click += new System.EventHandler(this.btn_ClearFileList_Click);
			// 
			// lv_List
			// 
			this.lv_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Filename,
            this.ch_Size});
			this.lv_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lv_List.FullRowSelect = true;
			this.lv_List.GridLines = true;
			this.lv_List.Location = new System.Drawing.Point(101, 45);
			this.lv_List.Name = "lv_List";
			this.lv_List.Size = new System.Drawing.Size(815, 156);
			this.lv_List.TabIndex = 19;
			this.lv_List.UseCompatibleStateImageBehavior = false;
			this.lv_List.View = System.Windows.Forms.View.Details;
			this.lv_List.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_List_MouseClick);
			// 
			// ch_Filename
			// 
			this.ch_Filename.Text = "File Name";
			this.ch_Filename.Width = 512;
			// 
			// ch_Size
			// 
			this.ch_Size.Text = "File Size (B / KB / MB)";
			this.ch_Size.Width = 193;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Files: ";
			// 
			// cms_List
			// 
			this.cms_List.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_RemoveSelectedFiles,
            this.btn_ClearAllFiles});
			this.cms_List.Name = "cms_List";
			this.cms_List.Size = new System.Drawing.Size(188, 48);
			// 
			// btn_RemoveSelectedFiles
			// 
			this.btn_RemoveSelectedFiles.Name = "btn_RemoveSelectedFiles";
			this.btn_RemoveSelectedFiles.Size = new System.Drawing.Size(187, 22);
			this.btn_RemoveSelectedFiles.Text = "Remove selected files";
			this.btn_RemoveSelectedFiles.Click += new System.EventHandler(this.btn_RemoveSelectedFiles_Click);
			// 
			// btn_ClearAllFiles
			// 
			this.btn_ClearAllFiles.Name = "btn_ClearAllFiles";
			this.btn_ClearAllFiles.Size = new System.Drawing.Size(187, 22);
			this.btn_ClearAllFiles.Text = "Clear all files";
			this.btn_ClearAllFiles.Click += new System.EventHandler(this.btn_ClearAllFiles_Click);
			// 
			// pb_Progress
			// 
			this.pb_Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pb_Progress.Location = new System.Drawing.Point(0, 272);
			this.pb_Progress.Name = "pb_Progress";
			this.pb_Progress.Size = new System.Drawing.Size(937, 10);
			this.pb_Progress.TabIndex = 21;
			// 
			// lbl_NumOfFiles
			// 
			this.lbl_NumOfFiles.AutoSize = true;
			this.lbl_NumOfFiles.Location = new System.Drawing.Point(9, 68);
			this.lbl_NumOfFiles.Name = "lbl_NumOfFiles";
			this.lbl_NumOfFiles.Size = new System.Drawing.Size(39, 26);
			this.lbl_NumOfFiles.TabIndex = 22;
			this.lbl_NumOfFiles.Text = "0 Files\r\nloaded";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(937, 280);
			this.Controls.Add(this.lbl_NumOfFiles);
			this.Controls.Add(this.pb_Progress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lv_List);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.btn_Test);
			this.Controls.Add(this.btn_OpenKey);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Start);
			this.Controls.Add(this.tb_Pwd);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(425, 182);
			this.Name = "Form1";
			this.Text = "WolfPaw Simple Keyed Byte Encryption";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.cms_List.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_Pwd;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_OpenKey;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btn_MultipleFiles;
		private System.Windows.Forms.ToolStripMenuItem btn_Directory;
		private System.Windows.Forms.Button btn_Test;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_OpenFiles;
		private System.Windows.Forms.ToolStripButton btn_OpenFolder;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox cb_EncodeDecode;
		private System.Windows.Forms.ToolStripButton btn_Settings;
		private System.Windows.Forms.ListView lv_List;
		private System.Windows.Forms.ColumnHeader ch_Filename;
		private System.Windows.Forms.ColumnHeader ch_Size;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btn_GenerateKey;
		private System.Windows.Forms.ContextMenuStrip cms_List;
		private System.Windows.Forms.ToolStripMenuItem btn_RemoveSelectedFiles;
		private System.Windows.Forms.ToolStripMenuItem btn_ClearAllFiles;
		private System.Windows.Forms.ToolStripButton btn_ClearFileList;
		private System.Windows.Forms.ProgressBar pb_Progress;
		private System.Windows.Forms.ToolStripSplitButton btn_Open;
		private System.Windows.Forms.ToolStripMenuItem btn_OpenToEncrypt;
		private System.Windows.Forms.ToolStripMenuItem btn_OpenEncrypted;
		private System.Windows.Forms.ToolStripMenuItem btn_OpenDecrypted;
		private System.Windows.Forms.ToolStripSplitButton btn_Browse;
		private System.Windows.Forms.ToolStripMenuItem btn_BrowseToEncrypt;
		private System.Windows.Forms.ToolStripMenuItem btn_BrowseEncrypted;
		private System.Windows.Forms.ToolStripMenuItem btn_BrowseDecrypted;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.Label lbl_NumOfFiles;
	}
}

