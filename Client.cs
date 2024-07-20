using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROIECT
{
    [Serializable]
   public class Client
    {
        public string nume;
        public string cnp;
        public DateTime dataNasterii;
        public string nrTelefon;
        public string email;
        public string cart_abon;
        public string retea;

        public Client()
        {
            this.nume = "NoName";
            this.cnp = "N/A";
            this.nrTelefon = "N/A";
            this.dataNasterii = System.DateTime.Today;
            this.email = "N/A";
            this.cart_abon = "N/A";
            this.retea = "N/A";
        }
        public Client(string n, string c, DateTime d, string t, string m, string ca, string r)
        {
            this.nume = n;
            this.cnp = c;
            this.dataNasterii = d;
            this.nrTelefon =t;
            this.email = m;
            this.cart_abon = ca;
            this.retea = r;
        }
    }
}
