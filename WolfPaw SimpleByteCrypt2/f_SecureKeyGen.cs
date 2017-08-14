using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfPaw_SimpleByteCrypt2
{
	public partial class f_SecureKeyGen : Form
	{
		public Point lastMousePos = new Point();
		public Point MousePos = new Point();

		public List<Point> points = new List<Point>();
		public List<TimeSpan> times = new List<TimeSpan>();
		public List<TimeSpan> Clicktimes = new List<TimeSpan>();

		Stopwatch sw = new Stopwatch();
		Stopwatch Clicksw = new Stopwatch();


		public f_SecureKeyGen()
		{
			InitializeComponent();

			Load += F_SecureKeyGen_Load;
		}

		private void F_SecureKeyGen_Load(object sender, EventArgs e)
		{
			sw.Start();
			sw.Stop();
		}

		private void p_SKG_MouseMove(object sender, MouseEventArgs e)
		{
			lastMousePos = MousePos;
			MousePos = e.Location;

			using(Graphics g = Graphics.FromHwnd(p_SKG.Handle))
			{
				g.DrawLine(Pens.Red, lastMousePos, MousePos);
			}
		}

		private void p_SKG_MouseEnter(object sender, EventArgs e)
		{
			sw.Start();
			MousePos = PointToClient(Cursor.Position);
		}

		private void p_SKG_MouseLeave(object sender, EventArgs e)
		{
			sw.Stop();
			lastMousePos = PointToClient(Cursor.Position);
		}

		private void p_SKG_MouseClick(object sender, MouseEventArgs e)
		{
			points.Add(e.Location);
			Clicktimes.Add(Clicksw.Elapsed);
			Clicksw.Reset();
			Clicksw.Start();

			using (Graphics g = Graphics.FromHwnd(p_SKG.Handle))
			{
				Rectangle r = new Rectangle(e.Location.X - 20, e.Location.Y - 20, 40, 40);
				Rectangle r2 = new Rectangle(e.Location.X - 5, e.Location.Y - 5, 10, 10);

				g.DrawEllipse(Pens.Red, r);
				g.FillEllipse(Brushes.Red, r2);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			times.Add(sw.Elapsed);
			sw.Reset();
			sw.Start();
		}

		private void btn_GenKey_Click(object sender, EventArgs e)
		{
			timer1.Stop();

			string tmp = "";

			foreach(var v in times)
			{

				tmp += v.TotalMilliseconds.ToString().Substring(v.TotalMilliseconds.ToString().IndexOf(',') + 1);

			}

			MessageBox.Show(tmp);

			timer1.Start();
		}
	}
}
