using SplayTree;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using static SplayTree.Tree;

namespace SplayTreeInterface
{
	public class TreeDrawing
	{
		private const int _radius = 15;

		private Tree _tree;

		public Bitmap Bitmap { get; private set; }
		Graphics graphic;

		private Pen black;
		Brush whiteFill;
		Brush blackFill;
		Font font;

		public TreeDrawing(Tree tree)
		{
			_tree = tree;

			black = new Pen(Color.Black);
			black.Width = 2;
			font = new Font("Times New Roman", (int)Math.Floor(_radius / 1.5));
			whiteFill = Brushes.WhiteSmoke;
			blackFill = Brushes.Black;

			Bitmap = new Bitmap(BitmapWidth(), BitmapHeight());
			graphic = Graphics.FromImage(Bitmap);
		}

		private int LevelsCount()
		{
			var nodes = _tree.GetWidthWithLevels().GroupBy(c => c.Value).Select(n => new
			{
				Level = n.Key,
				Count = n.Count()
			}).ToList();

			return nodes.Count();
		}

		private int LastLevelNodesCount()
		{
			int count = LevelsCount();

			if (count > 0)
			{
				return Convert.ToInt32(Math.Pow(2, count));
			}
			else
			{
				return 0;
			}
		}

		private int BitmapWidth()
		{
			int count = LastLevelNodesCount();
			if (count > 0)
			{
				int width = count * _radius + 2 * _radius;

				if (width > 668)
				{
					return width;
				}
			}
				return 668;
		}

		private int BitmapHeight()
		{
			int count = LevelsCount();
			if (count > 0)
			{
				int height = _radius * (3 + 2 * count);

				if (height > 426)
				{
					return height;
				}
			}
				return 426;
			
		}

		private void DrawVertex(Node node, int x, int y)
		{
			var point = new PointF(x - _radius, y - _radius);

			if (node != null)
			{
				graphic.FillEllipse(whiteFill, x - _radius, y - _radius, 2 * _radius, 2 * _radius);
				graphic.DrawEllipse(black, x - _radius, y - _radius, 2 * _radius, 2 * _radius);

				var pointNull = new PointF(x - _radius, y - _radius / 2);
				graphic.DrawString(node.Value.ToString(), font, blackFill, pointNull);
			}
		}

		private void DrawEdge(int x1, int y1, int x2, int y2)
		{
			PointF p1 = new PointF(x1, y1);
			PointF p2 = new PointF(x2, y2);

			graphic.DrawLine(black, p1, p2);
		}

		public void Clear()
		{
			graphic.Clear(Color.WhiteSmoke);
		}

		public void Draw(Node node, int x, int y, bool isroot = false, int k = 0)
		{
			if (node != null)
			{
				if (k == 0)
				{
					k = Bitmap.Width / 4;
				}

				if (node.LeftChild != null)
				{
					DrawEdge(x, y, x - k, y + 3 * _radius);
					Draw(node.LeftChild, x - k, y + 3 * _radius, false, k / 2);
				}
				if (node.RightChild != null)
				{
					DrawEdge(x, y, x + k, y + 3 * _radius);
					Draw(node.RightChild, x + k, y + 3 * _radius, false, k / 2);
				}
				

				DrawVertex(node, x, y);
			}
		}
	}
}
