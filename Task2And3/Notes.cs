namespace Task2And3;

public class Notes
{
    private string[] notes;
    private int noteCount;

    public Notes()
    {
        notes = new string[100];
        noteCount = 0;
    }

    public void AddNote(string note)
    {
        if (noteCount < note.Length)
        {
            notes[noteCount] = note;
            noteCount++;
        }
        else
        {
            Console.WriteLine("Записник заповнений");
        }
    }

    public void DeleteNote(int index)
    {
        if (index >= 0 && index < noteCount)
        {
            for (int i = 0; i < noteCount - 1; i++)
            {
                notes[i] = notes[i + 1];
            }

            notes[noteCount - 1] = null;
            noteCount--;
        }
        else
        {
            Console.WriteLine("Некоректний індекс");
        }
    }
    public void DisplayNotes()
    {
        Console.WriteLine("Нотатки користувача: ");
        for (int i = 0; i < noteCount; i++)
        {
            Console.WriteLine($"{i + 1}: {notes[i]}");
        }
    }
}
