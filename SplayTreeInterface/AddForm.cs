﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SplayTreeInterface
{
	public partial class AddForm : Form
	{
		Form1 parent;

		public AddForm(Form1 parent)
		{
			InitializeComponent();
			this.parent = parent;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int x = 0;

			if (int.TryParse(textBox1.Text, out x))
			{
				parent.Add(x);
				this.Close();
			}
		}
	}
}
