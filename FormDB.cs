using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW_PROIECT
{

    public partial class FormDB : Form
    {
        DataSet dsClienti = new DataSet();
        string conexiune = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBProiect;Integrated Security=True";
        string selectCmd = "select * from dbo.Clienti";
        public FormDB()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView1.Columns["Parola"].Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            textBox1.Visible = false;
            tbEmail.Visible = false;
            tbAbon.Visible = false;
            tbCnp.Visible = false;
            tbRetea.Visible = false;
            tbTelef.Visible = false;
            dateTimePicker1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            cbClt.Visible = false;
            lbClt.Visible = false;
        }
        private void LoadData()
        {
            SqlConnection conex = new SqlConnection(conexiune);
            conex.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(selectCmd, conex);
            adaptor.Fill(dsClienti, "Clienti");
            dsClienti.Tables["Clienti"].PrimaryKey = new DataColumn[1] { dsClienti.Tables["Clienti"].Columns["Id"] };
            conex.Close();
            cbClt.DataSource = dsClienti.Tables["Clienti"];
            cbClt.DisplayMember = "Nume";
            cbClt.ValueMember = "Id";
            textBox1.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Nume");
            tbEmail.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Email");
            tbTelef.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Numar Telefon");
            tbAbon.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "CartAbon");
            tbCnp.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "CNP");
            tbRetea.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Retea");
            dateTimePicker1.DataBindings.Add("Text", dsClienti.Tables["Clienti"], "Data Nasterii");
        }
        private void FormDB_Load(object sender, EventArgs e)
        {          
            this.clientiTableAdapter.Fill(this.dBProiectDataSet.Clienti);           
            this.extraOptiuniTableAdapter.Fill(this.dBProiectDataSet2.ExtraOptiuni);
            this.abonamenteTableAdapter.Fill(this.dBProiectDataSet1.Abonamente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Parole?")
            {
                dataGridView1.Columns["Parola"].Visible = true;
                button1.Text = "Shh!";
            }
            else
            {
                dataGridView1.Columns["Parola"].Visible = false;
                button1.Text = "Parole?";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            tbEmail.Visible = false;
            tbAbon.Visible = false;
            tbCnp.Visible = false;
            tbRetea.Visible = false;
            tbTelef.Visible = false;
            dateTimePicker1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            cbClt.Visible = false;
            lbClt.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            tbEmail.Visible = false;
            tbAbon.Visible = false;
            tbCnp.Visible = false;
            tbRetea.Visible = false;
            tbTelef.Visible = false;
            dateTimePicker1.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            cbClt.Visible = false;
            lbClt.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Editeaza Clienti!")
            {
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                pictureBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                tbEmail.Visible = true;
                textBox1.Visible = true;
                tbAbon.Visible = true;
                tbCnp.Visible = true;
                tbRetea.Visible = true;
                tbTelef.Visible = true;
                dateTimePicker1.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                cbClt.Visible = true;
                lbClt.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button2.Text = "Go back!";
            }
            else
            {
                dataGridView2.Visible = true;
                dataGridView3.Visible = true;
                pictureBox1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = false;
                tbEmail.Visible = false;
                tbAbon.Visible = false;
                tbCnp.Visible = false;
                tbRetea.Visible = false;
                tbTelef.Visible = false;
                dateTimePicker1.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                cbClt.Visible = false;
                lbClt.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button2.Text = "Editeaza Clienti!";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientiTableAdapter.Update(this.dBProiectDataSet.Clienti);
                MessageBox.Show("Am salvat modificarile!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindingManagerBase legatura = BindingContext[dsClienti.Tables["Clienti"]];
            legatura.EndCurrentEdit();

            string UpdateDB = "update dbo.Clienti set Nume=@Nume, DataNasterii=@DataNasterii, CNP=@CNP, Email=@Email, "+
                "NumarTelefon=@NumarTelefon, CartAbon=@CartAbon, Retea=@Retea where Id=@Id";

            SqlConnection conex = new SqlConnection(conexiune);
            conex.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(UpdateDB, conexiune);
            adaptor.UpdateCommand = conex.CreateCommand(); 

            adaptor.UpdateCommand.CommandText = UpdateDB;
            adaptor.UpdateCommand.Parameters.AddWithValue("@Nume", textBox1.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Data Nasterii", dateTimePicker1.Value);
            adaptor.UpdateCommand.Parameters.AddWithValue("@CNP", tbCnp.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Email", tbEmail.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Numar Telefon", tbTelef.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@CartAbon", tbAbon.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Retea", tbRetea.Text);
            adaptor.UpdateCommand.Parameters.AddWithValue("@Id", cbClt.SelectedValue);

            DataSet dsClientiUpdates = dsClienti.GetChanges(DataRowState.Modified);

            if (dsClientiUpdates != null)
            {
                int i = adaptor.Update(dsClientiUpdates, "Clienti");
                MessageBox.Show("Modificari pe " + i + " linii");
                dsClienti.Tables["Clienti"].AcceptChanges();
            }

            conex.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
