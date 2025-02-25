public class Magazine : Item, IPubs
{
    private string volume;
    private int number;
    private string title;
    private int year;

    public Magazine(string volume, int number, string title, int year, long invNumber) : base (invNumber)
    {
        this.volume = volume;
        this.number = number;
        this.title = title;
        this.year = year;
    }

    public Magazine() {}

    new public void Show()
    {
        Console.WriteLine($"\nMagazine \"{title}\":\nVolume: \"{volume}\"   Number: {number}\nTitle: \"{title}\"    Year of release: {year}");
        base.Show();
    }

    public override void Return()
    {
        is_taken = false;
    }

    public bool IfSubs { get; set; }
    public void Subs()
    {
    Console.WriteLine("Подписка на журнал \"{0}\": {1}." ,title, IfSubs);
    }
}
