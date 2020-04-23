using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code
{
    class Permutation
    {
        static List<List<int>> Fuck(List<int> vs)
        {
            if (vs.Count == 1) return new List<List<int>>() { vs };
            var result = vs.Select(x =>
            {
                var shit = Fuck(vs.Where(y => y != x).ToList());
                shit.ForEach(p => p.Add(x));
                return shit;
            });
            return result.SelectMany(x => x).ToList();
        }
    }
}
