using System;
using System.Collections.Generic;

namespace CtCi.Solutions.LinkedLists
{
    public static class RemoveDups
    {
        /// <summary>
        /// Because I am using .Net Core Implementation of LinkedList the Next and Previous of each node are read-only
        /// So I need to use the Remove method which is an O(n) operation becoming this algorithm O(n2) instead of O(n) 
        /// </summary>
        /// <param name="linkedList"></param>
        public static void Distinct(this LinkedList<int> linkedList)
        {
            if (linkedList is null || linkedList.Count == 0) 
            {
                throw new ArgumentException("LinkedList cannot be null or empty");
            }

            LinkedListNode<int> node = linkedList.First;
            bool[] marks = new bool[linkedList.Count];

            while (node != null) 
            {
                if (marks[node.Value])
                {
                    LinkedListNode<int> next = node.Next;
                    linkedList.Remove(node);
                    node = next;
                }
                else 
                {
                    marks[node.Value] = true;
                    node = node.Next;
                }
            }
        }
    }
}
