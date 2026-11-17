using NUnit.Framework;
using System;
using System.Threading;

[TestFixture]
[Parallelizable(ParallelScope.Children)]
public class SimpleParallelTests
{
    [Test]
    [Timeout(2000)]
    public void TestA()
    {
        Thread.Sleep(3000);
        Console.WriteLine("TestA done");
    }

    [Test]
    public void TestB()
    {
        Thread.Sleep(3000);
        Console.WriteLine("TestB done");
    }
}
