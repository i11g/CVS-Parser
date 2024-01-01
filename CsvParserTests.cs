using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        ////Arrange
        //string input = string.Empty;
        //string[] expected=Array.Empty<string>();
        ////Act
        //string[] result=CsvParser.ParseCsv(input);
        ////Assert
        //Assert.That(result,Is.EqualTo(expected));

        //Arrange
        string input=String.Empty;
        //string input1 = "";
        string [] expected = { };
        string[] expected1=Array.Empty<string>();

        //Act
        string [] result=CsvParser.ParseCsv(input);

        //Assert

        Assert.That(result, Is.Empty);
        Assert.That(result, Is.EqualTo(expected1));
        Assert.IsEmpty(result);
    }
    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        //Arrange
        string input = "single";
        string[] expected = { "single" };
        //Act
        string[] result = CsvParser.ParseCsv(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        //Arrange
        string input = "single,double,tripple";
        string[] expected = { "single", "double", "tripple" };
        //Act
        string[] result = CsvParser.ParseCsv(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        ////Arrange
        //string input = "single,   double,     tripple";
        //string[] expected = { "single", "double", "tripple" };
        ////Act
        //string[] result = CsvParser.ParseCsv(input);
        ////Assert
        //Assert.That(result, Is.EqualTo(expected));

        //Arrange
        string input = "one,  two,     three,four   ,five";
        string[] expected = { "one", "two", "three", "four", "five" };
        //Act
        string[] result=CsvParser.ParseCsv(input);
        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
