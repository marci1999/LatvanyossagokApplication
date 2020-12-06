using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Varos
    {
        private int id;
        private string nev;
        private int lakosag;

        public Varos(int id, string nev, int lakosag)
        {
            this.id = id;
            this.nev = nev;
            this.lakosag = lakosag;
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

        public int getLakosag()
        {
            return this.lakosag;
        }

        public void setLakosag(int value)
        {
            this.lakosag = value; 
        }

        public override string ToString()
        {
            return string.Format(this.nev+" - "+this.lakosag+": lakossag fő");
        }
    }
}
