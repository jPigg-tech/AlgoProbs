using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoProblems
{
    public class SquaredSames
    {
        public bool AreTheySame(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            if (a.Length != b.Length) return false;

            foreach (var number in b)
                if (!a.Contains((int)Math.Sqrt(number)))
                    return false;

            return true;
        }

        //public bool AreTheySame(int[] a, int[] b)
        //{
        //    foreach (var number in b)
        //    {
        //        Math.Sqrt(number);
        //    }

        //    if (a == null || b == null) return false;
        //    if (a.Length != b.Length) return false;

        //    var c = a.ToList();
        //    var d = b.ToList();

        //    for (int i = 0; i < a.Length; i++)
        //    {                
        //        if (!c.Contains(d[i]))
        //        {
        //            return false;
        //        }
        //        if (!d.Contains(c[i]))
        //        {
        //            return false;
        //        }
        //        d.Remove(d[i]);
        //        c.Remove(c[i]);
        //        continue;
        //    }
        //    return true;

        //    // a = {2, 2, 3, 3}
        //    // b = {9, 9, 9, 4}

        //}
    }
}
