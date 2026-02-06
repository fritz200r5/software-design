namespace lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }


            public virtual string GetInfo()
            {
                return $"[Book] {Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }

            public override string GetInfo()
            {
                return $"[Magazine] {Title} - Issue #{IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string FileFormat { get; set; }

            public override string GetInfo()
            {
                return $"[Ebook] {Title} by {Author} ({FileFormat})";
            }
        }


        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"[Textbook] {Title} by {Author} - Subject: {Subject}";
            }
        }

        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public string Narrator { get; set; }

            public override string GetInfo()
            {
                return $"[AudioBook] {Title} - Narrated by {Narrator} ({Duration} hrs)";
            }
        }

        private void DisplayBooks(Book[] books)
        {
            bookListbox.Items.Clear();

            foreach (Book b in books)
            {
                bookListbox.Items.Add(b.GetInfo());
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] library = new Book[]
            {
                  new Magazine
                {
                    Title = "WIRED",
                    Author = "WIRED Editorial Team",
                    IssueNumber = 417
                },
                new Textbook
                {
                    Title = "The Inevitable: Understanding the 12 Technological Forces That Will Shape Our Future",
                    Author = "Kevin Kelly",
                    Subject = "Technology Trends"
                },
                new Ebook
                {
                    Title = "Toxic Positivity: Keeping It Real in a World Obsessed with Being Happy",
                    Author = "Whitney Goodman, LMFT",
                    FileFormat = "PDF"
                },
                new Book
                {
                    Title = "The 48 Laws of Power",
                    Author = "Robert Greene"
                },
                new AudioBook
                {
                    Title = "The Richest Man in Babylon",
                    Author = "George S. Clason",
                    Narrator = "Grover Gardner",
                    Duration = 4.07
                }
            };

            DisplayBooks(library);
        }
    }
}
