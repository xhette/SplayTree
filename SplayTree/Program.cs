using System;
using System.Text;

namespace SplayTree
{
	class Program
	{
		static void Main(string[] args)
		{
			Tree tree = new Tree();

			int[] values = { 8, 6, 5, 1, 4, 12, 3, 16, 10, 9 };

			tree.Insert(values);

		}
	}
}
