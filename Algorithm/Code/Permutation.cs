using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm.Code
{
    class Permutation
    {
        static List<List<int>> Func(List<int> vs)
        {
            if (vs.Count == 1) return new List<List<int>>() { vs };
            var result = vs.Select(x =>
            {
                var SpecialS = Func(vs.Where(y => y != x).ToList());
                SpecialS.ForEach(p => p.Add(x));
                return SpecialS;
            });
            return result.SelectMany(x => x).ToList();
        }
    }
}
