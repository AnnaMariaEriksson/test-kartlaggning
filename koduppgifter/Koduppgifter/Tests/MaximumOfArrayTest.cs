using FizzBuzz;
using Program = Microsoft.VisualStudio.TestPlatform.TestHost.Program;

namespace Tests;

[TestFixture]
public class MaximumOfArrayTest
{
    [Test]
    public void TestMaximumOfArray()
    {
        int result = MaximumOfArray.Program.FindMaximumOfArray(
            [1, 3, 5, 7, 9, 11, 295, 297, 299, 300, 298, 296, 12, 10, 8, 6, 4, 2]);
        Assert.That(result, Is.EqualTo(300));
    }

    [Test]
    public void TestLowestOfArray()
    {
        int result =
            MaximumOfArray.Program.FindLowestOfArray([
                1, 3, 5, 7, 9, 11, 295, 297, 299, 300, 298, 296, 12, 10, 8, 6, 4, 2
            ]);
        Assert.That(result, Is.EqualTo(1));
    }
}