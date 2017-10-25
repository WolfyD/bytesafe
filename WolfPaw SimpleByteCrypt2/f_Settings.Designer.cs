namespace WolfPaw_SimpleByteCrypt2
{
	partial class f_Settings
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Settings));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tb_Encoded = new System.Windows.Forms.TextBox();
			this.tb_Decoded = new System.Windows.Forms.TextBox();
			this.cb_AddDate = new System.Windows.Forms.CheckBox();
			this.num_BufferSize = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_BrowseDecoded = new System.Windows.Forms.Button();
			this.btn_BrowseEncoded = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_BufferSize)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Encoded Directory:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Decoded Directory: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Add Date to save files:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Default buffer size: ";
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(15, 194);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 4;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(396, 194);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 5;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_BrowseDecoded);
			this.groupBox1.Controls.Add(this.btn_BrowseEncoded);
			this.groupBox1.Controls.Add(this.cb_AddDate);
			this.groupBox1.Controls.Add(this.tb_Decoded);
			this.groupBox1.Controls.Add(this.tb_Encoded);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(459, 132);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Handling of multiple files";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.num_BufferSize);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(12, 140);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(459, 48);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Misc";
			// 
			// tb_Encoded
			// 
			this.tb_Encoded.Location = new System.Drawing.Point(136, 26);
			this.tb_Encoded.Name = "tb_Encoded";
			this.tb_Encoded.Size = new System.Drawing.Size(283, 20);
			this.tb_Encoded.TabIndex = 3;
			// 
			// tb_Decoded
			// 
			this.tb_Decoded.Location = new System.Drawing.Point(136, 62);
			this.tb_Decoded.Name = "tb_Decoded";
			this.tb_Decoded.Size = new System.Drawing.Size(283, 20);
			this.tb_Decoded.TabIndex = 4;
			// 
			// cb_AddDate
			// 
			this.cb_AddDate.AutoSize = true;
			this.cb_AddDate.Location = new System.Drawing.Point(136, 101);
			this.cb_AddDate.Name = "cb_AddDate";
			this.cb_AddDate.Size = new System.Drawing.Size(15, 14);
			this.cb_AddDate.TabIndex = 5;
			this.cb_AddDate.UseVisualStyleBackColor = true;
			// 
			// num_BufferSize
			// 
			this.num_BufferSize.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.num_BufferSize.Location = new System.Drawing.Point(136, 16);
			this.num_BufferSize.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.num_BufferSize.Name = "num_BufferSize";
			this.num_BufferSize.Size = new System.Drawing.Size(137, 25);
			this.num_BufferSize.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(279, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "bytes";
			// 
			// btn_BrowseDecoded
			// 
			this.btn_BrowseDecoded.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BrowseDecoded.BackgroundImage")));
			this.btn_BrowseDecoded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_BrowseDecoded.Location = new System.Drawing.Point(425, 60);
			this.btn_BrowseDecoded.Name = "btn_BrowseDecoded";
			this.btn_BrowseDecoded.Size = new System.Drawing.Size(28, 23);
			this.btn_BrowseDecoded.TabIndex = 7;
			this.btn_BrowseDecoded.UseVisualStyleBackColor = true;
			this.btn_BrowseDecoded.Click += new System.EventHandler(this.btn_BrowseDecoded_Click);
			// 
			// btn_BrowseEncoded
			// 
			this.btn_BrowseEncoded.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BrowseEncoded.BackgroundImage")));
			this.btn_BrowseEncoded.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_BrowseEncoded.Location = new System.Drawing.Point(425, 24);
			this.btn_BrowseEncoded.Name = "btn_BrowseEncoded";
			this.btn_BrowseEncoded.Size = new System.Drawing.Size(28, 23);
			this.btn_BrowseEncoded.TabIndex = 6;
			this.btn_BrowseEncoded.UseVisualStyleBackColor = true;
			this.btn_BrowseEncoded.Click += new System.EventHandler(this.btn_BrowseEncoded_Click);
			// 
			// f_Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 229);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Name = "f_Settings";
			this.Text = "f_Settings";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_BufferSize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cb_AddDate;
		private System.Windows.Forms.TextBox tb_Decoded;
		private System.Windows.Forms.TextBox tb_Encoded;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_BrowseEncoded;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown num_BufferSize;
		private System.Windows.Forms.Button btn_BrowseDecoded;
	}
}