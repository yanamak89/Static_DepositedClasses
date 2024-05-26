namespace Task2And3;

static class FindAndReplaceManager
{
    public static void FindNext(string str, Book book)
    {
        bool found = false;
        for (int i = 0; i < book.Content.Length; i++)
        {
            if (book.Content[i].Contains(str))
            {
                Console.WriteLine($"Знайдено: {str} в строці {i + 1} : {book.Content[i]}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"{str} not found in the book");
        }
    }
}