using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructure
{
    public class Node<T>
        where T : IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public int Index { get; set; }
        public Node(T data, int index)
        {
            Data = data;
            Index = index;
        }
            
        //public void Add(T data)
        //{
        //    var node = new Node<T>(data);

        //    if (node.Data.CompareTo(Data) == -1)
        //    {
        //        if (Left == null)
        //        {
        //            Left = node;
        //        }
        //        else
        //        {
        //            Left.Add(data);
        //        }
        //    }
        //    else
        //    {
        //        if (Right == null)
        //        {
        //            Right = node;
        //        }
        //        else
        //        {
        //            Right.Add(data);
        //        }
        //    }
        //}

        //public int CompareTo(object obj)
        //{
        //    if (obj is Node<T> item)
        //    {
        //        return Data.CompareTo(item);
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Не совпадение типов");
        //    }
        //}

        public override string ToString()
        {
            return Data.ToString();
        }
        
    }
}
