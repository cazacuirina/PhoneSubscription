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
    public partial class FormGrafic : Form
    {
        public List<Contract> contract = new List<Contract>();
        Contract ct;
        int optiune;
        int nrobs;
        int[] x, y;
        int[] pie;
        int index = 0;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (optiune == 1)
            {
                /*Graphics g = e.Graphics;
                Rectangle zonaClient = e.ClipRectangle;
                Brush fundal = new SolidBrush(Color.White);
                g.FillRectangle(fundal, zonaClient);

                g.DrawString("BAR CHART", new Font("Mistral", 25), new SolidBrush(Color.Aqua), 20, 20);
                g.DrawString("Platile efectuate de clientii nostri", new Font("Mistral", 20), new SolidBrush(Color.CornflowerBlue), 20, 50);

                zonaClient.X += 20;
                zonaClient.Y += 20;
                zonaClient.Height -= 40;
                zonaClient.Width -= 40;

                int vl = zonaClient.Left;
                int vr = zonaClient.Right;
                int vt = zonaClient.Top;
                int vb = zonaClient.Bottom;
                int i;

                Pen creion_rosu = new Pen(Color.Red, 2);
                g.DrawRectangle(creion_rosu, zonaClient);

                int lat, dist;
                string denum = "";
                float rap_dist_lat = 0.2f; float max;

                SolidBrush[] vect_pensule = new SolidBrush[] { new SolidBrush(Color.Blue), new SolidBrush(Color.Green) };
                Pen[] vect_creioane = new Pen[] { new Pen(Color.Blue), new Pen(Color.Green) };
                SolidBrush pensula_crt;
                Pen crieon_crt;

                lat = (vr - vl) / (int)((nrobs + 1) * rap_dist_lat + nrobs);
                dist = (int)(lat * rap_dist_lat);
                for (max = y[0], i = 1; i < nrobs; i++)
                {
                    if (max < y[i])
                    {
                        max = y[i];
                    }
                }
                crieon_crt = vect_creioane[0];
                pensula_crt = vect_pensule[0];

                g.DrawLine(crieon_crt, vl, vt, vl, vb);
                g.DrawLine(crieon_crt, vl, vb, vr, vb);

                for (i = 0; i < nrobs; i++)
                {
                    pensula_crt = vect_pensule[i % vect_pensule.Length];
                    PointF pf = new PointF(
                        vl + i * (lat + dist) + dist,
                        vb - (float)y[i] * (vb - vt) / max);

                    SizeF sf = new SizeF(lat, y[i] * (vb - vt) / max);

                    g.FillRectangle(pensula_crt, new RectangleF(pf, sf));

                    TBgraf.Text += "\r\n( " + (int)pf.X + " , " + (int)pf.Y + " ) => " + (int)sf.Width + " , " + (int)sf.Height;

                    g.DrawString(denum, Font, pensula_crt,
                        vl + dist + lat / 2 + i * (lat + dist),
                        vb + 5);

                    TBgraf.Text += "\n\r";
                }*/
                Graphics g = e.Graphics;
                Rectangle r = panel2.ClientRectangle;

                g.DrawString("BAR CHART", new Font("Mistral", 25), new SolidBrush(Color.Aqua), 30, 20);
                g.DrawString("Platile efectuate de clientii nostri", new Font("Mistral", 16), new SolidBrush(Color.CornflowerBlue), 30, 50);

                int vl = r.X + 30;
                int vr = r.Width - 20;
                int vt = r.Top + 15;
                int vb = r.Height - 20;

                g.DrawRectangle(new Pen(Color.Red, 5), vl, vt, vr - vl, vb - vt);

                int nrobs = y.Length;
                int lat = (vr - vl) / nrobs;
                Brush[] pensule = new Brush[] { Brushes.Blue, Brushes.Aqua, Brushes.Green, Brushes.CornflowerBlue };

                for (int i = 0; i < nrobs; i++)
                {
                    g.FillRectangle(pensule[i % 4], vl + i * lat, vb - y[i], lat, y[i]);
                }
            }
            else
            {
                Graphics g = e.Graphics;
                SolidBrush[] brushesGf = new SolidBrush[] { new SolidBrush(Color.Aquamarine), new SolidBrush(Color.Blue), new SolidBrush(Color.Cyan), new SolidBrush(Color.Turquoise), new SolidBrush(Color.MintCream), new SolidBrush(Color.Green) };
                Point locGf = new Point(10, 10);
                Size sizeGf = new Size(150, 150);
                SolidBrush brushGf;

                float unghi = 0, buc = 0;
                Rectangle dr = new Rectangle(0, 0, panel2.Width, panel2.Height);
                for (int i=0; i<index; i++)
                {
                    TBgraf.Text += "Silce " + i + "  :  " + pie[i] + " %\r\n";
                    brushGf = brushesGf[i % brushesGf.Length];
                    buc = (float)(360f * pie[i] / 100);
                    g.FillPie(brushGf, dr, unghi, buc);
                    unghi += buc;
                }

            }
        }

        private void FormGrafic_Resize(object sender, EventArgs e)
        {
            panel2.Invalidate();
            TBgraf.Clear();
        }

        public FormGrafic(List<Contract> c, Contract ct, int op)
        {
            InitializeComponent();

            this.contract = c;
            this.ct = ct;
            this.optiune = op;
            if (optiune == 1)
            {
                nrobs = contract.Count();
                x = new int[] { 5, 10, 15, 20, 25, 30 };
                y = new int[nrobs];
                for (int i = 0; i < nrobs; i++)
                {
                    TBgraf.Text += "Clientul " + contract[i].client.nume + " plateste " + contract[i].pretTotal + " ron\r\n";
                    y[i] = (int)Decimal.Truncate((Decimal)contract[i].pretTotal);
                }
                this.ResizeRedraw = true;
            }
            else
            {
                TBgraf.Text += "Clientul " + ct.client.nume + " are de achitat: "+ct.pretTotal.ToString()+" ron\r\n\r\n";
                pie = new int[ct.tipAbonament.Count+ct.extraOptiuni.Count ];
                foreach (TipAbonament ab in ct.tipAbonament)
                {
                    TBgraf.Text += "Abonament: " + ab.denumire+" in valoare de "+ab.pretLunar+"\r\n\r\n";
                    pie[index] = (int)(Math.Round(100*ab.pretLunar/ ct.pretTotal));
                    index++;
                }
                foreach (ExtraOptiuni opt in ct.extraOptiuni)
                {
                    TBgraf.Text += "Extra Optiune: " + opt.denumireOptiune+" in valoare de "+(opt.pretOptiune*opt.cantitateOptiune).ToString()+"\r\n\r\n";
                    pie[index] = (int)(Math.Round(100*opt.pretOptiune*opt.cantitateOptiune / ct.pretTotal));
                    index++;
                }
                int suma = 0;
                for(int i=0; i<index; i++) { suma += pie[i]; }
                if (suma < 100) { pie[index - 1] = pie[index - 1] + 1; }
                if (suma > 100) { pie[index - 1] = pie[index - 1] - 1; }
            }

        }
    }
}
