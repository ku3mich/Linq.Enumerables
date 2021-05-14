using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq
{
    public static class ItemsExtensions
    {
        public static void ForEach<T>([NotNull] this IEnumerable<T> items, Action<T> action)
        {
            foreach (var e in items)
                action(e);
        }
    }
}
