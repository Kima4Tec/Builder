using System;
using System.Collections.Generic;

namespace Builder
{
    internal class Program
    {
        static List<Produkt> produkter = new List<Produkt>();
        static Person person1;

        static void Main(string[] args)
        {

            OpretPerson("Abraham", "Lincoln", "Washington", "12345678");
            OpretPerson("Gilbert", "Skysovs", "Skovvej 2", "23456789");
            OpretPerson("Flomme", "Flømmesen", "Højen 7", "34567890");
            OpretPerson("Blomme", "Blommesen", "Møllevej 5", "45678901");
            OpretPerson("Alexandre", "Dupont", "Paris 1", "56789012");
            UdskrivPerson();

            produkter.Add(new Produkt(12, 1, "net"));
            produkter.Add(new Produkt(25, 2, "mellem"));

            UdregnPriserMedMoms();
        }

        static void OpretPerson(string fornavn, string efternavn, string adresse, string tlfnr)
        {
            person1 = new Person(fornavn, efternavn, adresse, tlfnr);
        }

        static void UdskrivPerson()
        {
            Console.WriteLine($"Personens data:");
            Console.WriteLine($"Navn: {person1.Fornavn} {person1.Efternavn}");
            Console.WriteLine($"Adresse: {person1.Adresse}");
            Console.WriteLine($"Telefonnummer: {person1.Tlfnr}");
            Console.WriteLine();
        }

        static void UdregnPriserMedMoms()
        {
            Console.WriteLine("Priser med moms:");

            foreach (var produkt in produkter)
            {
                double prisMedMoms = produkt.Pris * 1.25;
                Console.WriteLine($"Produkt ({produkt.Stoerrelse}) på {produkt.Kg} kg: {prisMedMoms} kr.");
            }
        }
    }
}
