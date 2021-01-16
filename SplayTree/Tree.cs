using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SplayTree
{
	public partial class Tree
	{
		public Node Root { get; private set; }

		//private Dictionary<Node, int> _widthWithLevels;

		public Tree() 
		{
			//_widthWithLevels = new Dictionary<Node, int>();
		}

		public Tree(Node root)
		{
			Root = root;
			//_widthWithLevels = new Dictionary<Node, int>();
		}

		public Tree(int value)
		{
			Root = new Node(value);
			//_widthWithLevels = new Dictionary<Node, int>();
		}

		public void Insert (int x)
		{
			if (Root == null)
			{
				Root = new Node(x);
			}
			else
			{
				Node parent = null;
				Node node = Root;

				while (node != null)
				{
					parent = node;
					if (x < node.Value)
					{
						node = node.LeftChild;
					}
					else if (x > node.Value)
					{
						node = node.RightChild;
					}
					else
					{
						throw new Exception ("Данное значение уже содержится в дереве");
					}
				}

				Node newNode = new Node(parent, x);

				if (x < parent.Value)
				{
					parent.LeftChild = newNode;
				}
				else if (x > parent.Value)
				{
					parent.RightChild = newNode;
				}

				Splay(newNode);
			}
		}

		public void Find (int x)
		{
			Node result = Root;

			if (Root != null)
			{
				while (result.Value != x)
				{
					if (x < result.Value)
					{
						if (result.LeftChild != null)
						{
							result = result.LeftChild;
						}
						else
						{
							throw new Exception("Значение не принадлежит дереву");
						}
					}
					else if (x > result.Value)
					{
						if (result.RightChild != null)
						{
							result = result.RightChild;
						}
						else
						{
							throw new Exception("Значение не принадлежит дереву");
						}
					}
				}

				Splay(result);
			}
		}

		public void Remove (int x)
		{
			Find(x);

			Node leftTree = Root.LeftChild;
			Node rightTree = Root.RightChild;

			Node maxLeft = leftTree;

			while (maxLeft.RightChild != null)
			{
				maxLeft = maxLeft.RightChild;
			}

			Splay (maxLeft);

			Root.RightChild = rightTree;
		}

		private void RotateLeft(Node node)
		{
			Node parent = node.Parent;
			Node rightChild = node.RightChild;

			if (parent != null)
			{
				if (parent.LeftChild == node)
				{
					parent.LeftChild = rightChild;
				}
				else
				{
					parent.RightChild = rightChild;
				}
			}

			Node tmp = rightChild.LeftChild;
			rightChild.LeftChild = node;
			node.RightChild = tmp;

			node.Parent = rightChild;
			rightChild.Parent = parent;

			if (node.RightChild != null)
			{
				node.RightChild.Parent = node;
			}
		}

		private void RotateRight(Node node)
		{
			Node parent = node.Parent;
			Node leftChild = node.LeftChild;

			if (parent != null)
			{
				if (parent.RightChild == node)
				{
					parent.RightChild = leftChild;
				}
				else
				{
					parent.LeftChild = leftChild;
				}
			}

			Node tmp = leftChild.RightChild;
			leftChild.RightChild = node;
			node.LeftChild = tmp;

			node.Parent = leftChild;
			leftChild.Parent = parent;

			if (node.LeftChild != null)
			{
				node.LeftChild.Parent = node;
			}
		}

		public void Splay(Node node)
		{
			while (node.Parent != null)
			{
				if (node == node.Parent.LeftChild)
				{
					if (node.Parent.Parent == null)
					{
						RotateRight(node.Parent);
					}
					else if (node.Parent == node.Parent.Parent.LeftChild)
					{
						RotateRight(node.Parent.Parent);
						RotateRight(node.Parent);
					}
					else
					{
						RotateRight(node.Parent);
						RotateLeft(node.Parent);
					}
				}
				else
				{
					if (node.Parent.Parent == null)
					{
						RotateLeft(node.Parent);
					}
					else if (node.Parent == node.Parent.Parent.RightChild)
					{
						RotateLeft(node.Parent.Parent);
						RotateLeft(node.Parent);
					}
					else
					{
						RotateLeft(node.Parent);
						RotateRight(node.Parent);
					}
				}
			}

			Root = node;
		}

		public void Insert (int[] arrayOfValues)
		{
			foreach (int value in arrayOfValues)
			{
				Insert(value);
			}
		}

		private void WidthReading(Node node, Dictionary<Node, int> _widthWithLevels, int lvl = 0)
		{
			if (node != null)
			{
				if (lvl == 0)
				{
					_widthWithLevels.Add(node, lvl);
				}

				if (node.LeftChild != null)
				{
					_widthWithLevels.Add(node.LeftChild, lvl + 1);
					WidthReading(node.LeftChild, _widthWithLevels, lvl + 1);
				}

				if (node.RightChild != null)
				{
					_widthWithLevels.Add(node.RightChild, lvl + 1);
					WidthReading(node.RightChild, _widthWithLevels, lvl + 1);
				}
			}
		}

		public Dictionary<Node, int> GetWidthWithLevels()
		{
			Dictionary<Node, int> _widthWithLevels = new Dictionary<Node, int>();
			_widthWithLevels.Clear();

			WidthReading(Root, _widthWithLevels);
			return _widthWithLevels;
		}

		public void Clear(Node node)
		{
			if (node != null)
			{
				
				if (node.LeftChild != null)
				{
					Clear(node.LeftChild);
				}
				if (node.RightChild != null)
				{
					Clear(node.RightChild);
				}

				node = null;
			}
		}
	}
}
