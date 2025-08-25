namespace SharperMindToCBetter.CSharpKnowledgebase;

public static class LinqLearning
{
    public static List<int> GetAllEvenNumbersFromList(List<int> listToComb) =>
        listToComb.Where(numberInList => numberInList % 2 == 0).ToList();

    public static List<int> GetAllUnderAverageNumbers(List<int> listToComb) =>
        listToComb.Where(numberInList => numberInList < listToComb.Average()).ToList();

    public static List<string> ToUpperWithLinq(List<string> listToUpperCase) =>
        listToUpperCase.Select(stringInList => stringInList.ToUpper()).ToList();
}