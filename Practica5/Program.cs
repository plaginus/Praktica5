using System;

class Program
{
    static void Main() 
    {
        Test1();
        Test2();
    }

    static void Test1()
    {
        Book b1 = new Book();
        Book b2 = new Book("Tolstoy", "War and Peace", "Scince and life", 1234, 2013, 101);
        Book b3 = new Book("Lermontov", "Mciri");

        b1.SetBook("Pushkin", "Captain's daughter", "Williams", 123, 2014);

        Magazine mag1 = new Magazine("Nature", 5, "We and Earth", 2014, 1235);
        mag1.Show();
        mag1.IfSubs = true;
        mag1.Subs();

        Item[] itmas = new Item[4]; 

        itmas[0] = b1;
        itmas[1] = b2;
        itmas[2] = b3;
        itmas[3] = mag1;

        Array.Sort(itmas);

        Console.WriteLine("\nСортировка по инвентарному номеру");
        foreach (Item x in itmas) x.Show();
    }

    static void Test2()
    {

        Console.WriteLine("\n////// Test: ArithmeticProgression \\\\\\\\\\\\\n");

        Console.WriteLine("Enter start number and increase number for arithmetic progression");
        int sn = Convert.ToInt32(Console.ReadLine());
        int en = Convert.ToInt32(Console.ReadLine());
        ArithmeticProgression ar1 = new ArithmeticProgression(sn, en);
        Console.WriteLine("Enter number for element progression");
        int kn = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{kn}-th element of progression is {ar1.GetElement(kn)}");

        Console.WriteLine("\n////// Test: GeometricProgression \\\\\\\\\\\\\n");

        Console.WriteLine("Enter start number and increase number for arithmetic progression");
        sn = Convert.ToInt32(Console.ReadLine());
        en = Convert.ToInt32(Console.ReadLine());
        GeometricProgression gr1 = new GeometricProgression(sn, en);
        Console.WriteLine("Enter number for element progression");
        kn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{kn}-th element of progression is {gr1.GetElement(kn)}");
    }
}