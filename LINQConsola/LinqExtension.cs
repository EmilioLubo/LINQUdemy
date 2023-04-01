using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsola
{
    public static class LinqExtension
    {
        public static IEnumerable<T> AlternateElements<T>(this IEnumerable<T> source)
        {
            int i = 0;

            foreach (T item in source)
            {
                if(i % 2 == 0)
                {
                    yield return item;
                }
                i++;
            }
        }
    }
}
