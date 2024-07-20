using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROIECT
{
    [Serializable]
    public class ExtraOptiuni
    {
        public string denumireOptiune;
        public double pretOptiune;
        public int cantitateOptiune;

        public ExtraOptiuni()
        {
            this.denumireOptiune = "N/A";
            this.pretOptiune = 0;
            this.cantitateOptiune = 0;
        }
        public ExtraOptiuni(string d, double p, int c)
        {
            this.denumireOptiune = d;
            this.pretOptiune = p;
            this.cantitateOptiune = c;
        }

    }
}
