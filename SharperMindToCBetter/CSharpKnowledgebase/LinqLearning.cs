namespace SharperMindToCBetter.CSharpKnowledgebase;

public static class LinqLearning
{

    public static List<int> GetAllEvenNumbersFromList(List<int> listToComb) =>
        listToComb.Where(number => number % 2 == 0).ToList();

    public static List<int> GetAllEvenNumbersFromQueryVersion(List<int> listToComb) => (
        from number in listToComb
            where number % 2 == 0
            select number
        ).ToList();


    public static List<int> GetAllUnderAverageNumbers(List<int> listToComb) =>
        listToComb.Where(number => number < listToComb.Average()).ToList();

    public static List<int> GetAllUnderAverageNumbersQueryVersion(List<int> listToComb) => (
        from number in listToComb
                where number < listToComb.Average()
                    select number
        ).ToList();

    public static List<string> ToUpperWithLinq(List<string> listToUpperCase) =>
        listToUpperCase.Select(word => word.ToUpper()).ToList();
}