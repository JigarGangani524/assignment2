using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NUnit.Framework;
using TriangleSolver;

[TestFixture]
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
    public void AnalyzeTriangle_ValidIsosceles_Input4and4and9_ReturnIsoscelesTriangle()
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
    public void AnalyzeTriangle_ValidIsosceles_Inputand3and4and4_ReturnIsoscelesTriangle()
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
    public void AnalyzeTriangle_ValidIsosceles_Input4and5and4_ReturnIsoscelesTriangle()
    {
        // Arrange
        int firstSide = 4;
        int secondSide = 5;
        int thirdSide = 4;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
    }

    /* Valid scalene triangle */
    [Test]
    public void AnalyzeTriangle_ValidScaleneTriangle_Input4and6and8_ReturnScaleneTriangle()
    {
        // Arrange
        int firstSide = 4;
        int secondSide = 6;
        int thirdSide = 8;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is a SCALENE", result);
    }

    [Test]
    public void AnalyzeTriangle_ValidScaleneTriangle_Input9and12and15_ReturnScaleneTriangle()
    {
        // Arrange
        int firstSide = 9;
        int secondSide = 12;
        int thirdSide = 15;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is a SCALENE", result);
    }

    [Test]
    public void AnalyzeTriangle_ValidScaleneTriangle_Input4and5and6_ReturnScaleneTriangle()
    {
        // Arrange
        int firstSide = 4;
        int secondSide = 5;
        int thirdSide = 6;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is a SCALENE", result);
    }

    [Test]
    public void AnalyzeTriangle_ValidScaleneTriangle_Input7and10and12_ReturnScaleneTriangle()
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
    public void AnalyzeTriangle_ValidScaleneTriangle_Input10and15and17_ReturnScaleneTriangle()
    {
        // Arrange
        int firstSide = 10;
        int secondSide = 15;
        int thirdSide = 17;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("The triangle is valid and is a SCALENE", result);
    }

    /* Verifying a zero length for one or more sides */
    [Test]
    public void AnalyzeTriangle_TestInvalidTriangle_ZeroLengthSide()
    {
        // Arrange
        int firstSide = 5;
        int secondSide = 0;
        int thirdSide = 4;
        string expectedOutput = "At least one side of your triangle has a zero length and is thus invalid";

        // Act
        string actualOutput = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void AnalyzeTriangle_TestInvalidTriangle_AllSidesZeroLength()
    {
        // Arrange
        int firstSide = 0;
        int secondSide = 0;
        int thirdSide = 0;
        string expectedOutput = "At least one side of your triangle has a zero length and is thus invalid";

        // Act
        string actualOutput = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void AnalyzeTriangle_TestValidTriangle_NoZeroLengthSide()
    {
        // Arrange
        int firstSide = 3;
        int secondSide = 4;
        int thirdSide = 5;
        string expectedOutput = "The triangle is valid and is a SCALENE";

        // Act
        string actualOutput = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }


    /* Verifying an invalid response (other than a zero length) */
    [Test]
    public void AnalyzeTriangle_TestInvalidTriangle_NegativeSides()
    {
        // Arrange
        int firstSide = -1;
        int secondSide = 2;
        int thirdSide = 3;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("A triangle cannot be formed with those numbers", result);
    }

    [Test]
    public void AnalyzeTriangle_TestInvalidTriangle_SumOfTwoSidesEqualThirdSide()
    {
        // Arrange
        int firstSide = 3;
        int secondSide = 4;
        int thirdSide = 7;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("A triangle cannot be formed with those numbers", result);
    }

    [Test]
    public void AnalyzeTriangle_TestInvalidTriangle_SumOfTwoSidesLessThanThirdSide()
    {
        // Arrange
        int firstSide = 1;
        int secondSide = 2;
        int thirdSide = 5;

        // Act
        string result = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

        // Assert
        Assert.AreEqual("A triangle cannot be formed with those numbers", result);
    }

}


