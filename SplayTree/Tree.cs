using System;
using System.Collections.Generic;
using System.Text;

namespace SplayTree
{
	public partial class Tree
	{
		public Node Root { get; private set; }

		public Tree() { }

		public Tree(Node root)
		{
			Root = root;
		}

		public Tree(int value)
		{
			Root = new Node(value);
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

			Splay (result);
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

			leftTree.RightChild = rightTree;
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
			Node rightChild = node.LeftChild;

			if (parent != null)
			{
				if (parent.RightChild == node)
				{
					parent.RightChild = rightChild;
				}
				else
				{
					parent.LeftChild = rightChild;
				}
			}

			Node tmp = rightChild.RightChild;
			rightChild.RightChild = node;
			node.LeftChild = tmp;

			node.Parent = rightChild;
			rightChild.Parent = parent;

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
	}
}
