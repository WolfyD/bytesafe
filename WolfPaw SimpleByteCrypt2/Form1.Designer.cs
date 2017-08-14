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
			this.btn_Input = new System.Windows.Forms.Button();
			this.btn_Output = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_Pwd = new System.Windows.Forms.TextBox();
			this.lbl_Input = new System.Windows.Forms.Label();
			this.lbl_Output = new System.Windows.Forms.Label();
			this.pb_Progress = new System.Windows.Forms.ProgressBar();
			this.btn_Start = new System.Windows.Forms.Button();
			this.btn_Stop = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_GSK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Input
			// 
			this.btn_Input.Location = new System.Drawing.Point(12, 12);
			this.btn_Input.Name = "btn_Input";
			this.btn_Input.Size = new System.Drawing.Size(75, 23);
			this.btn_Input.TabIndex = 0;
			this.btn_Input.Text = "Input";
			this.btn_Input.UseVisualStyleBackColor = true;
			// 
			// btn_Output
			// 
			this.btn_Output.Location = new System.Drawing.Point(12, 41);
			this.btn_Output.Name = "btn_Output";
			this.btn_Output.Size = new System.Drawing.Size(75, 23);
			this.btn_Output.TabIndex = 1;
			this.btn_Output.Text = "Output";
			this.btn_Output.UseVisualStyleBackColor = true;
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
			this.tb_Pwd.Location = new System.Drawing.Point(101, 73);
			this.tb_Pwd.Name = "tb_Pwd";
			this.tb_Pwd.Size = new System.Drawing.Size(346, 20);
			this.tb_Pwd.TabIndex = 3;
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
			// pb_Progress
			// 
			this.pb_Progress.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pb_Progress.Location = new System.Drawing.Point(0, 133);
			this.pb_Progress.Name = "pb_Progress";
			this.pb_Progress.Size = new System.Drawing.Size(592, 8);
			this.pb_Progress.TabIndex = 6;
			// 
			// btn_Start
			// 
			this.btn_Start.Location = new System.Drawing.Point(12, 104);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(75, 23);
			this.btn_Start.TabIndex = 7;
			this.btn_Start.Text = "Start";
			this.btn_Start.UseVisualStyleBackColor = true;
			// 
			// btn_Stop
			// 
			this.btn_Stop.Location = new System.Drawing.Point(93, 104);
			this.btn_Stop.Name = "btn_Stop";
			this.btn_Stop.Size = new System.Drawing.Size(75, 23);
			this.btn_Stop.TabIndex = 8;
			this.btn_Stop.Text = "Stop";
			this.btn_Stop.UseVisualStyleBackColor = true;
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(496, 104);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(75, 23);
			this.btn_Exit.TabIndex = 9;
			this.btn_Exit.Text = "Exit";
			this.btn_Exit.UseVisualStyleBackColor = true;
			// 
			// btn_GSK
			// 
			this.btn_GSK.Location = new System.Drawing.Point(453, 71);
			this.btn_GSK.Name = "btn_GSK";
			this.btn_GSK.Size = new System.Drawing.Size(118, 23);
			this.btn_GSK.TabIndex = 10;
			this.btn_GSK.Text = "Generate Secure Key";
			this.btn_GSK.UseVisualStyleBackColor = true;
			this.btn_GSK.Click += new System.EventHandler(this.btn_GSK_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 141);
			this.Controls.Add(this.btn_GSK);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.btn_Stop);
			this.Controls.Add(this.btn_Start);
			this.Controls.Add(this.pb_Progress);
			this.Controls.Add(this.lbl_Output);
			this.Controls.Add(this.lbl_Input);
			this.Controls.Add(this.tb_Pwd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Output);
			this.Controls.Add(this.btn_Input);
			this.Name = "Form1";
			this.Text = "Form1";
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
		private System.Windows.Forms.ProgressBar pb_Progress;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.Button btn_Stop;
		private System.Windows.Forms.Button btn_Exit;
		private System.Windows.Forms.Button btn_GSK;
	}
}

