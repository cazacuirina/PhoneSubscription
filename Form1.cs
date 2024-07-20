using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace PAW_PROIECT
{

    public partial class Form1 : Form
    {
        public List<Contract> plati = new List<Contract>();
        public List<Client> listaClienti = new List<Client>();
        public String user;

        public int poz = 50; public int crt = 0;
        public Form1(String user)
        {
            InitializeComponent();

            this.user = user;

            TBFisier.Visible = false;
            TV.Visible = false;
            butonInchide.Visible = false;
            button1.Visible = false;
            button3.Visible = false;

            Client c1 = new Client("Simionescu Raluca", "6101280140056", new DateTime(1980, 12, 10), "0710756341", "simionescu_ralu@gmail.com", "Abonament", "Digi");
            Client c2 = new Client("Androne Ada", "6101400627354", new DateTime(2000, 10, 14), "N/A", "androne_ada@yahoo.com", "Abonament", "Telekom");
            Client c3 = new Client("Popescu Marian", "5070995198870", new DateTime(1995, 09, 07), "0713425675", "marian_office@gmail.com", "Abonament", "Vodafone");
            Client c4 = new Client("Costea Evelyn", "6051175614238", new DateTime(1975, 11, 05), "0734716220", "evy75costea@yahoo.com", "Cartela", "Telekom");
            Client c5 = new Client("Marcu Stefan", "5040790883614", new DateTime(1990, 07, 04), "0798635472", "stefan07mrk@gmail.com", "Cartela", "Orange");
            Client c6 = new Client("Ioana Cristea", "6087890112132", new DateTime(1985, 06, 01), "0724115623", "ioana_cristea@yahoo.com", "N/A", "N/A");

            listaClienti.Add(c1); listaClienti.Add(c2); listaClienti.Add(c3); listaClienti.Add(c4); listaClienti.Add(c5); listaClienti.Add(c6);

            ListViewItem lv = new ListViewItem(new string[] { c1.nume, c1.cnp, String.Format("{0:d}", c1.dataNasterii), c1.nrTelefon, c1.email, c1.cart_abon, c1.retea, "NU" });
            lv.Tag = c1;
            listView1.Items.Add(lv);

            lv = new ListViewItem(new string[] { c2.nume, c2.cnp, String.Format("{0:d}", c2.dataNasterii), c2.nrTelefon, c2.email, c2.cart_abon, c2.retea, "DA" });
            lv.Tag = c2;
            listView1.Items.Add(lv);

            lv = new ListViewItem(new string[] { c3.nume, c3.cnp, String.Format("{0:d}", c3.dataNasterii), c3.nrTelefon, c3.email, c3.cart_abon, c3.retea, "NU" });
            lv.Tag = c3;
            listView1.Items.Add(lv);

            lv = new ListViewItem(new string[] { c4.nume, c4.cnp, String.Format("{0:d}", c4.dataNasterii), c4.nrTelefon, c4.email, c4.cart_abon, c4.retea, "NU" });
            lv.Tag = c4;
            listView1.Items.Add(lv);

            lv = new ListViewItem(new string[] { c5.nume, c5.cnp, String.Format("{0:d}", c5.dataNasterii), c5.nrTelefon, c5.email, c5.cart_abon, c5.retea, "NU" });
            lv.Tag = c5;
            listView1.Items.Add(lv);

            lv = new ListViewItem(new string[] { c6.nume, c6.cnp, String.Format("{0:d}", c6.dataNasterii), c6.nrTelefon, c6.email, c6.cart_abon, c6.retea, "NU" });
            lv.Tag = c6;
            listView1.Items.Add(lv);

            TreeNode t = new TreeNode(c1.nume); TV.Nodes.Add(t);
            t = new TreeNode(c2.nume); TV.Nodes.Add(t);
            t = new TreeNode(c3.nume); TV.Nodes.Add(t);
            t = new TreeNode(c4.nume); TV.Nodes.Add(t);
            t = new TreeNode(c5.nume); TV.Nodes.Add(t);
            t = new TreeNode(c6.nume); TV.Nodes.Add(t);

            int poz = 0;
            foreach (Client c in listaClienti)
            {
                if (c.email == user)
                {
                    ListViewItem lv1 = listView1.Items[poz];
                    lv1.BackColor = Color.LightPink;
                }
                poz++;
            }

            FormAbon fab = new FormAbon(null, 5, null);
            List<TipAbonament> a = new List<TipAbonament> { fab.lista_abon[2] };
            List<ExtraOptiuni> o = new List<ExtraOptiuni> { fab.lista_opt[1], fab.lista_opt[3] };
            Contract con = new Contract(a, o, c2, new DateTime(2021, 06, 12), new DateTime(2023, 06, 12), 104.69);
            plati.Add(con);

            t = TV.Nodes[1];
            TV.Nodes[1].Nodes.Add("Contract");
            TV.Nodes[1].Nodes[0].Nodes.Add("Abonamente");
            TV.Nodes[1].Nodes[0].Nodes[0].Nodes.Add(a[0].denumire);
            TV.Nodes[1].Nodes[0].Nodes.Add("Extra Optiuni");
            TV.Nodes[1].Nodes[0].Nodes[1].Nodes.Add(o[0].denumireOptiune);
            TV.Nodes[1].Nodes[0].Nodes[1].Nodes.Add(o[1].denumireOptiune);
        }

        private void ButonClient_Click(object sender, EventArgs e)
        {
            Client cltFormular = null;
            FormClient form_clt = new FormClient(cltFormular, 1);

            form_clt.ShowDialog();
            if (form_clt.DialogResult == DialogResult.OK)
            {
                cltFormular = form_clt.formular_client;

                listaClienti.Add(cltFormular);
                TreeNode t = new TreeNode(cltFormular.nume); TV.Nodes.Add(t);
                ListViewItem lv = new ListViewItem();
                lv = new ListViewItem(new string[] { cltFormular.nume, cltFormular.cnp, String.Format("{0:d}", cltFormular.dataNasterii), cltFormular.nrTelefon, cltFormular.email, cltFormular.cart_abon, cltFormular.retea });
                lv.Tag = cltFormular;
                listView1.Items.Add(lv);
               
            }
            //SE INCHIDE FORM1 INDIFERENT DE REZULTAT
        }

        private void NodNou(Contract c, int poz, int ind)
        {
            TV.Nodes[poz].Nodes.Add("Contract");
            TV.Nodes[poz].Nodes[ind].Nodes.Add("Abonamente");
            for (int i = 0; i < c.tipAbonament.Count; i++)
                TV.Nodes[poz].Nodes[ind].Nodes[0].Nodes.Add(c.tipAbonament[i].denumire);
            TV.Nodes[poz].Nodes[ind].Nodes.Add("Extra Optiuni");
            for (int i = 0; i < c.extraOptiuni.Count; i++)
                TV.Nodes[poz].Nodes[ind].Nodes[1].Nodes.Add(c.extraOptiuni[i].denumireOptiune);
        }
        private void creareAbonamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client cltFormularAb = null;
            int r = 0;
            ListViewItem lv;
            int poz;
            if (listView1.SelectedItems.Count > 0)
            {
                lv = listView1.SelectedItems[0];
                poz = lv.Index;
                cltFormularAb = listaClienti[poz];
                Contract c = new Contract(cltFormularAb);
                int ind = 0;
                foreach (Contract con in plati)
                {
                    if (con.client == cltFormularAb)
                    {
                        ind++;
                        r = 1;
                    }
                }
                if (r == 1)
                {
                    DialogResult rez = MessageBox.Show("Mai doriti sa creati un contract?", "Contracte", MessageBoxButtons.YesNo);
                    if (rez == DialogResult.Yes)
                    {
                        FormAbon formAbon = new FormAbon(cltFormularAb, 0, c);
                        formAbon.ShowDialog();

                        if (formAbon.DialogResult == DialogResult.OK)
                        {
                            plati.Add(c);
                            NodNou(c, poz, ind);
                            cltFormularAb.cart_abon = "Abonament";
                            lv.SubItems[5].Text = cltFormularAb.cart_abon;
                            cltFormularAb.retea = "Telekom";
                            lv.SubItems[6].Text = cltFormularAb.retea;
                            if (cltFormularAb.cart_abon == "Abonament" && cltFormularAb.retea == "Telekom")
                                lv.SubItems[7].Text = "DA";
                            cltFormularAb.nrTelefon = formAbon.TBNrNou.Text;
                            lv.SubItems[3].Text = cltFormularAb.nrTelefon;
                            listView1.Refresh();
                        }
                    }
                }
                else
                {
                    FormAbon formAbon1 = new FormAbon(cltFormularAb, 0, c);
                    formAbon1.ShowDialog();

                    if (formAbon1.DialogResult == DialogResult.OK)
                    {
                        plati.Add(c);
                        NodNou(c, poz, 0);
                        cltFormularAb.cart_abon = "Abonament";
                        lv.SubItems[5].Text = cltFormularAb.cart_abon;
                        cltFormularAb.retea = "Telekom";
                        lv.SubItems[6].Text = cltFormularAb.retea;
                        if (cltFormularAb.cart_abon == "Abonament" && cltFormularAb.retea == "Telekom")
                            lv.SubItems[7].Text = "DA";
                        cltFormularAb.nrTelefon = formAbon1.TBNrNou.Text;
                        lv.SubItems[3].Text = cltFormularAb.nrTelefon;
                        listView1.Refresh();
                    }
                }
            }
            else
                MessageBox.Show("Alege un client pentru a-i crea abonamentul!");
        }

        private void vizualizareSituatiePlatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client cltFormularAb = null;
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv;
                int poz;
                lv = listView1.SelectedItems[0];
                poz = lv.Index;
                cltFormularAb = listaClienti[poz];
                foreach (Contract c in plati)
                {
                    if (c.client == cltFormularAb)
                    {
                        FormAbon formAbon = new FormAbon(cltFormularAb, 1, c);
                        formAbon.ShowDialog();
                    }

                }
            }
            else
                MessageBox.Show("Alege Clientul!");
        }

        private void migrareCartelaAbonamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client cltFormularAb = null;
            int r = 0;
            ListViewItem lv;
            int poz;
            int ind = 0;
            if (listView1.SelectedItems.Count > 0)
            {
                lv = listView1.SelectedItems[0];
                poz = lv.Index;
                cltFormularAb = listaClienti[poz];
                Contract c = new Contract(cltFormularAb);

                foreach (Contract con in plati)
                {

                    if (con.client == cltFormularAb)
                    {
                        ind++;
                        r = 1;
                    }
                }
                if (r == 1)
                {
                    DialogResult rez = MessageBox.Show("Mai doriti sa creati un contract?", "Contracte", MessageBoxButtons.YesNo);
                    if (rez == DialogResult.Yes)
                    {
                        FormAbon formAbon = new FormAbon(cltFormularAb, 3, c);
                        formAbon.ShowDialog();

                        if (formAbon.DialogResult == DialogResult.OK)
                        {
                            plati.Add(c);
                            NodNou(c, poz, ind);
                            cltFormularAb.cart_abon = "Abonament";
                            if (cltFormularAb.retea == "Telekom")
                                lv.SubItems[7].Text = "DA";
                            lv.SubItems[5].Text = cltFormularAb.cart_abon;
                            listView1.Refresh();
                        }
                    }
                }
                else
                {
                    FormAbon formAbon1 = new FormAbon(cltFormularAb, 3, c);
                    formAbon1.ShowDialog();

                    if (formAbon1.DialogResult == DialogResult.OK)
                    {
                        plati.Add(c);
                        NodNou(c, poz, 0);
                        cltFormularAb.cart_abon = "Abonament";
                        if (cltFormularAb.retea == "Telekom")
                            lv.SubItems[7].Text = "DA";
                        lv.SubItems[5].Text = cltFormularAb.cart_abon;
                        listView1.Refresh();
                    }
                }
            }
            else
                MessageBox.Show("Alege un client pentru a-i modifica abonamentul!");
        }

        private void portareDinAltaReteaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client cltFormularAb = null;
            int r = 0;
            ListViewItem lv;
            int poz;
            if (listView1.SelectedItems.Count > 0)
            {
                lv = listView1.SelectedItems[0];
                poz = lv.Index;
                cltFormularAb = listaClienti[poz];
                int ind = 0;
                foreach (Contract con in plati)
                {
                    if (con.client == cltFormularAb)
                    {
                        ind++; r = 1;
                    }
                }
                if (r == 1)
                {
                    DialogResult rez = MessageBox.Show("Mai doriti sa creati un contract?", "Contracte", MessageBoxButtons.YesNo);
                    if (rez == DialogResult.Yes)
                    {
                        Contract c = new Contract(cltFormularAb);

                        FormAbon formAbon = new FormAbon(cltFormularAb, 2, c);
                        formAbon.ShowDialog();

                        if (formAbon.DialogResult == DialogResult.OK)
                        {
                            plati.Add(c);
                            NodNou(c, poz, ind);
                            cltFormularAb.retea = formAbon.CBRetea.Text;
                            if (cltFormularAb.cart_abon == "Cartela")
                            {
                                cltFormularAb.cart_abon = "Abonament";
                                lv.SubItems[5].Text = cltFormularAb.cart_abon;
                            }
                            if (cltFormularAb.retea == "Telekom")
                                lv.SubItems[7].Text = "DA";
                            else
                                lv.SubItems[7].Text = "NU";
                            lv.SubItems[6].Text = cltFormularAb.retea;
                            listView1.Refresh();
                        }
                    }
                }
                else
                {
                    Contract c1 = new Contract(cltFormularAb);

                    FormAbon formAbon1 = new FormAbon(cltFormularAb, 2, c1);
                    formAbon1.ShowDialog();

                    if (formAbon1.DialogResult == DialogResult.OK)
                    {
                        plati.Add(c1);
                        NodNou(c1, poz, 0);
                        cltFormularAb.retea = formAbon1.CBRetea.Text;
                        if (cltFormularAb.cart_abon == "Cartela")
                        {
                            cltFormularAb.cart_abon = "Abonament";
                            lv.SubItems[5].Text = cltFormularAb.cart_abon;
                        }
                        if (cltFormularAb.retea == "Telekom")
                            lv.SubItems[7].Text = "DA";
                        else
                            lv.SubItems[7].Text = "NU";
                        lv.SubItems[6].Text = cltFormularAb.retea;
                        listView1.Refresh();
                    }
                }
            }
            else
                MessageBox.Show("Alege un client pentru a-i modifica abonamentul!");
        }

        private void salvareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere plati(*.plt)|*.plt";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter serializator = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);

                serializator.Serialize(fisier, plati);
                fisier.Close();
            }
        }

        private void deschidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere plati(*.plt)|*.plt";
            fd.CheckFileExists = true;
            button1.Visible = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                TBFisier.Visible = true;
                butonInchide.Visible = true;
                button2.Visible = false;
                button4.Visible = false;
                List<Contract> lista = new List<Contract>();

                BinaryFormatter deserializator = new BinaryFormatter();
                Stream fisier = File.OpenRead(fd.FileName);

                lista.AddRange((List<Contract>)deserializator.Deserialize(fisier));

                fisier.Close();
                TBFisier.Clear();
                foreach (Contract c in lista)
                {
                    TBFisier.Text += "Clientul " + c.client.nume + " din reteaua " + c.client.retea + " a optat pentru abonamentele: \r\n";
                    foreach (TipAbonament ab in c.tipAbonament)
                    {
                        TBFisier.Text += " - " + ab.denumire + " - ";
                    }
                    TBFisier.Text += "\r\n si pentru axtra optiunile:\r\n";
                    foreach (ExtraOptiuni op in c.extraOptiuni)
                    {
                        TBFisier.Text += " - " + op.denumireOptiune + " - ";
                    }
                    TBFisier.Text += "\r\nPentru luna curenta, clientul are de achitat " + c.pretTotal + " ron\r\n";
                    TBFisier.Text += "\r\nContractul a inceput la data de: " + c.dataSemnare.ToShortDateString() + "\r\nsi expira la data de: " + c.dataExpirare.ToShortDateString() + "\r\n\r\n";
                }
            }
        }

        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere plati(*.xml)|*.xml";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializatorXML = new XmlSerializer(typeof(List<Contract>));

                TextWriter writer = new StreamWriter(fd.FileName);

                serializatorXML.Serialize(writer, plati);
                writer.Close();
            }
        }

        private void deschidereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TBFisier.Visible = true;
            butonInchide.Visible = true;
            button2.Visible = false;
            button4.Visible = false;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere plati(*.xml)|*.xml";
            fd.CheckFileExists = true;
            button1.Visible = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer deserializator = new XmlSerializer(typeof(List<Contract>));

                List<Contract> lista = new List<Contract>();

                Stream reader = new FileStream(fd.FileName, FileMode.Open);

                lista.AddRange((List<Contract>)deserializator.Deserialize(reader));
                TBFisier.Clear();
                reader.Close();
                foreach (Contract c in lista)
                {
                    TBFisier.Text += "Clientul " + c.client.nume + " din reteaua " + c.client.retea + " a optat pentru abonamentele: \r\n";
                    foreach (TipAbonament ab in c.tipAbonament)
                    {
                        TBFisier.Text += " - " + ab.denumire + " - ";
                    }
                    TBFisier.Text += "\r\n si pentru axtra optiunile:\r\n";
                    foreach (ExtraOptiuni op in c.extraOptiuni)
                    {
                        TBFisier.Text += " - " + op.denumireOptiune + " - ";
                    }
                    TBFisier.Text += "\r\nPentru luna curenta, clientul are de achitat " + c.pretTotal + " ron\r\n";
                    TBFisier.Text += "\r\nContractul a inceput la data de: " + c.dataSemnare.ToShortDateString() + "\r\nsi expira la data de: " + c.dataExpirare.ToShortDateString();
                }

            }
        }

        private void butonInchide_Click(object sender, EventArgs e)
        {
            TBFisier.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

            if (plati.Count == 0)
                MessageBox.Show("Nu avem inca abonamente create", "Lista Goala");
            else
            {
                FormGrafic fg = new FormGrafic(plati, null, 1);
                fg.ShowDialog();
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.DoDragDrop(listView1.SelectedItems[0].Tag, DragDropEffects.Copy);
            }
        }

        private void label2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(new Client().GetType().ToString()))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void label2_DragDrop(object sender, DragEventArgs e)
        {
            Client clt = (Client)e.Data.GetData(e.Data.GetFormats()[0]);
            int ind = 0;
            listView1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            ButonClient.Visible = false;
            pictureBox1.Visible = false;
            button3.Visible = true;
            foreach (Contract c in plati)
                if (c.client.nume == clt.nume)
                {
                    ind++;
                    FormGrafic fg = new FormGrafic(null, c, 2);
                    fg.Text = "CONTRACTUL CU NR " + ind.ToString();
                    this.LayoutMdi(MdiLayout.TileVertical);
                    fg.BringToFront();
                    fg.Show();
                    fg.MdiParent = this;
                    
                }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ABONAMENTELE NOASTRE", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Pink, new Point(100, 100));
            e.Graphics.DrawString("DENUMIRE", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.DeepPink, new Point(30, 200));
            e.Graphics.DrawString("PRET LUNAR", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.DeepPink, new Point(150, 200));
            e.Graphics.DrawString("Minute National", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.DeepPink, new Point(290, 200));
            e.Graphics.DrawString("Minute Roaming", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.DeepPink, new Point(430, 200));
            e.Graphics.DrawString("GB Intern", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.DeepPink, new Point(580, 200));
            e.Graphics.DrawString("GB Extern", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.DeepPink, new Point(690, 200));

            FormAbon fa = new FormAbon(null, 5, null);
            for (int i = 1; i < 7; i++)
            {
                e.Graphics.DrawString(fa.lista_abon[i].denumire, new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new Point(30, 200 + 100 * i));
                e.Graphics.DrawString(fa.lista_abon[i].pretLunar.ToString(), new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new Point(150, 200 + 100 * i));
                e.Graphics.DrawString(fa.lista_abon[i].nrMINintern, new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new Point(290, 200 + 100 * i));
                e.Graphics.DrawString(fa.lista_abon[i].nrMINroaming, new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new Point(430, 200 + 100 * i));
                e.Graphics.DrawString(fa.lista_abon[i].nrGBintern, new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new Point(580, 200 + 100 * i));
                e.Graphics.DrawString(fa.lista_abon[i].nrGBroaming, new Font("Times New Roman", 16, FontStyle.Italic), Brushes.Black, new Point(690, 200 + 100 * i));
            }

            System.Drawing.Image img = System.Drawing.Image.FromFile("D:\\USERS\\IRINA\\facultate\\an 2\\sem 2\\PAW_PROIECT\\OIP.jpg");
            Point loc = new Point(550, 850);
            e.Graphics.DrawImage(img, loc);

        }

        private void abonamenteDisponibileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void extraOptiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("EXTRA OPTIUNILE DISPONIBILE", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Pink, new Point(100, 100));

            e.Graphics.DrawString("DENUMIRE", new Font("Times New Roman", 16, FontStyle.Underline), Brushes.DeepPink, new Point(80, 200));
            e.Graphics.DrawString("PRET LUNAR", new Font("Times New Roman", 16, FontStyle.Underline), Brushes.DeepPink, new Point(360, 200));
            e.Graphics.DrawString("CANTITATE", new Font("Times New Roman", 16, FontStyle.Underline), Brushes.DeepPink, new Point(510, 200));

            FormAbon fa = new FormAbon(null, 5, null);
            for (int i = 1; i < 7; i++)
            {
                e.Graphics.DrawString(fa.lista_opt[i].denumireOptiune, new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new Point(80, 200 + 100 * i));
                e.Graphics.DrawString(fa.lista_opt[i].pretOptiune.ToString(), new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new Point(360, 200 + i * 100));
                e.Graphics.DrawString(fa.lista_opt[i].cantitateOptiune.ToString(), new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new Point(510, 200 + i * 100));

            }
            System.Drawing.Image img = System.Drawing.Image.FromFile("D:\\USERS\\IRINA\\facultate\\an 2\\sem 2\\PAW_PROIECT\\OIP.jpg");
            Point loc = new Point(550, 850);
            e.Graphics.DrawImage(img, loc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TV.Visible = true;
            label6.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode t = TV.SelectedNode;
            while (t.Parent != null)
                t = t.Parent;
            foreach (Contract c in plati)
            {
                if (t.Text == c.client.nume)
                {
                    plati.Remove(c);
                    break;
                }
            }
            TV.SelectedNode.Remove();
        }

        private void stergeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client cltFormular = null;
            FormClient form_clt = new FormClient(cltFormular, 3);
            int poz;
            ListViewItem clt;
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem lv in listView1.SelectedItems)
                {
                    clt = lv;
                    poz = clt.Index;
                    cltFormular = listaClienti[poz];
                    listaClienti.Remove(cltFormular);
                    TreeNode t = TV.Nodes[poz];
                    t.Remove();
                    listView1.Items.Remove(clt);
                    listView1.Refresh();
                }
            }
        }

        private void editeazaClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
                MessageBox.Show("Alegeti un client!");
            else
            {
                foreach (ListViewItem lv in listView1.SelectedItems)
                {
                    Client cltFormular = (Client)lv.Tag;
                    int modif=0, i=0;
                    foreach(TreeNode t in TV.Nodes)
                    {
                        if (t.Text == cltFormular.nume)
                            modif = i;
                        ++i;
                    }

                    FormClient fc = new FormClient(cltFormular, 2);
                    fc.ShowDialog();
                    int poz = lv.Index;
                    listaClienti[poz] = cltFormular;
                    TV.Nodes[modif].Text = cltFormular.nume;
                    lv.Text = cltFormular.nume;
                    lv.SubItems[1].Text = cltFormular.cnp;
                    lv.SubItems[2].Text = cltFormular.dataNasterii.ToShortDateString();
                    lv.SubItems[3].Text = cltFormular.nrTelefon;
                    lv.SubItems[4].Text = cltFormular.email;
                    lv.SubItems[5].Text = cltFormular.cart_abon;
                    lv.SubItems[6].Text = cltFormular.retea;
                }
            }
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 850, 1100);
            int h = (int)e.PageSettings.PrintableArea.Height;
            while (crt < listaClienti.Count)
            {
                e.Graphics.DrawString("CLIENTUL CU NUMARUL DE INREGISTRARE:", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.DeepPink, new Point(30, poz));
                e.Graphics.DrawString("100" + ((crt + 1) * 10).ToString(), new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DeepPink, new Point(580, poz));
                poz += 75;

                e.Graphics.DrawString("NUME: " ,new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Fuchsia, new Point(30, poz));
                e.Graphics.DrawString(listaClienti[crt].nume, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(120, poz));
                e.Graphics.DrawString("CNP: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Fuchsia, new Point(290, poz));
                e.Graphics.DrawString(listaClienti[crt].cnp, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(360, poz));
                

                poz += 75;

                e.Graphics.DrawString("EMAIL: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Fuchsia, new Point(30, poz));
                e.Graphics.DrawString(listaClienti[crt].email, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(120, poz));
                e.Graphics.DrawString("TELEFON: ",new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Fuchsia, new Point(360, poz));
                e.Graphics.DrawString(listaClienti[crt].nrTelefon, new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new Point(490, poz));

                poz += 135;
                crt++;

                if (poz >= h)
                {
                    e.HasMorePages = true;
                    poz = 50;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
            e.Graphics.DrawString("TELEKOM", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.DeepPink, new Point(620, 750));
            e.Graphics.DrawString("Experiente impreuna", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.DeepPink, new Point(550, 800));
            System.Drawing.Image img = System.Drawing.Image.FromFile("D:\\USERS\\IRINA\\facultate\\an 2\\sem 2\\PAW_PROIECT\\OIP.jpg");
            Point loc = new Point(550, 850);
            e.Graphics.DrawImage(img, loc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //INTRODU NUMAR PAGINI in page setuptdialog vezi Ana
            //printer settings - all pages
            //printDocument3.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages;
            // printDocument3.PrintPage += printDocument3_PrintPage;
           
            if (printPreviewDialog3.ShowDialog() == DialogResult.OK)
            {
                printDocument3.Print();
            }
            //Bitmap pt prtsc copyfromscreen
            //drawimage(bmp)
            //panel 
            //getprintarea
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (FormGrafic fg in MdiChildren)
                fg.Dispose();
            listView1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
            ButonClient.Visible = true;
            pictureBox1.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDB fdb = new FormDB();
            fdb.ShowDialog();
        }
    }
 }

