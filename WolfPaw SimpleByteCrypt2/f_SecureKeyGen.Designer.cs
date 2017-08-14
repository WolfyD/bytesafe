namespace WolfPaw_SimpleByteCrypt2
{
	partial class f_SecureKeyGen
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
			this.p_SKG = new System.Windows.Forms.Panel();
			this.lbl_CurrentKey = new System.Windows.Forms.Label();
			this.lbl_XYZ = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_UseKey = new System.Windows.Forms.Button();
			this.btn_GenKey = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// p_SKG
			// 
			this.p_SKG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.p_SKG.BackColor = System.Drawing.Color.LightGray;
			this.p_SKG.Location = new System.Drawing.Point(2, 1);
			this.p_SKG.Name = "p_SKG";
			this.p_SKG.Size = new System.Drawing.Size(734, 510);
			this.p_SKG.TabIndex = 0;
			this.p_SKG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_SKG_MouseClick);
			this.p_SKG.MouseEnter += new System.EventHandler(this.p_SKG_MouseEnter);
			this.p_SKG.MouseLeave += new System.EventHandler(this.p_SKG_MouseLeave);
			this.p_SKG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p_SKG_MouseMove);
			// 
			// lbl_CurrentKey
			// 
			this.lbl_CurrentKey.AutoSize = true;
			this.lbl_CurrentKey.Location = new System.Drawing.Point(5, 517);
			this.lbl_CurrentKey.Name = "lbl_CurrentKey";
			this.lbl_CurrentKey.Size = new System.Drawing.Size(13, 13);
			this.lbl_CurrentKey.TabIndex = 1;
			this.lbl_CurrentKey.Text = "::";
			// 
			// lbl_XYZ
			// 
			this.lbl_XYZ.AutoSize = true;
			this.lbl_XYZ.Location = new System.Drawing.Point(5, 542);
			this.lbl_XYZ.Name = "lbl_XYZ";
			this.lbl_XYZ.Size = new System.Drawing.Size(13, 13);
			this.lbl_XYZ.TabIndex = 2;
			this.lbl_XYZ.Text = "::";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(651, 537);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 3;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// btn_UseKey
			// 
			this.btn_UseKey.Location = new System.Drawing.Point(560, 537);
			this.btn_UseKey.Name = "btn_UseKey";
			this.btn_UseKey.Size = new System.Drawing.Size(75, 23);
			this.btn_UseKey.TabIndex = 4;
			this.btn_UseKey.Text = "Use Key";
			this.btn_UseKey.UseVisualStyleBackColor = true;
			// 
			// btn_GenKey
			// 
			this.btn_GenKey.Location = new System.Drawing.Point(330, 537);
			this.btn_GenKey.Name = "btn_GenKey";
			this.btn_GenKey.Size = new System.Drawing.Size(211, 23);
			this.btn_GenKey.TabIndex = 5;
			this.btn_GenKey.Text = "Generate key from current Data";
			this.btn_GenKey.UseVisualStyleBackColor = true;
			this.btn_GenKey.Click += new System.EventHandler(this.btn_GenKey_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// f_SecureKeyGen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 568);
			this.Controls.Add(this.btn_GenKey);
			this.Controls.Add(this.btn_UseKey);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.lbl_XYZ);
			this.Controls.Add(this.lbl_CurrentKey);
			this.Controls.Add(this.p_SKG);
			this.Name = "f_SecureKeyGen";
			this.Text = "WolfPaw Secure Key Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel p_SKG;
		private System.Windows.Forms.Label lbl_CurrentKey;
		private System.Windows.Forms.Label lbl_XYZ;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_UseKey;
		private System.Windows.Forms.Button btn_GenKey;
		private System.Windows.Forms.Timer timer1;
	}
}