namespace Lab4.Bookstore;

public class Book
{
    private string _title = string.Empty;
    private string _author = string.Empty;

    public required string Title
    {
        get => _title;
        init => _title = ValidateRequired(value, nameof(Title));
    }

    public required string Author
    {
        get => _author;
        init => _author = ValidateRequired(value, nameof(Author));
    }

    public virtual string GetInfo() => $"{Title} by {Author}";

    protected static string ValidateRequired(string? value, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"{propertyName} cannot be empty.", propertyName);
        }

        return value;
    }
}
