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
    public partial class FormClient : Form
    {
        public Client formular_client;
        int optiune;
        public FormClient(Client fc, int op)
        {
            InitializeComponent();
            formular_client = fc;
            optiune = op;

            buton1.Text = "Adauga!";
            if (fc != null)
            {
                buton1.Text = "Editeaza!";
                TBNume.Text = fc.nume;
                TBCNP.Text = fc.cnp;
                dateTimePicker1.Value = fc.dataNasterii;
                TBTelef.Text = fc.nrTelefon;
                TBMail.Text = fc.email;
                CBAbon.Text = fc.cart_abon;
                CBRet.Text = fc.retea;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formular_client is null)
                formular_client = new Client();
            formular_client.nume = TBNume.Text;
            formular_client.cnp = TBCNP.Text;
            formular_client.dataNasterii = dateTimePicker1.Value;
            formular_client.nrTelefon = TBTelef.Text;
            formular_client.email = TBMail.Text;
            formular_client.cart_abon = CBAbon.Text;
            formular_client.retea = CBRet.Text;
        }

        private void TBNume_Validating(object sender, CancelEventArgs e)
        {
            if (optiune == 2)
            {
                TBNume.ReadOnly = true;
            }
            else
            {
                if (TBNume.Text.Length < 5 || TBCNP.Text.All(char.IsLetter) != true)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(TBNume, "nume scurt");
                }
                else
                {
                    errorProvider1.SetError(TBNume, "");
                }
            }
        }

        private void TBCNP_Validating(object sender, CancelEventArgs e)
        {
            if (TBCNP.Text.Length != 13 || TBCNP.Text.All(char.IsDigit)!=true)
            {
                e.Cancel = true;
                errorProvider2.SetError(TBCNP, "cnp incorect");
            }
            else
            {
                errorProvider2.SetError(TBCNP, "");
            }
        }

        private void TBTelef_Validating(object sender, CancelEventArgs e)
        {
            if ((TBTelef.Text.Length == 10 && (TBTelef.Text.Substring(0, 2) == "07" || TBTelef.Text.Substring(0, 2) == "02")) || TBTelef.Text == "N/A")
            {
                errorProvider3.SetError(TBTelef, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider3.SetError(TBTelef, "telefon invalid");
            }
        }

        private void TBMail_Validating(object sender, CancelEventArgs e)
        {
            if (TBMail.Text.Contains("@gmail.com") !=true && TBMail.Text.Contains("@yahoo.com") != true)
            {
                e.Cancel = true;
                errorProvider4.SetError(TBMail, "adresa mail necunoscuta");
            }
            else
            {
                errorProvider4.SetError(TBMail, "");
            }
        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    formular_client.dataNasterii = dateTimePicker1.Value;
        //}
    }
}
