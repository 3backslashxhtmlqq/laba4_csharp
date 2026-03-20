namespace WinFormsApp12;

public class Book
{
    private string title;
    private string author;
    private int year;

    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }

    public Book()
    {
        this.title = "Неизвестно";
        this.author = "Неизвестен";
        this.year = 0;
    }

    public string GetInfo()
    {
        return "«" + title + "», " + author + " (" + year + ")";
    }
    
}