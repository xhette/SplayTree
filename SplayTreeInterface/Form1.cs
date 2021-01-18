using SplayTree;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplayTreeInterface
{
	public partial class Form1 : Form
	{
		Tree tree;
		TreeDrawing drawing;

		public Form1()
		{
			InitializeComponent();
			tree = new Tree();

			//int[] values = { 8, 6, 5, 1, 4, 12, 3, 16, 10, 9, 20, 7, 13 };
			//tree.Insert(values);

			Draw();
		}

		private void search_Button_Click(object sender, EventArgs e)
		{
			SearchForm searchForm = new SearchForm(this);
			searchForm.ShowDialog(this);
		}

		private void delete_Button_Click(object sender, EventArgs e)
		{
			DeleteForm deleteForm = new DeleteForm(this);
			deleteForm.ShowDialog(this);
		}

		private void add_Button_Click(object sender, EventArgs e)
		{
			AddForm addForm = new AddForm(this);
			addForm.ShowDialog(this);
		}

		public void Add(int x)
		{
			tree.Insert(x);
			Draw();
		}

		public void Find(int x)
		{
			tree.Find(x);
			Draw();
		}

		public void Remove(int x)
		{
			tree.Remove(x);
			Draw();
		}

		private void Draw()
		{
			drawing = new TreeDrawing(tree);
			drawing.Clear();
			drawing.Draw(tree.Root, drawing.Bitmap.Width / 2, 30, true);

			pictureBox1.Height = drawing.Bitmap.Height;
			pictureBox1.Width = drawing.Bitmap.Width;

			pictureBox1.Image = drawing.Bitmap;
		}

		private void clear_Button_Click(object sender, EventArgs e)
		{
			tree = new Tree();
			Draw();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			GraphLarge graph = new GraphLarge(drawing.Bitmap);
			graph.Show();
		}
	}
}
