using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("dit is een oefening in progress");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("oefening met integeres en strings");
            int x = 123;
            string y = "ad";
            Console.WriteLine(x + x + y);
            Console.WriteLine(y + x + x);
            Console.WriteLine();

            string z = $"{x} {x} {y}";
            Console.WriteLine(z);

            string b = "\"hallo \\ \\ \\\\unicode u2022 daar\"";
            Console.WriteLine(b);
            Console.ReadKey();

            Console.WriteLine();

            decimal geld = 20.5m;
            double waarde = 5;
            decimal ding = geld + (decimal)waarde;
            Console.WriteLine();
            Console.WriteLine("decimal en double optellen gaat op deze manier, zie alhier het antwoord: " + ding);
            Console.ReadKey();

            y = y.ToUpper();
            Console.WriteLine();
            Console.WriteLine("omzetten naar een upper, gaat via y = y.ToUpper " + y);
            Console.ReadKey();

            string naam1 = "adriaan";
            string naam2 = "wouter";


            bool result = (naam1 == naam2);
            /* bool result2 = (nummer1 < nummer2); */

            Console.WriteLine();
            Console.WriteLine("Bool vergelijking tussen twee strings");
            Console.WriteLine(result);
            Console.WriteLine();
            Console.ReadKey();

            string naar = x.ToString();

            Console.WriteLine(naar);
            Console.ReadKey();

            string proberen1 =naam1.ToString();

            Console.WriteLine(proberen1);
            Console.ReadKey();

            Console.WriteLine("voer alstublieft een bedrag in");
            decimal prijs = Decimal.Parse(Console.ReadLine());

            CultureInfo culture = CultureInfo.CreateSpecificCulture("nl");
            NumberFormatInfo format = culture.NumberFormat;

            string bedrag = prijs.ToString("C", format);

            Console.WriteLine(bedrag);
            Console.ReadKey();

            DateTime tijd = DateTime.Now;
            Console.WriteLine(tijd);
            Console.ReadKey();

            var dag = tijd.Day;
            var dagVanDeWeek = tijd.DayOfWeek;
            var dagVanHetJaar = tijd.DayOfYear;
            var tijdVanDeDag = tijd.TimeOfDay;
            int week = dagVanHetJaar / 7;

            Console.WriteLine();
            Console.WriteLine(dag);
            Console.WriteLine(dagVanDeWeek);
            Console.WriteLine(dagVanHetJaar);
            Console.WriteLine(tijdVanDeDag);
            Console.WriteLine();
            Console.WriteLine("De huidige week is week " + ( week + 1));
            Console.ReadKey();

            int dd = 1;
            int bb = 7;

            Console.WriteLine("test met integer gedeeld door integer, wordt inderdaad afgekapt op hele getal, ongeacht het decimale getal (voorbeeld 1/7 (is dus niet 0,14 maar 0)) = " + dd / bb);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

            string willekeurigedatum;
            DateTime rekendatum;

            Console.WriteLine("geef een datum op");
            willekeurigedatum = Console.ReadLine();
            rekendatum = Convert.ToDateTime(willekeurigedatum);

            Console.WriteLine("{0}-{1}-{2}", rekendatum.Day, rekendatum.Month, rekendatum.Year);

            DateTime tijd2 = rekendatum;
            var dagVanWillekeurigJaar = tijd2.DayOfYear;
            var dagVanWillekeurigeWeek = tijd2.DayOfWeek;
            int weekVanWilekeurigJaar = dagVanWillekeurigJaar / 7;

            if (rekendatum < DateTime.Today)
            {
                Console.WriteLine("dit was dag nummer " + dagVanWillekeurigJaar + " van dat jaar en dat was een " + dagVanWillekeurigeWeek + " en dat viel in de volgende week " + (weekVanWilekeurigJaar + 1));
            }
            else
                if (rekendatum == DateTime.Today)
                {
                    Console.WriteLine("dat is vandaag ! :)");
                }
            else
                Console.WriteLine("dit is dag nummer " + dagVanWillekeurigJaar + " van dat jaar en dat is een " + dagVanWillekeurigeWeek + " en dat valt in de volgende week " + (weekVanWilekeurigJaar + 1));

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("geef de eerste waarde op");
            double xbool1 = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("geef de tweede waarde op");
            double xbool2 = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            bool xboolTest = xbool1 < xbool2;
            Console.WriteLine("is getal 1 kleiner dan getal 2: " + xboolTest);
            Console.ReadKey();
            Console.WriteLine();

            bool xbool3 = true;
            Console.WriteLine(xbool3);
            Console.WriteLine();
            Console.WriteLine("en met een uitroepteken ervoor wordt het als het goed is \"false\" " + !xbool3);
            
            Console.ReadKey();

            bool xbool4 = xboolTest || xbool3;
            Console.WriteLine();
            Console.WriteLine("wordt het true of false, ik denk true");
            Console.WriteLine(xbool4);
            Console.WriteLine();
            Console.ReadKey();



        }
    }
}
