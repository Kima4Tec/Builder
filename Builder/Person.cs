public class Person
{
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }
    public string Adresse { get; set; }
    public string Tlfnr { get; set; }

    public Person(string fornavn, string efternavn, string adresse, string tlfnr)
    {
        Fornavn = fornavn;
        Efternavn = efternavn;
        Adresse = adresse;
        Tlfnr = tlfnr;
    }
}