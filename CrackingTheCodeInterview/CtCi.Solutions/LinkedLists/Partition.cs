using System;
using System.Collections.Generic;

namespace CtCi.Solutions.LinkedLists
{
    public class Partition
    {
        public LinkedList<int> ToPartition(int x, LinkedList<int> aLinkedList) 
        {
            if (aLinkedList is null || aLinkedList.Count == 0) 
            {
                throw new ArgumentException(" aLinkedList cannot be null or empty");
            }

            LinkedList<int> partioned = new LinkedList<int>();

            foreach (int item in aLinkedList) 
            {
                if (item < x)
                {
                    partioned.AddFirst(item);
                }
                else 
                {
                    partioned.AddLast(item);
                }
            }

            return partioned;
        }
    }
}
