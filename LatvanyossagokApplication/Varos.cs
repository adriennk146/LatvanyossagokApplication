using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Varos
    {
        string nev;
        int lakossag;

        public Varos(string nev, int lakossag)
        {
            this.Nev = nev;
            this.Lakossag = lakossag;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }

        public string toString()
        {
            return this.nev + " - Lakosság: " + this.lakossag+" fő";
        }
    }
}
