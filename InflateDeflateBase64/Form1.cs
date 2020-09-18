using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace InflateDeflateBase64
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnInflate_Click(object sender, EventArgs e)
		{
			string encoded = txtEncoded.Text.Trim();
			string xml = DecodeAndInflate(encoded);
			txtXml.Text = xml;
		}

		private void btnDeflate_Click(object sender, EventArgs e)
		{
			string xml = txtXml.Text.Trim();
			string deflated = DeflateAndEncode(xml);
			txtEncoded.Text = deflated;
		}

		private static string DeflateAndEncode(string str)
		{
			var bytes = Encoding.UTF8.GetBytes(str);
			using (var output = new MemoryStream())
			{
				using (var zip = new DeflateStream(output, CompressionMode.Compress))
				{
					zip.Write(bytes, 0, bytes.Length);
				}
				var base64 = Convert.ToBase64String(output.ToArray());

				return base64;
			}
		}

		private static string DecodeAndInflate(string str)
		{
			var utf8 = Encoding.UTF8;
			var bytes = Convert.FromBase64String(str);
			using (var output = new MemoryStream())
			{
				using (var input = new MemoryStream(bytes))
				{
					using (var unzip = new DeflateStream(input, CompressionMode.Decompress))
					{
						unzip.CopyTo(output, bytes.Length);
						unzip.Close();
					}
					return utf8.GetString(output.ToArray());
				}
			}
		}

		private void btnClearXml_Click(object sender, EventArgs e)
		{
			txtXml.Text = "";
		}

		private void btnClearEncoded_Click(object sender, EventArgs e)
		{
			txtEncoded.Text = "";
		}
	}
}
