using SharperMindToCBetter.CSharpKnowledgebase;

namespace SharperTestsToCBetter.Tests.CSharpKnowledgebase;

[TestFixture]
public class LinqLearningTests
{
    [Test]
    // Naming Convention - ClassName_MethodName_ExpectedResult
    public static void LinqLearning_GetAllEvenNumbersFromList_NoValuesFromEmptyList()
    {
        // Arrange
        List<int> emptyList = [];

        // ACT       
        var returnedList = LinqLearning.GetAllEvenNumbersFromList(emptyList);

        // Assert
        Assert.That(returnedList is []);
    }

    [Test]
    public static void LinqLearning_GetAllEvenNumbersFromList_EmptyListFromListOfSingleOddNumber()
    {
        // Arrange
        List<int> oneOddNumberList = [1];

        // ACT       
        var returnedList = LinqLearning.GetAllEvenNumbersFromList(oneOddNumberList);

        // Assert
        Assert.That(returnedList is []);
    }

    [Test]
    public static void LinqLearning_GetAllEvenNumbersFromList_SameListFromListOfSingleEvenNumber()
    {
        // Arrange
        List<int> oneEvenNumberList = [2];

        // ACT       
        var returnedList = LinqLearning.GetAllEvenNumbersFromList(oneEvenNumberList);

        // Assert
        Assert.That(returnedList is [2]);
    }

    [Test]
    public static void LinqLearning_GetAllEvenNumbersFromList_ReturnsOnlyEvenNumberFromOneEvenOneOddList()
    {
        // Arrange
        List<int> oneEvenOneOddNumberList = [1, 2];

        // ACT       
        var returnedList = LinqLearning.GetAllEvenNumbersFromList(oneEvenOneOddNumberList);

        // Assert
        Assert.That(returnedList is [2]);
    }

    [Test]
    public static void LinqLearning_GetAllEvenNumbersFromList_AllEvenFromMixedList()
    {
        // Arrange
        List<int> oneEvenOneOddNumberList = [5, 44, 2, 21, 22];

        // ACT       
        var returnedList = LinqLearning.GetAllEvenNumbersFromList(oneEvenOneOddNumberList);

        // Assert
        Assert.That(returnedList is [44, 2, 22]);
    }

    [Test]
    public static void LinqLearning_GetAllUnderAverageNumbers_EmptyList()
    {
        // Arrange
        List<int> emptyList = [];

        // ACT       
        var returnedList = LinqLearning.GetAllUnderAverageNumbers(emptyList);

        // Assert
        Assert.That(returnedList is []);
    }

    [Test]
    public static void LinqLearning_GetAllUnderAverageNumbers_EmptyListFromSingleElement()
    {
        // Arrange
        List<int> singleElement = [1];

        // ACT       
        var returnedList = LinqLearning.GetAllUnderAverageNumbers(singleElement);

        // Assert
        Assert.That(returnedList is []);
    }

    [Test]
    public static void LinqLearning_GetAllUnderAverageNumbers_OneElementFromTwoElements()
    {
        // Arrange
        List<int> singleElement = [1, 2];

        // ACT       
        var returnedList = LinqLearning.GetAllUnderAverageNumbers(singleElement);

        // Assert
        Assert.That(returnedList is [1]);
    }

    [Test]
    public static void LinqLearning_GetAllUnderAverageNumbers_NineSmallNumbersFromNineSmallNumbersAndOneLargeNumber()
    {
        // Arrange
        List<int> singleElement = [1, 1, 1, 1, 1, 1, 1, 1, 1, 100];

        // ACT       
        var returnedList = LinqLearning.GetAllUnderAverageNumbers(singleElement);

        // Assert
        Assert.That(returnedList is [1, 1, 1, 1, 1, 1, 1, 1, 1]);
    }

    [Test]
    public static void LinqLearning_GetAllUnderAverageNumbers_OneSmallNumbersFromOneSmallNumbersAndTenLargeNumber()
    {
        // Arrange
        List<int> singleElement = [1, 100, 100, 100, 100, 100, 100, 100, 100, 100];

        // ACT       
        var returnedList = LinqLearning.GetAllUnderAverageNumbers(singleElement);

        // Assert
        Assert.That(returnedList is [1]);
    }

    [Test]
    public static void LinqLearning_ToUpperWithLinq_EmptyListFromEmptyList()
    {
        // Arrange
        List<string> emptyList = [];

        // ACT       
        var returnedList = LinqLearning.ToUpperWithLinq(emptyList);

        // Assert
        Assert.That(returnedList is []);
    }

    [Test]
    public static void LinqLearning_ToUpperWithLinq_UpperLettersFromLowerLetterWord()
    {
        // Arrange
        List<string> oneWordList = ["rabbit"];

        // ACT       
        var returnedList = LinqLearning.ToUpperWithLinq(oneWordList);

        // Assert
        Assert.That(returnedList is ["RABBIT"]);
    }

    [Test]
    public static void LinqLearning_ToUpperWithLinq_UpperLettersForAllThreeWords()
    {
        // Arrange
        List<string> threeWordList = ["rabbit", "duCk", "GoOsE"];

        // ACT       
        var returnedList = LinqLearning.ToUpperWithLinq(threeWordList);

        // Assert
        Assert.That(returnedList is ["RABBIT", "DUCK", "GOOSE"]);
    }
}