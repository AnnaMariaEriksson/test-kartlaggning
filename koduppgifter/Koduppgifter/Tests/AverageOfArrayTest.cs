using HelperMethods;

namespace Tests;

[TestFixture]
public class AverageOfArrayTest
{
    [Test]
    public void Test2370()
    {
        int res = AverageOfArray.Program.GetAverageOfArray([2, 3, 7, 0]);
        Assert.That(res, Is.EqualTo(4));
    }

    [Test]
    public void Test20100()
    {
        int res = AverageOfArray.Program.GetAverageOfArray([20, 10, 0]);
        Assert.That(res, Is.EqualTo(15));
    }
    
    [Test]
    public void Test10()
    {
        decimal res = AverageOfArray.Program.GetAverageOfArray([1, 0]);
        Assert.That(res, Is.EqualTo(1));
    }

    [Test]
    public void TestRealData()
    {
        int res = AverageOfArray.Program.GetAverageOfArray([
            4024, 4700, 1042, 6144, 5612, 1505, 8041, 1004, 7906, 5853, 638, 2249, 629
        ]);
        Assert.That(res, Is.EqualTo(3797));
    }

    [Test]
    public void TestParsing()
    {
        List<int> res = Helpers.ParseStringsToInts("20 10 0");
        Assert.That(res, Is.EqualTo(new List<int> { 20, 10, 0 }));
    }
    
    //131 2087 483 1323 1887 562 2522 478 1328 2465 3956 - correct
    //
}