using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROIECT
{[Serializable]
    public class Contract
    {
        public List<TipAbonament> tipAbonament = new List<TipAbonament>();
        public List<ExtraOptiuni> extraOptiuni=new List<ExtraOptiuni>();
        public Client client;
        public DateTime dataSemnare;
        public DateTime dataExpirare;
        public double pretTotal;

        public Contract(Client clt)
        {
            this.client = clt; 
        }

        public Contract()
        {
            this.client = null;
            this.tipAbonament = null;
            this.extraOptiuni = null;
        }
        public Contract(List<TipAbonament> lstAb, List<ExtraOptiuni> lstOpt, Client clt, DateTime dInc, DateTime dSf, double pr)
        {
            this.client = clt;
            this.pretTotal = pr;
            this.dataExpirare = dSf;
            this.dataSemnare = dInc;
            this.tipAbonament = lstAb;
            this.extraOptiuni = lstOpt;
        }
        
    }
}
