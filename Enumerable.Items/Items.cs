using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace System.Linq
{
    public static class Items
    {
        public static IEnumerable<T> From<T>(params T[] items) => items;
        public static IEnumerable<T> From<T>(params IEnumerable<T>[] s) => s.Where(q => q != null).SelectMany(s => s);
        public static IEnumerable<T> From<T>([NotNull] IEnumerable<T> s, params T[] a) => s.Concat(a);
        public static IEnumerable<T> From<T>(T s, IEnumerable<T> a) => From(s).Concat(From(a));
    }
}
