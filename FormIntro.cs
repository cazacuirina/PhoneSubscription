using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace PAW_PROIECT
{
    public partial class FormIntro : Form
    {
        int ct = 0;
        int l = 0;
        string txt;
        SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D: \USERS\IRINA\facultate\an 2\sem 2\PAW_PROIECT\Database1.mdf;Integrated Security=True");
        public FormIntro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.DialogResult == DialogResult.OK)
            {
                String user = TBEmail.Text;
                Form1 f = new Form1(user);
                f.ShowDialog();
                
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = txt.Substring(0, ct);
            ++ct;
            if (PB2.Location.X <240)
                PB2.Location = new Point(PB2.Location.X + 40, PB2.Location.Y);
            else
                PB2.Location = new Point(PB2.Location.X - 170, PB2.Location.Y);
            if (ct > l)
            {
                button1.Visible = true;
                button2.Visible = true;
                TBEmail.Visible = true;
                TBParola.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                timer1.Stop();
                PB2.Visible = false;
            }
        }

        private void FormIntro_Load_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            TBEmail.Visible = false;
            TBParola.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            txt = label1.Text;
            l = txt.Length;
            label1.Text = "";
            timer1.Start();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand scom = new SqlCommand("insert into Utilizatori values ('"+TBemail.Text+"','"+TBParola.Text+"' )",sc);
            //sc.Open();
            //scom.ExecuteNonQuery();
            //sc.Close();
            //MessageBox.Show("Cont nou de utilizator creat!");
        }
    }
}
