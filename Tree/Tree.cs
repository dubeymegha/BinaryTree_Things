using System;
using System.Collections.Generic;

namespace BST
{
    class Tree
    {
        public class TreeNode
        {
            public int Data;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int Dta)
            {
                this.Data = Dta;
                this.Left = null;
                this.Right = null;
            }

            public TreeNode AddNode(TreeNode Root, TreeNode NewNode)
            {
                if (Root == null)
                {
                    Root = NewNode;
                    return Root;
                }
                else if (Root.Data > NewNode.Data)
                {
                    Root.Left = AddNode(Root.Left, NewNode);
                }
                else
                {
                    Root.Right = AddNode(Root.Right, NewNode);
                }
                return Root;

            }



        }
        private TreeNode Root = null;

        public void Add(int Data)
        {
            TreeNode newNodeObj = new TreeNode(Data);
            Root = newNodeObj.AddNode(Root, newNodeObj);
        }



        //PreOrder Traversing
        private void Print(TreeNode Root)
        {
            if (Root == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(Root.Data);
                Print(Root.Left);
                Print(Root.Right);
            }
        }

        //InOrderTraversing
        public void InOrder(TreeNode Root)
        {
            if (Root == null)
            {
                return;
                ;
            }
            else
            {
                {
                    InOrder(Root.Left);
                    Console.WriteLine(Root.Data);
                    InOrder(Root.Right);
                }
            }
        }

        //PostOrderTraversing
        public void PostOrder(TreeNode Root)
        {
            if (Root == null)
            {
                return;
            }
            else
            {
                PostOrder(Root.Left);
                PostOrder(Root.Right);
                Console.WriteLine(Root.Data);
            }
        }

        public void Print()
        {
            Print(Root);
        }


        public void PrintLevelOrder()
        {
            List<TreeNode> Data = new List<TreeNode>();
            Data.Add(Root);
            while (Data.Count != 0)
            {
                TreeNode temp = Data[0];
                Data.RemoveAt(0);
                Console.WriteLine(temp.Data);
                if (temp.Left != null)
                    Data.Add(temp.Left);
                if (temp.Right != null)
                    Data.Add(temp.Right);

            }
        }

        public void PrintSpiralOrder()
        {
            List<TreeNode> Data = new List<TreeNode>();
            Data.Add(Root);
            int tempCount = 0;
            while (Data.Count != 0)
            {
                TreeNode temp = Data[0];
                Data.RemoveAt(0);
                Console.WriteLine(temp.Data);
                if (tempCount % 2 == 0)
                {

                    if (temp.Left != null)
                        Data.Add(temp.Left);
                    if (temp.Right != null)
                        Data.Add(temp.Right);
                }
                else
                {

                    if (temp.Right != null)
                        Data.Add(temp.Right);
                    if (temp.Left != null)
                        Data.Add(temp.Left);
                }
                tempCount++;

            }
        }

        public void Search(int FindIt)
        {
            SearchIt(Root, FindIt);
        }

        private void SearchIt(TreeNode Root, int FindIt)
        {
            if (Root == null)
            {
                Console.WriteLine("Not Found!!");
                return;
            }


            else if (FindIt == Root.Data)
            {
                Console.WriteLine("Found!!");
                return;

            }
            else if (FindIt > Root.Data)
            {
                SearchIt(Root.Right, FindIt);
            }
            else if (FindIt < Root.Data)
            {
                SearchIt(Root.Left, FindIt);
            }
            return;

        }
    }

}

