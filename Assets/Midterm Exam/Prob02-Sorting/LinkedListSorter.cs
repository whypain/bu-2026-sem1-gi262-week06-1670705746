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
            if (list == null || list.Count == 0) return null;


            var currNode = list.First;
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i; j++)
                {
                    if (currNode == null)
                    {
                        Debug.LogError($"currNode is null at i: {i}, j: {j}");
                    }

                    if (currNode.Value > currNode.Next.Value)
                    {
                        var temp = new LinkedListNode<int>(currNode.Next.Value);
                        var newCurrent = new LinkedListNode<int>(currNode.Value);

                        list.Remove(currNode.Next);
                        list.AddAfter(currNode, newCurrent);

                        list.Remove(currNode);
                        list.AddBefore(newCurrent, temp);

                        currNode = newCurrent.Next;
                    }
                    else
                    {
                        currNode = currNode.Next;
                    }
                }
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
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            return list;
        }
    }
}
