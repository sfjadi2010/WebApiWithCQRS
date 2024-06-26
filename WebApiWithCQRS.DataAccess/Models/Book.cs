namespace WebApiWithCQRS.DataAccess.Models;

public partial class Book
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public int YearPublished { get; set; }

    private Book() { }
    public Book(string title, string author, string genre, int yearPublished)
    {
        Id = Guid.NewGuid();
        Title = title;
        Author = author;
        Genre = genre;
        YearPublished = yearPublished;
    }
}
