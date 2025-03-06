using System;
using System.Text;
using Xunit;
using ZeroAlloc.Console;

namespace ZeroAlloc.Tests;

public class ObjectPoolingTests
{
    [Fact]
    public void ObjectPooling_ShouldReuseInstances()
    {
        var sb1 = StringBuilderPool.Get();
        sb1.Append("Test");

        StringBuilderPool.Return(sb1);

        var sb2 = StringBuilderPool.Get();

        Assert.Same(sb1, sb2);
    }
}
