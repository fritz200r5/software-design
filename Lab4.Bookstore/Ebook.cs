namespace Lab4.Bookstore;

public class Ebook : Book
{
    private int _fileSizeMb;

    public required int FileSizeMb
    {
        get => _fileSizeMb;
        init
        {
            if (value <= 0)
            {
                throw new ArgumentException("FileSizeMb must be greater than zero.", nameof(FileSizeMb));
            }

            _fileSizeMb = value;
        }
    }

    public override string GetInfo() => $"{Title} (Ebook, {FileSizeMb}MB)";
}
