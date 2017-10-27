using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfPaw_SimpleByteCrypt2
{
	public partial class f_SecureKeyGen : Form
	{
		Point lastMousePos = new Point();
		Point MousePos = new Point();

		List<Point> points = new List<Point>();
		List<TimeSpan> times = new List<TimeSpan>();
		List<TimeSpan> Clicktimes = new List<TimeSpan>();

        public string generatedKey = "";
        public bool OK = false;

        SHA512CryptoServiceProvider sha5 = new SHA512CryptoServiceProvider();
        SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

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

            lbl_XYZ.Text = "X: " + e.Location.X + " Y:" + e.Location.Y + " Clicks:" + points.Count();
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
            times.Add(sw.Elapsed);
            sw.Reset();
            sw.Start();
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
            int rr = new Random().Next(0, 30);
			Thread.Sleep(1);
			int rr2 = new Random().Next(0, 30);

            int xx = new Random(Environment.TickCount).Next(0, 1000) < 501 ? rr : rr * -1;
            Thread.Sleep(10);
            int yy = new Random(Environment.TickCount + 1).Next(0, 1000) > 500 ? rr2 : rr2 * -1;

            points.Add(PointToClient(new Point(Cursor.Position.X + rr, Cursor.Position.Y + rr)));

            using (Graphics g = Graphics.FromHwnd(p_SKG.Handle))
            {
                var ee = PointToClient(Cursor.Position);
                
                Rectangle r = new Rectangle(ee.X + xx - 5, ee.Y + yy - 5, 10, 10);
                Rectangle r2 = new Rectangle(ee.X + xx - 2, ee.Y + yy - 2, 4, 4);

                g.DrawEllipse(Pens.Blue, r);
                g.FillEllipse(Brushes.Blue, r2);

                g.DrawLine(Pens.Blue, new Point(ee.X + xx, ee.Y + yy), new Point(ee.X + xx + 1, ee.Y + yy + 1));
            }
        }

		private void btn_GenKey_Click(object sender, EventArgs e)
		{
			timer1.Stop();

			string tmp = "";

            foreach (var v in times)
            {
                tmp += v.TotalMilliseconds.ToString().Substring(v.TotalMilliseconds.ToString().IndexOf(',') + 1);
            }
            foreach (var v in points)
            {
                tmp += v.X + "" + v.Y;
            }
            foreach (var v in Clicktimes)
            {
                tmp += v.TotalMilliseconds.ToString().Substring(v.TotalMilliseconds.ToString().IndexOf(',') + 1);
            }
			

            int tLen = tmp.Length;
            int splitw = tLen / 8;


			generatedKey = c_KeyFunctions.generateKey(tmp, splitw);

			if (Properties.Settings.Default.y_MixPass)
			{
				generatedKey = c_KeyFunctions.paritySwitch(generatedKey);
			}
			if (Properties.Settings.Default.y_ShiftPasswordSections)
			{
				//generatedKey = c_KeyFunctions.
			}

            btn_UseKey.Enabled = true;

            timer1.Start();
		}

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            generatedKey = "";
            OK = false;
            this.Close();
        }

        private void btn_UseKey_Click(object sender, EventArgs e)
        {
            OK = true;
            this.Close();
        }
    }
}
