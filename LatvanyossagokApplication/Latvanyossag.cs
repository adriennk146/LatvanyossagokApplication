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
            string s;
            if (ar > 0)
            {
                s = nev + " - " + ar + " Ft ";
            }
            else
            {
                s= nev + " - Ingyenes" + " Ft ";
            }
            return s;
        }
    }
}
