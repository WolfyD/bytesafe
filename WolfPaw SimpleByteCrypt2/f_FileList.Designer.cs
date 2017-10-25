namespace WolfPaw_SimpleByteCrypt2
{
	partial class f_FileList
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
			this.lv_List = new System.Windows.Forms.ListView();
			this.ch_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lv_List
			// 
			this.lv_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lv_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_FileName,
            this.ch_FileSize});
			this.lv_List.FullRowSelect = true;
			this.lv_List.GridLines = true;
			this.lv_List.Location = new System.Drawing.Point(1, 0);
			this.lv_List.Name = "lv_List";
			this.lv_List.Size = new System.Drawing.Size(514, 241);
			this.lv_List.TabIndex = 0;
			this.lv_List.UseCompatibleStateImageBehavior = false;
			this.lv_List.View = System.Windows.Forms.View.Details;
			// 
			// ch_FileName
			// 
			this.ch_FileName.Width = 327;
			// 
			// ch_FileSize
			// 
			this.ch_FileSize.Width = 182;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new System.Drawing.Point(0, 238);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(515, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// f_FileList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lv_List);
			this.Name = "f_FileList";
			this.Text = "f_FileList";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lv_List;
		private System.Windows.Forms.ColumnHeader ch_FileName;
		private System.Windows.Forms.ColumnHeader ch_FileSize;
		private System.Windows.Forms.Button button1;
	}
}