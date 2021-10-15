using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExerciceDeLinq
{
    public static class MesExtensions
    {
        public static TResult ExecuteScalar<T, TResult>(this T origin, Func<T,TResult> select)
        {
            return select(origin);
        }
    }
}
