using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            if (list == null) return null;
            if (list.Count == 0) return list;


            var currNode = list.First;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i; j++)
                {
                    if (currNode.Next == null)
                    {
                        break;
                    }

                    if (currNode.Value > currNode.Next.Value)
                    {
                        var temp = new LinkedListNode<int>(currNode.Next.Value);
                        var newCurrent = new LinkedListNode<int>(currNode.Value);

                        list.Remove(currNode.Next);
                        list.AddAfter(currNode, newCurrent);

                        list.Remove(currNode);
                        list.AddBefore(newCurrent, temp);

                        currNode = newCurrent;
                    }
                    else
                    {
                        currNode = currNode.Next;
                    }
                }

                currNode = list.First;
            }

            return list;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            if (list == null) return null;
            if (list.Count == 0) return list;

            var currNode = list.First;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i; j++)
                {
                    if (currNode.Next == null)
                    {
                        break;
                    }

                    if (currNode.Value < currNode.Next.Value)
                    {
                        var temp = new LinkedListNode<int>(currNode.Next.Value);
                        var newCurrent = new LinkedListNode<int>(currNode.Value);

                        list.Remove(currNode.Next);
                        list.AddAfter(currNode, newCurrent);

                        list.Remove(currNode);
                        list.AddBefore(newCurrent, temp);

                        currNode = newCurrent;
                    }
                    else
                    {
                        currNode = currNode.Next;
                    }
                }

                currNode = list.First;
            }
            return list;
        }
    }
}
