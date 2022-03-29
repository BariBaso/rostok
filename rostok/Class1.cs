using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rostok
{
    class Class1
    {
        public string MegNev { get; set; }
        public string Kategoria { get; set; }
        public string Egyseg { get; set; }
        public double Rost { get; set; }


        public Class1(string sor)
        {
            string[] s = sor.Split(';');

            MegNev = s[0];
            Kategoria = s[1];
            Egyseg = s[2];
            Rost = double.Parse(s[3]);
        }
    }
}
