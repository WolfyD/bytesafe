using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.Threading;

namespace WolfPaw_SimpleByteCrypt2
{
	public static class c_KeyFunctions
	{
		public static SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
		public static SHA512CryptoServiceProvider sha5 = new SHA512CryptoServiceProvider();
		public static int splitLength = 20;

		public static string generateFakeKey()
		{
			string FinalKey = "";
			string sha5s = "";
			List<string> sha5List0 = new List<string>();
			List<byte[]> sha1s = new List<byte[]>();

			List<string> ss = new List<string>();

			for (int i = 0; i < 8; i++)
			{
				Thread.Sleep(20);
				string tt = Environment.TickCount.ToString();
				ss.Add(new Random(Environment.TickCount + 1).Next(10000, 99999999) + tt.Substring(tt.Length - 5));
			}

			foreach (string s in ss)
			{
				sha5s += Encoding.UTF8.GetString(sha5.ComputeHash(Encoding.UTF8.GetBytes(s)));
			}

			int sha5len = sha5s.Length;
			int sha1wid = sha5len / 16;
			string shatmp = "";

			for (int i = 0; i < 16; i++)
			{
				if (sha5s == "") { break; }
				if (sha5s.Length >= sha1wid * 2)
				{
					shatmp = sha5s.Substring(0, sha1wid);
				}
				else
				{
					shatmp = sha5s.Substring(0);
				}

				sha5List0.Add(shatmp);
				sha5s = sha5s.Remove(0, shatmp.Length);
			}

			foreach (string s in sha5List0)
			{
				sha1s.Add(sha1.ComputeHash(Encoding.UTF8.GetBytes(s)));
			}

			foreach (byte[] bb in sha1s)
			{
				foreach (byte b in bb)
				{
					Thread.Sleep(1);
					int ii = new Random(Environment.TickCount).Next(0, 10000);
					FinalKey += ii < 5000 ? b.ToString("X2").ToUpper() : b.ToString("X2").ToLower();
				}
			}

			return FinalKey;
		}

		public static string generateKey(string tmp, int splitw)
		{
			string FinalKey = "";
			List<string> tmpList0 = new List<string>();
			string sha5s = "";
			List<string> sha5List0 = new List<string>();
			List<byte[]> sha1s = new List<byte[]>();

			string ttmp = "";

			for (int i = 0; i < 8; i++)
			{
				if (tmp == "") { break; }
				if (tmp.Length >= splitw * 2)
				{
					ttmp = tmp.Substring(0, splitw);
				}
				else
				{
					ttmp = tmp.Substring(0);
				}

				tmpList0.Add(ttmp);
				tmp = tmp.Remove(0, ttmp.Length);
			}

			foreach (string s in tmpList0)
			{
				sha5s += Encoding.UTF8.GetString(sha5.ComputeHash(Encoding.UTF8.GetBytes(s)));
			}

			int sha5len = sha5s.Length;
			int sha1wid = sha5len / 16;
			string shatmp = "";

			for (int i = 0; i < 16; i++)
			{
				if (sha5s == "") { break; }
				if (sha5s.Length >= sha1wid * 2)
				{
					shatmp = sha5s.Substring(0, sha1wid);
				}
				else
				{
					shatmp = sha5s.Substring(0);
				}

				sha5List0.Add(shatmp);
				sha5s = sha5s.Remove(0, shatmp.Length);
			}

			foreach (string s in sha5List0)
			{
				sha1s.Add(sha1.ComputeHash(Encoding.UTF8.GetBytes(s)));
			}

			foreach (byte[] bb in sha1s)
			{
				foreach (byte b in bb)
				{
					Thread.Sleep(2);
					int ii = new Random(Environment.TickCount).Next(0, 10000);
					FinalKey += ii < 5000 ? b.ToString("X2").ToUpper() : b.ToString("X2").ToLower();
				}
			}

			return FinalKey;
		}

		public static List<string> splitByNum(string s, int len)
		{
			List<string> l = new List<string>();
			if (s.Length % len == 0)
			{
				for (int i = 0; i < s.Length; i += len)
				{
					l.Add(s.Substring(i, len));
				}
			}

			return l;
		}

		public static string paritySwitch(string key)
		{
			string k2 = key;
			var list = splitByNum(k2, splitLength);
			k2 = "";
			string[] ls = list.ToArray();
			string tmp = "";

			for (int i = 0; i < ls.Length - 1; i++)
			{
				if (i % 2 == 0)
				{
					tmp = ls[i + 1];
					ls[i + 1] = ls[i];
					ls[i] = tmp;
				}
			}

			string tmp0 = ls[0], tmp1 = ls[1];

			ls[0] = ls[ls.Length - 2];
			ls[1] = ls[ls.Length - 1];

			ls[ls.Length - 2] = tmp0;
			ls[ls.Length - 1] = tmp1;

			foreach (String s in ls)
			{
				k2 += s;
			}

			return k2;
		}

		public static string parityFix(string key)
		{
			string k2 = key;
			var list = splitByNum(k2, splitLength);
			k2 = "";
			string[] ls = list.ToArray();
			string tmp = "";

			string tmp0 = ls[0], tmp1 = ls[1];

			ls[0] = ls[ls.Length - 2];
			ls[1] = ls[ls.Length - 1];

			ls[ls.Length - 2] = tmp0;
			ls[ls.Length - 1] = tmp1;

			for (int i = 0; i < ls.Length - 1; i++)
			{
				if (i % 2 == 0)
				{
					tmp = ls[i + 1];
					ls[i + 1] = ls[i];
					ls[i] = tmp;
				}
			}
			
			foreach (String s in ls)
			{
				k2 += s;
			}

			return k2;
		}

		public static string sectionShift(string key, bool left)
		{
			string k = "";
			var l = splitByNum(key, splitLength);
			
			string tmp0 = "", tmp1 = "";
			if (left)
			{
				tmp0 = l[0];
				tmp1 = l[1];
				l.Remove(l[0]);
				l.Remove(l[0]);
				l.Add(tmp0);
				l.Add(tmp1);
			}
			else
			{

			}

			return k;
		}

		/// <summary>
		/// Shift the whole string left|right by 3 characters
		/// </summary>
		public static string shiftString(string key, bool left)
		{
			if (left)
			{
				string l3 = key.Substring(0, 3);
				key = key.Remove(0, 3);
				key = key + l3;
			}
			else
			{
				string r3 = key.Substring(key.Length - 3, 3);
				key = key.Remove(key.Length - 3, 3);
				key = r3 + key;
			}

			return key;
		}

		public static string hideKey(string realKey, string fakeKey)
		{
			string newKey = "";

			for (int i = 0; i < realKey.Length; i += 2)
			{
				newKey += fakeKey.Substring(i, 2) + realKey.Substring(i, 2);
			}

			return newKey;
		}

		public static string getHiddenKey(string mixedKey)
		{
			string newKey = "";
			int ii = 0;
			for (int i = 0; i < mixedKey.Length; i += 2)
			{
				ii++;
				if (ii % 2 == 0)
				newKey += mixedKey.Substring(i, 2);
			}

			return newKey;
		}
	}
}
