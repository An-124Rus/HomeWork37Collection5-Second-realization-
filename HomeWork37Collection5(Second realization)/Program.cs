internal class Program
{
    private static void Main(string[] args)
    {
        int minNumberValue = 0;
        int maxNumberValue = 10;
        int firstCollectionLength = 5;
        int secondCollectionLength = 5;

        List<int> firstCollection = new List<int>();
        List<int> secondCollection = new List<int>();
        List<int> newCollection = new List<int>();

        Console.WriteLine("Первая коллекция");
        CreateCollection(firstCollection, firstCollectionLength, minNumberValue, maxNumberValue);

        Console.WriteLine("\nВторая коллекция");
        CreateCollection(secondCollection, secondCollectionLength, minNumberValue, maxNumberValue);

        newCollection.AddRange(firstCollection);
        newCollection.AddRange(secondCollection);

        Console.WriteLine("\nИтоговая коллекция");
        RemoveSameNumbersInCollection(newCollection);
    }

    static void CreateCollection(List<int> collection, int collectionLength, int minValue, int maxValue)
    {
        Random random = new Random();

        for (int i = 0; i < collectionLength; i++)
        {
            int number = random.Next(minValue, maxValue);

            collection.Add(number);
        }

        ShowCollection(collection);

        Console.WriteLine();
    }

    static void RemoveSameNumbersInCollection(List<int> collection)
    {
        for (int i = 0; i < collection.Count; i++)
        {
            int number = collection[i];

            for (int j = i + 1; j < collection.Count; j++)
            {
                if (number == collection[j])
                {
                    collection.RemoveAt(j);
                    j--;

                    if (i >= 0)
                        i--;
                }
            }
        }

        ShowCollection(collection);

        Console.WriteLine();
    }

    static void ShowCollection(List<int> newCollection)
    {

        foreach (int number in newCollection)
            Console.Write(number + " ");
    }
}