using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Latvanyossag
    {
        string nev;
        string leiras;
        int ar;
        string varos;

        public Latvanyossag(string nev, string leiras, int ar, string varos)
        {
            this.nev = nev;
            this.leiras = leiras;
            this.ar = ar;
            this.varos = varos;
        }

        public string toString()
        {
            return nev + "\t" + leiras + "\t" + ar + " Ft \t" + varos;
        }
    }
}
