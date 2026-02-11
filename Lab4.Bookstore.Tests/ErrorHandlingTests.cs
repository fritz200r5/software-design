using Lab4.Bookstore;

namespace Lab4.Bookstore.Tests;

[TestClass]
public class ErrorHandlingTests
{
    [TestMethod]
    public void TestInvalidMagazineCreation_ThrowsArgumentException()
    {
        Assert.ThrowsException<ArgumentException>(() =>
        {
            _ = new Magazine { Title = "Invalid", Author = "Jane Doe", IssueNumber = -1 };
        });
    }

    [TestMethod]
    public void TestBookWithEmptyTitle_ThrowsArgumentException()
    {
        Assert.ThrowsException<ArgumentException>(() =>
        {
            _ = new Book { Title = string.Empty, Author = "Author" };
        });
    }

    [TestMethod]
    public void TestTextbookWithEmptySubject_ThrowsArgumentException()
    {
        Assert.ThrowsException<ArgumentException>(() =>
        {
            _ = new Textbook { Title = "Software Design", Author = "Dr. Lee", Subject = "" };
        });
    }

    [TestMethod]
    public void TestValidTextbookCreation()
    {
        var textbook = new Textbook
        {
            Title = "Software Design Essentials",
            Author = "Dr. Lee",
            Subject = "Software Engineering"
        };

        Assert.AreEqual("Software Design Essentials (Textbook: Software Engineering) by Dr. Lee", textbook.GetInfo());
    }
}
