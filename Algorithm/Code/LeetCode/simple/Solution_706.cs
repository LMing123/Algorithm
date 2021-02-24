using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Code.LeetCode.simple
{
    /// <summary>
    /// Solution_706
    /// </summary>
    class MyHashMap
    {
        private int[] lists;
        public MyHashMap()
        {
            lists = new int[1000001];
            var span=new Span<int>(lists);
            span.Fill(-1);
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            lists[key] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            return lists[key]==-1?-1:lists[key];
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            lists[key] = -1;
        }
    }
}
