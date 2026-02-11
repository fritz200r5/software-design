namespace Lab4.Bookstore;

public class Magazine : Book
{
    private int _issueNumber;

    public required int IssueNumber
    {
        get => _issueNumber;
        init
        {
            if (value <= 0)
            {
                throw new ArgumentException("IssueNumber must be greater than zero.", nameof(IssueNumber));
            }

            _issueNumber = value;
        }
    }

    public override string GetInfo() => $"{Title} - Issue {IssueNumber}";
}
