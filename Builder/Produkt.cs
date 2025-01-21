public class Produkt
{
    public int Pris { get; set; }
    public int Kg { get; set; }
    public string Stoerrelse { get; set; }

    public Produkt(int pris, int kg, string stoerrelse)
    {
        Pris = pris;
        Kg = kg;
        Stoerrelse = stoerrelse;
    }
}