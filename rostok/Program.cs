using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace rostok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Class1> lista = new List<Class1>();
            foreach (var i in File.ReadAllLines("rostok.txt").Skip(1))
            {
                lista.Add(new Class1(i));
            }

            Console.WriteLine($"3.feladat:  Az élelmiszerek száma: {lista.Count}");
            Console.WriteLine($"4.feladat: nem 100g-s egység: {lista.Where(x => x.Egyseg != "100g").Count()} ");
            Console.WriteLine($"5.feladat: friss gümölcsök átlagos rost tartalma: {lista.Where(x => x.Egyseg == "100g" && x.Kategoria == "Friss gyümölcsök").Average(x => x.Rost)}");
            //string a;
            //Console.Write($"6.feladat: kérekegy karakter láncot:");
            //a = Console.ReadLine();

            //lista.Where(x => x.MegNev == a);


            Console.WriteLine($"7.feladat: Kategóriák száma: {lista.GroupBy(x => x.Kategoria).Count()}");
            Console.WriteLine($"8.feladat: Statisztika");
            lista.GroupBy(x => x.Kategoria).Count();

        }
    }
}
