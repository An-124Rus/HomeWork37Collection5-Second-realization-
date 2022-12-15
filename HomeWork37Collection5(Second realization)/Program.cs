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

        Console.WriteLine("\nПервая коллекция после отсеивания");
        RemoveSameNumbersInCollection(firstCollection);

        Console.WriteLine("\nВторая коллекция после отсеивания");
        RemoveSameNumbersInCollection(secondCollection);

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

        foreach (int number in collection)
            Console.Write(number + " ");

        collection.Sort();

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
                    collection.Remove(collection[j]);
                    j--;

                    if (i >= 0)
                        i--;
                }
            }
        }

        collection.Sort();

        foreach (int number in collection)
            Console.Write(number + " ");

        Console.WriteLine();
    }
}