using Lab4.Bookstore;

namespace Lab4.Bookstore.Tests;

[TestClass]
public class BookTests
{
    [TestMethod]
    public void TestBookCreation()
    {
        var book = new Book { Title = "C# Programming", Author = "John Smith" };

        Assert.AreEqual("C# Programming", book.Title);
        Assert.AreEqual("John Smith", book.Author);
        Assert.AreEqual("C# Programming by John Smith", book.GetInfo());
    }

    [TestMethod]
    public void TestMagazineCreation()
    {
        var magazine = new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 };

        Assert.AreEqual("Tech Weekly", magazine.Title);
        Assert.AreEqual(12, magazine.IssueNumber);
        Assert.AreEqual("Tech Weekly - Issue 12", magazine.GetInfo());
    }

    [TestMethod]
    public void TestEbookCreation()
    {
        var ebook = new Ebook { Title = "Learn C#", Author = "Mark Jones", FileSizeMb = 5 };

        Assert.AreEqual("Learn C#", ebook.Title);
        Assert.AreEqual(5, ebook.FileSizeMb);
        Assert.AreEqual("Learn C# (Ebook, 5MB)", ebook.GetInfo());
    }
}
