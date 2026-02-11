namespace Lab4.Bookstore;

public class Textbook : Book
{
    private string _subject = string.Empty;

    public required string Subject
    {
        get => _subject;
        init => _subject = ValidateRequired(value, nameof(Subject));
    }

    public override string GetInfo() => $"{Title} (Textbook: {Subject}) by {Author}";
}
