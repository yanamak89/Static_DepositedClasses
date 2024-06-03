namespace Task4;

public static class ArrayExtensions
{
    public static void SortAscending(this int[] array)
    {
        Array.Sort(array);
    }

    public static void Show()
    {
        int[] array = { 5, 3, 9, 2, 1, 5, 8, 10 };
        Console.WriteLine("Original array:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }

        array.SortAscending();
        Console.WriteLine("\nSorted array:");
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
    }
}