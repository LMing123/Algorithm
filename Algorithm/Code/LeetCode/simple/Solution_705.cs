using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    class Solution_705
    {
        public class MyHashSet
        {
            int?[] lists;
            /** Initialize your data structure here. */
            public MyHashSet()
            {
                lists = new int?[1000001];
            }

            public void Add(int key)
            {
                lists[key] = key;
            }

            public void Remove(int key)
            {
                if(lists[key]!=null)
                {
                    lists[key] = null;
                }
            }

            /** Returns true if this set contains the specified element */
            public bool Contains(int key)
            {
                return lists[key] != null;
            }
        }
    }
}
