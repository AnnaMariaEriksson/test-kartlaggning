using FizzBuzz;
using NUnit.Framework;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Test237()
    {
        
        string result = Program.FizzBuzzResult(2, 3, 7);
        Assert.That(result, 
            Is.EqualTo("1\nFizz\nBuzz\nFizz\n5\nFizzBuzz\n7"));
    }

    [Test]
    public void Test247()
    {
        string result = Program.FizzBuzzResult(2, 4, 7);
        Assert.That(result, Is.EqualTo("1\nFizz\n3\nFizzBuzz\n5\nFizz\n7"));
    }

    [Test]
    public void Test357()
    {
        string result = Program.FizzBuzzResult(3, 5, 7);
        Assert.That(result, Is.EqualTo("1\n2\nFizz\n4\nBuzz\nFizz\n7"));
    }
}