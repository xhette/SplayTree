using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplayTreeInterface
{
	public partial class GraphLarge : Form
	{
		public GraphLarge(Bitmap bitmap)
		{
			InitializeComponent();
			this.Height = bitmap.Height + 57;
			this.Width = bitmap.Width;

			pictureBox1.Height = bitmap.Height;
			pictureBox1.Width = bitmap.Width;
			pictureBox1.Image = bitmap;
		}
	}
}
