using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versenyzok
{
    class Pilotak
    {
        string nev;
        string szulet;
        string nemzetiseg;
        string rajtszam;

        public Pilotak(string nev, string szulet, string nemzetiseg, string rajtszam)
        {
            this.nev = nev;
            this.szulet = szulet;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Szulet { get => szulet; set => szulet = value; }
        public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
        public string Rajtszam { get => rajtszam; set => rajtszam = value; }

    }
}
