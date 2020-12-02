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
        int varos_id;

        public Latvanyossag(string nev, string leiras, int ar, int varos_id)
        {
            this.nev = nev;
            this.leiras = leiras;
            this.ar = ar;
            this.varos_id = varos_id;
        }

        public string ToString()
        {
            string s=nev;
            if (ar > 0)
            {
                s += " - " + ar + " Ft ";
            }
            else
            {
                s+=" - Ingyenes" + " Ft ";
            }
            return s;
        }
    }
}
