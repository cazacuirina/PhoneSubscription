using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_PROIECT
{
    public partial class FormAbon : Form
    {
        public Client clt;
        int contor = 0;
        public Contract contract;
        public Double Suma;
        public string numarNou;
        int optiune;
        public List<TipAbonament> lista_abon;
        public List<ExtraOptiuni> lista_opt;
        
        public FormAbon( Client client, int optiune, Contract contract)
        {
            InitializeComponent();
            this.clt = client;
            this.optiune = optiune;
            this.contract = contract;

            if (optiune != 1)
            {
                butonPlati.Visible = false;
            }

            if (optiune == 0)
            {
                TBNrNou.Visible = true;
                label4.Visible = true;
                Random r = new Random(); string numar = "";
                for (int i = 0; i < 8; i++)
                {
                    int nr = r.Next(0, 9); numar = numar + nr.ToString();
                }
                TBNrNou.Text = "07" + numar.ToString();
                numarNou = "07" + numar.ToString();
            }
            else
            {
                TBNrNou.Visible = false;
                label4.Visible = false;
            }

            if (optiune == 1)
            {
                TBSituatie.Visible = true;
                TBNrNou.Visible = false;
                label4.Visible = false;
                CBRetea.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label8.Visible = false;
                TBDurata.Visible = false;
                monthCalendar1.Visible = false;
            }
            else
            {
                TBSituatie.Visible = false;
            }

            if (optiune == 2)
            {
                CBRetea.Visible = true;
                label6.Visible = true;
            }
            else
            {
                CBRetea.Visible = false;
                label6.Visible = false;
            }
            if (optiune == 3)
            {
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }

            TipAbonament a0 = new TipAbonament("", 1, "", "", "", "", new int[] { 1, 1, 1, 1, 1, 1 });
            TipAbonament a1 = new TipAbonament("Diamond", 27, "Nelimitat", "Nelimitat", "Nelimitat", "Nelimitat", new int[] { 100, 15, 225, 50, 600, 65 });
            TipAbonament a2 = new TipAbonament("Platinum", 23.99, "Nelimitat", "50", "Nelimitat", "500", new int[] { 100, 15, 225, 50, 600, 65 });
            TipAbonament a3 = new TipAbonament("Gold", 19.89, "Nelimitat", "40", "Nelimitat", "400", new int[] { 70, 10, 150, 20, 550, 40 });
            TipAbonament a4 = new TipAbonament("Silver", 15.5, "35", "30", "350", "300", new int[] { 70, 10, 150, 20, 550, 40 });
            TipAbonament a5 = new TipAbonament("Bronze", 10.99, "20", "20", "250", "200", new int[] { 65, 8, 100, 20, 500, 30 });
            TipAbonament a6 = new TipAbonament("Special", 7.98, "15", "10", "150", "100", new int[] { 65, 8, 100, 20, 450, 25 });
            TipAbonament a7 = new TipAbonament("Optim", 7.98, "Nelimitat", "15", "Nelimitat", "90", new int[] { 70, 10, 155, 25, 0, 0 });

            ExtraOptiuni op0 = new ExtraOptiuni("", 1, 1);
            ExtraOptiuni op1 = new ExtraOptiuni("Minute nationale", 0.32, 150);
            ExtraOptiuni op2 = new ExtraOptiuni("Minute internationale", 0.56, 100);
            ExtraOptiuni op3 = new ExtraOptiuni("GB intern", 1.09, 30);
            ExtraOptiuni op4 = new ExtraOptiuni("GB extern", 1.21, 20);
            ExtraOptiuni op5 = new ExtraOptiuni("Telefon nou", 249.99, 1);
            ExtraOptiuni op6 = new ExtraOptiuni("Servicii tv", 178.89, 1);

           lista_abon = new List<TipAbonament>() { a0, a1, a2, a3, a4, a5, a6 };
            comboBox1.DataSource = lista_abon.Select(x => x.denumire).ToList();


            lista_opt = new List<ExtraOptiuni>() { op0, op1, op2, op3, op4, op5, op6 };
            comboBox2.DataSource = lista_opt.Select(x => x.denumireOptiune).ToList();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string denumire = (string)comboBox2.SelectedItem;
            if (comboBox2.SelectedItem != null)
            {
                foreach (ExtraOptiuni op in lista_opt)
                {
                    if (op.denumireOptiune == denumire)
                        if (denumire != "")
                        {
                            Suma = Suma + op.pretOptiune * op.cantitateOptiune;
                            TBRez.Text = Suma.ToString();
                            TBFactura.Text += ("\r\nAti ales Optiunea: " + op.denumireOptiune + " cu pretul de: " + op.pretOptiune + " ron\r\n");
                            
                            contract.extraOptiuni.Add(op);
                        }
                }

                }

        }

        private void Abon(string denumire)
        {
            foreach (TipAbonament ab in lista_abon)
            {
                if (ab.denumire == denumire)
                    if (denumire != "")
                    {
                        Suma = Suma + ab.pretLunar;
                        TBRez.Text = (Suma).ToString();
                        TBFactura.Text += "\r\nAti optat pentru abonamentul: " + ab.denumire + " cu pretul lunar de " + ab.pretLunar + " ron\r\n";

                        contract.tipAbonament.Add(ab);

                    }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string denumire = (string)comboBox1.SelectedItem;
            contor++;
            if (comboBox1.SelectedItem != null)
            {
                if (contor > 2)
                {
                    DialogResult rez = MessageBox.Show("Mai doriti un abonament?", "Abonament", MessageBoxButtons.YesNo);
                    if (rez == DialogResult.Yes || contor < 2)
                    {
                        Abon(denumire);
                    }

                }
                else
                {
                    Abon(denumire);
                }
            }
        }

        private void butonPlati_Click(object sender, EventArgs e)
        {
            if (butonPlati.Text == "Vizualizeaza situatia!")
            {
                butonPlati.Text = "Gata! Am citit!";
                TBSituatie.Text += "Clientul nostru: " + contract.client.nume + "\r\n";
                TBSituatie.Text += "A optat pentru abonamentele:\r\n";
                foreach (TipAbonament ab in contract.tipAbonament)
                    TBSituatie.Text += ab.denumire + "\r\n";
                TBSituatie.Text += "A ales si extraoptiunile:\r\n";
                foreach (ExtraOptiuni op in contract.extraOptiuni)
                    TBSituatie.Text += op.denumireOptiune + "\r\n";
                TBSituatie.Text += "Pentru luna curenta, clientul are de achitat " + contract.pretTotal + " ron\r\n";
                TBSituatie.Text += "Contractul a inceput la data de: " + contract.dataSemnare.ToShortDateString() + "\r\nsi expira la data de: " + contract.dataExpirare.ToShortDateString();
            }
            else
                this.Hide();
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            int durata;
            durata = Convert.ToInt32(TBDurata.Text);
            contract.dataSemnare = e.Start;
            contract.dataExpirare = contract.dataSemnare.AddYears(durata);
            monthCalendar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contract.pretTotal = Suma;
        }
    }
}
