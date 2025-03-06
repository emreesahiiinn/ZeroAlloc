using System;
using System.Text;
using System.Collections.Concurrent;

namespace ZeroAlloc.Console;

public static class StringBuilderPool
{
    private static readonly ConcurrentBag<StringBuilder> _pool = new ConcurrentBag<StringBuilder>();

    public static StringBuilder Get()
    {
        if (_pool.TryTake(out var sb))
        {
            sb.Clear();
            return sb;
        }
        return new StringBuilder();
    }

    public static void Return(StringBuilder sb)
    {
        _pool.Add(sb);
    }
}
