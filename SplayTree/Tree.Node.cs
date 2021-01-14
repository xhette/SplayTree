using System;
using System.Collections.Generic;
using System.Text;

namespace SplayTree
{
	public partial class Tree
	{
		public class Node
		{
			public int Value { get; private set; }

			public Node Parent { get; set; }

			public Node LeftChild { get; set; }

			public Node RightChild { get; set; }

			public Node (int value)
			{
				Value = value;
			}

			public Node (Node parent, int value)
			{
				Value = value;
				Parent = parent;
			}
		}
	}
}
