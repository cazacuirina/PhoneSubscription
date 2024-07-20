using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAW_PROIECT
{
    [Serializable]
    public class TipAbonament
        //MENIU
    {   
        public string denumire;
        public double pretLunar;
        public string nrGBintern; //float
        public string nrGBroaming;
        public string nrMINintern; //int
        public string nrMINroaming;
        public int [] viteze3G4G5G= { 0, 0, 0, 0, 0, 0 };

        public TipAbonament()
        {
            this.denumire = "N/A";
            this.pretLunar = 0;
            this.nrGBintern = "0";
            this.nrGBroaming = "0";
            this.nrMINintern = "0";
            this.nrMINroaming = "0";
        }
        public TipAbonament(string d, double p, string gbi, string gbe, string mini, string mine, int[] v)
        {
            this.denumire = d;
            this.pretLunar = p;
            this.nrGBintern = gbi;
            this.nrGBroaming = gbe;
            this.nrMINintern = mini;
            this.nrMINroaming = mine;
            for(int i=0; i<v.Length; i++)
            this.viteze3G4G5G[i] = v[i];
        }
    }
}
