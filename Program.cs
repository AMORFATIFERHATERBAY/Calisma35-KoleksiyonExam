using System;
using System.Collections;

namespace Calisma35_KoleksiyonExam
{
    class Gunluk : IComparable
    {
        public DateTime Tarih;
        public string Not;

        public Gunluk(string not, DateTime tarih)
        {
            Tarih = tarih;
            Not = not;
        }
        public int CompareTo(object o)
        {
            Gunluk g = (Gunluk)o;
            return Tarih.CompareTo(g.Tarih);
        }

    }
    class CompareToTest
    {
        static void Main(string[] args)
        {
            ArrayList notlar = new ArrayList();
            notlar.Add(new Gunluk("Adana", new DateTime(2003, 5, 20)));
            notlar.Add(new Gunluk("Ankara", new DateTime(2003, 4, 12)));
            notlar.Add(new Gunluk("İzmir", new DateTime(2003, 6, 5)));
            notlar.Add(new Gunluk("Antalya", new DateTime(2003, 4, 1)));

            EkranaYaz(notlar);

            notlar.Sort();

            EkranaYaz(notlar);
        }
        static void EkranaYaz(ArrayList aList)
        {
            foreach (Gunluk g in aList)
            {
                Console.Write("Gün: " + g.Tarih + ",");
                Console.Write("Not: " + g.Not + ",");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
