using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NUnit.Framework;
using TriangleSolver;

public class TriangleTests
{
    /* Valid equilateral triangle */
    [Test]
    public void AnalyzeTriangle_ValidEquilateral_ReturnsEquilateral()
    {
        // Arrange
        int firstSide = 4;
        int secondSide = 4;
        int thirdSide = 4;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
    }


    /* Valid isosceles triangle */
    [Test]
    public void AnalyzeTriangle_ValidIsosceles_ReturnsIsosceles()
    {
        // Arrange
        int firstSide = 5;
        int secondSide = 5;
        int thirdSide = 8;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
    }

    [Test]
    public void AnalyzeTriangle_ValidIsosceles_ReturnsIsosceles2()
    {
        // Arrange
        int firstSide = 3;
        int secondSide = 4;
        int thirdSide = 4;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
    }

    [Test]
    public void AnalyzeTriangle_ValidIsosceles_ReturnsIsosceles3()
    {
        // Arrange
        int firstSide = 5;
        int secondSide = 6;
        int thirdSide = 5;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
    }

    /* Valid scalene triangle */
    [Test]
    public void ValidScaleneTriangle_Test1()
    {
        // Arrange
        int firstSide = 5;
        int secondSide = 7;
        int thirdSide = 9;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is a SCALENE", result);
    }

    [Test]
    public void ValidScaleneTriangle_Test2()
    {
        // Arrange
        int firstSide = 8;
        int secondSide = 11;
        int thirdSide = 14;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is a SCALENE", result);
    }

    [Test]
    public void ValidScaleneTriangle_Test3()
    {
        // Arrange
        int firstSide = 3;
        int secondSide = 4;
        int thirdSide = 5;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is a SCALENE", result);
    }

    [Test]
    public void ValidScaleneTriangle_Test4()
    {
        // Arrange
        int firstSide = 7;
        int secondSide = 10;
        int thirdSide = 12;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is a SCALENE", result);
    }

    [Test]
    public void ValidScaleneTriangle_Test5()
    {
        // Arrange
        int firstSide = 9;
        int secondSide = 14;
        int thirdSide = 16;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is a SCALENE", result);
    }


}



