namespace Task2And3;

public class Book
{
    public string[] Content { get; set; }
    public Notes BookNotes { get; set; }

    public Book(string[] content)
    {
        Content = content;
        BookNotes = new Notes();
    }
}