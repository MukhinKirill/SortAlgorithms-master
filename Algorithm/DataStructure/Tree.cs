using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructure
{
    public class Tree<T> :AlgorithmBase<T>
          where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }
        public Tree()
        {
                
        }
        public Tree(IEnumerable<T> items)
        {
            var list = items.ToList();
            for (int i = 0; i < items.Count(); i++)
            {
                var item = list[i];
                Items.Add(item);
                var node = new Node<T>(item, i);
                Add(node);
            }
        }
        private void Add(Node<T> node)
        {
            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            Add(Root, node);
            Count++;
        }
        private void Add(Node<T> node,Node<T> newNode)
        {
            if (Compare(node.Data, newNode.Data) == 1)
            {
                if (node.Left == null)
                {

                    node.Left = newNode;
                }
                else
                {
                    Add(node.Left, newNode);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                    Add(node.Right, newNode);
                }
            }
        }
        //public List<T> Preorder()
        //{
        //    if (Root == null)
        //    {
        //        return new List<T>();
        //    }

        //    return Preorder(Root);
        //}

        //public List<T> Postorder()
        //{
        //    if (Root == null)
        //    {
        //        return new List<T>();
        //    }

        //    return Postorder(Root);
        //}

        protected override void MakeSort()
        {
            //var dict = new Dictionary
            var result = InOrder(Root);
            var buffer = new Dictionary<int, int>();
            /*Items.AddRange(result.Select(i=>i.Data));// это костыль прям костыль
            for (int i = 0; i < result.Count(); i++)
            {
                    Swop(i, result.Count + i);
            }
            Items.RemoveRange(result.Count, result.Count);*/
            for (int i = 0; i < result.Count(); i++)
            {
                if(buffer.ContainsKey(result[i].Index))
                {
                    int tmp = buffer[result[i].Index];
                    BufSwap(result, buffer, i, tmp);
                }
                else
                {
                    Swop(i, result[i].Index);
                    buffer.Add(i, result[i].Index);
                }
            }
        }

        private void BufSwap(List<Node<T>> result, Dictionary<int, int> buffer, int i, int tmp)
        {
            if (!buffer.ContainsKey(tmp))
            {
                buffer[result[i].Index] = result[i].Index;
                Swop(i, tmp);
                buffer.Add(i, tmp);
            }
            else
            {
                tmp = buffer[tmp];
                BufSwap(result, buffer, i, tmp);
            }
        }

        //private List<T> Preorder(Node<T> node)
        //{
        //    var list = new List<T>();
        //    if (node != null)
        //    {
        //        list.Add(node.Data);

        //        if (node.Left != null)
        //        {
        //            list.AddRange(Preorder(node.Left));
        //        }

        //        if (node.Right != null)
        //        {
        //            list.AddRange(Preorder(node.Right));
        //        }
        //    }

        //    return list;
        //}

        //private List<T> Postorder(Node<T> node)
        //{
        //    var list = new List<T>();
        //    if (node != null)
        //    {
        //        if (node.Left != null)
        //        {
        //            list.AddRange(Postorder(node.Left));
        //        }

        //        if (node.Right != null)
        //        {
        //            list.AddRange(Postorder(node.Right));
        //        }

        //        list.Add(node.Data);
        //    }

        //    return list;
        //}

        private List<Node<T>> InOrder(Node<T> node)
        {
            var list = new List<Node<T>>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InOrder(node.Left));
                }
                list.Add(node);
                if (node.Right != null)
                {
                    list.AddRange(InOrder(node.Right));
                }

            }
            return list;
        }
    }
}
