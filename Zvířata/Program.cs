class Program
{
    static void Main()
    {
        Zvire pes = VytvorZvire.VytvorPsa(159);
        Zvire kocka = VytvorZvire.VytvorKocku(4562);

        Console.WriteLine($"{pes.Druh} vydává zvuk:");
        pes.VydavaniZvuku();
        
        Console.WriteLine($"{kocka.Druh} vydává zvuk:");
        kocka.VydavaniZvuku();
    }
}