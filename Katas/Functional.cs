using System;
using System.Collections.Generic;

namespace Katas
{
    public class Functional
    {
        public Func<int, Func<int, int>> Add = x => y => x+ y;

        public static Func<T, bool> IsInList<T>(IEnumerable<T> list, T item)
        {
            var hashSet = new HashSet<T>(list);
            return hashSet.Contains;
        }
    }
}
