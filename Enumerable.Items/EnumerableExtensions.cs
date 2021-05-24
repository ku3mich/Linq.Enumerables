using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>([NotNull] this IEnumerable<T> items, Action<T> action)
        {
            foreach (var e in items)
                action(e);
        }

        public static bool Empty<T>([NotNull] this IEnumerable<T> items)
            => !items.Any();
    }
}
