using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA231019
{
    class Adat
    {
        public int Helyezes { get; set; }
        public int DarabSportolo { get; set; }
        public string Sportag { get; set; }
        public string Versenyszam { get; set; }
        public int OsszPontszam { get; set; }

        public Adat(string sor)
        {
            var atmeneti = sor.Split(' ');
            this.Helyezes = int.Parse(atmeneti[0]);
            this.DarabSportolo = int.Parse(atmeneti[1]);
            this.Sportag = atmeneti[2];
            this.Versenyszam = atmeneti[3];
            this.OsszPontszam = 0;
        }

        public override string ToString()
        {
            return $"{this.Helyezes} {this.DarabSportolo} {this.OsszPontszam} {this.Sportag} {this.Versenyszam}";
        }
    }
}
