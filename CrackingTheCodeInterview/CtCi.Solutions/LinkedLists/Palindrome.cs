using Common.Extensions;
using System;
using System.Collections.Generic;

namespace CtCi.Solutions.LinkedLists
{
    public class Palindrome
    {
        public bool IsPalindrome<T>(LinkedList<T> aLinkedList) 
        {
            if (aLinkedList.IsNullOrEmpty()) 
            {
                throw new ArgumentException($"{nameof(aLinkedList)} cannot be null or empty");
            }
            
            LinkedListNode<T> head = aLinkedList.First;
            LinkedListNode<T> tail = aLinkedList.Last;
            int equal = 0;
            int halfCount = aLinkedList.Count / 2;

            while (equal < halfCount && head.Value.Equals(tail.Value)) 
            {
                equal++;
                head = head.Next;
                tail = tail.Previous;
            }

            return equal == halfCount;
        }
    }
}
