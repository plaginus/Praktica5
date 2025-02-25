public class Book : Item
{
    private string author = "None";
    private string title = "None";
    private string publisher = "None";
    private int pages = 0;
    private int year = 0;
    private static double price = 9;
    private bool returnSrok;

    public Book(String author, String title, String publisher, int pages, int year, long invNumber) : base (invNumber)
    {
    this.author = author;
    this.title = title;
    this.publisher = publisher;
    this.pages = pages;
    this.year = year;
    }

    public Book(string author, string title) 
    {
        this.author = author;
        this.title = title;
    }

    public Book() {}

    static Book() {price = 10;}

    public override void Return()
    {
        if (returnSrok) is_taken = false;
        else is_taken = true;
    }

    public static void SetPrice(double price)
    {
        Book.price = price; 
    }

    public void SetBook(String author, String title, String publisher, int pages, int year)
    {
    this.author = author;
    this.title = title;
    this.publisher = publisher;
    this.pages = pages;
    this.year = year;
    }

    new public void Show()
    {
        Console.WriteLine($"\nBook info:\nAuthor: {author}    Title: {title}\nPublisher: {publisher}    Pages: {pages}\nYear: {year}    Rent for day: {Book.price}");
        base.Show();
    }

    public double PriceBook(int day)
    {
        return day * price;
    }

    public void ReturnSrok()
    {
        returnSrok = true;
    }
    public string GetTitle()
    {
        return title;
    }
}
