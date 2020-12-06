using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Latvanyossag
    {
        int id;
        string nev;
        string leiras;
        int ar;
        int varosId;

        public Latvanyossag(int id, string nev, string leiras, int ar, int varosId)
        {
            this.id = id;
            this.nev = nev;
            this.leiras = leiras;
            this.ar = ar;
            this.varosId = varosId;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int value)
        {
            this.id = value;
        }

        public string getNev()
        {
            return this.nev;
        }

        public void setNev(string value)
        {
            this.nev = value;
        }

        public string getLeiras()
        {
            return this.leiras;
        }

        public void setLeiras(string value)
        {
            this.leiras = value;
        }

        public int getar()
        {
            return this.ar;
        }

        public void setar(int value)
        {
            this.ar = value;
        }

        public int getvarosId()
        {
            return this.varosId;
        }

        public void setvarosId(int value)
        {
            this.varosId = value;
        }

        public override string ToString()
        {
            if (this.ar > 0)
            {
                return string.Format(this.nev + " - " + this.ar + " Ft");
            }
            else
            {
                return string.Format(this.nev + " - ingyenes");
            }
        }
    }
}
