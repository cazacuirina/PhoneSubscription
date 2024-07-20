
namespace PAW_PROIECT
{
    partial class FormAbon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.TBRez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNrNou = new System.Windows.Forms.TextBox();
            this.TBFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBRetea = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.TBSituatie = new System.Windows.Forms.TextBox();
            this.butonPlati = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TBDurata = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TBDurata)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(124, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(258, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TBRez
            // 
            this.TBRez.Location = new System.Drawing.Point(148, 158);
            this.TBRez.Name = "TBRez";
            this.TBRez.Size = new System.Drawing.Size(234, 20);
            this.TBRez.TabIndex = 2;
            this.TBRez.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pret Total Lunar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extra Optiuni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Abonament";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Magenta;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(542, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gata! Am ales!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Noul Numar de telefon al dvs:";
            // 
            // TBNrNou
            // 
            this.TBNrNou.Location = new System.Drawing.Point(199, 218);
            this.TBNrNou.Name = "TBNrNou";
            this.TBNrNou.ReadOnly = true;
            this.TBNrNou.Size = new System.Drawing.Size(183, 20);
            this.TBNrNou.TabIndex = 8;
            // 
            // TBFactura
            // 
            this.TBFactura.Location = new System.Drawing.Point(426, 30);
            this.TBFactura.Multiline = true;
            this.TBFactura.Name = "TBFactura";
            this.TBFactura.Size = new System.Drawing.Size(387, 298);
            this.TBFactura.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumOrchid;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Am trecut de pe cartela la abonament!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Noua mea retea";
            // 
            // CBRetea
            // 
            this.CBRetea.FormattingEnabled = true;
            this.CBRetea.Items.AddRange(new object[] {
            "Telekom",
            "Vodafone",
            "Digi",
            "Orange"});
            this.CBRetea.Location = new System.Drawing.Point(148, 278);
            this.CBRetea.Name = "CBRetea";
            this.CBRetea.Size = new System.Drawing.Size(142, 21);
            this.CBRetea.TabIndex = 12;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(49, 337);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alegeti data inceperii contractului!";
            // 
            // TBSituatie
            // 
            this.TBSituatie.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSituatie.Location = new System.Drawing.Point(23, 12);
            this.TBSituatie.Multiline = true;
            this.TBSituatie.Name = "TBSituatie";
            this.TBSituatie.Size = new System.Drawing.Size(790, 434);
            this.TBSituatie.TabIndex = 15;
            this.TBSituatie.Visible = false;
            // 
            // butonPlati
            // 
            this.butonPlati.BackColor = System.Drawing.Color.Magenta;
            this.butonPlati.Location = new System.Drawing.Point(542, 452);
            this.butonPlati.Name = "butonPlati";
            this.butonPlati.Size = new System.Drawing.Size(143, 47);
            this.butonPlati.TabIndex = 16;
            this.butonPlati.Text = "Vizualizeaza situatia!";
            this.butonPlati.UseVisualStyleBackColor = false;
            this.butonPlati.Click += new System.EventHandler(this.butonPlati_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Alegeti durata valabilitatii contractului";
            // 
            // TBDurata
            // 
            this.TBDurata.Location = new System.Drawing.Point(305, 404);
            this.TBDurata.Name = "TBDurata";
            this.TBDurata.Size = new System.Drawing.Size(105, 20);
            this.TBDurata.TabIndex = 19;
            // 
            // FormAbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(836, 511);
            this.Controls.Add(this.butonPlati);
            this.Controls.Add(this.TBSituatie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CBRetea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBFactura);
            this.Controls.Add(this.TBNrNou);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBRez);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBDurata);
            this.Name = "FormAbon";
            this.Text = "Alegere Abonament";
            ((System.ComponentModel.ISupportInitialize)(this.TBDurata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBFactura;
        public System.Windows.Forms.TextBox TBNrNou;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.TextBox TBRez;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox CBRetea;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBSituatie;
        private System.Windows.Forms.Button butonPlati;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown TBDurata;
    }
}