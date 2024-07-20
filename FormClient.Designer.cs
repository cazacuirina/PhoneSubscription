
namespace PAW_PROIECT
{
    partial class FormClient
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
            this.components = new System.ComponentModel.Container();
            this.LabelNume = new System.Windows.Forms.Label();
            this.LabelCNP = new System.Windows.Forms.Label();
            this.LabelDataN = new System.Windows.Forms.Label();
            this.LabelTelef = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TBNume = new System.Windows.Forms.TextBox();
            this.TBCNP = new System.Windows.Forms.TextBox();
            this.TBTelef = new System.Windows.Forms.TextBox();
            this.TBMail = new System.Windows.Forms.TextBox();
            this.buton1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBAbon = new System.Windows.Forms.ComboBox();
            this.CBRet = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNume
            // 
            this.LabelNume.AutoSize = true;
            this.LabelNume.BackColor = System.Drawing.Color.Violet;
            this.LabelNume.Location = new System.Drawing.Point(40, 56);
            this.LabelNume.Name = "LabelNume";
            this.LabelNume.Size = new System.Drawing.Size(35, 13);
            this.LabelNume.TabIndex = 0;
            this.LabelNume.Text = "Nume";
            // 
            // LabelCNP
            // 
            this.LabelCNP.AutoSize = true;
            this.LabelCNP.BackColor = System.Drawing.Color.Violet;
            this.LabelCNP.Location = new System.Drawing.Point(40, 110);
            this.LabelCNP.Name = "LabelCNP";
            this.LabelCNP.Size = new System.Drawing.Size(29, 13);
            this.LabelCNP.TabIndex = 1;
            this.LabelCNP.Text = "CNP";
            // 
            // LabelDataN
            // 
            this.LabelDataN.AutoSize = true;
            this.LabelDataN.BackColor = System.Drawing.Color.Violet;
            this.LabelDataN.Location = new System.Drawing.Point(40, 165);
            this.LabelDataN.Name = "LabelDataN";
            this.LabelDataN.Size = new System.Drawing.Size(73, 13);
            this.LabelDataN.TabIndex = 2;
            this.LabelDataN.Text = "Data_Nastere";
            // 
            // LabelTelef
            // 
            this.LabelTelef.AutoSize = true;
            this.LabelTelef.BackColor = System.Drawing.Color.Violet;
            this.LabelTelef.Location = new System.Drawing.Point(40, 226);
            this.LabelTelef.Name = "LabelTelef";
            this.LabelTelef.Size = new System.Drawing.Size(60, 13);
            this.LabelTelef.TabIndex = 3;
            this.LabelTelef.Text = "Nr_Telefon";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.Violet;
            this.LabelEmail.Location = new System.Drawing.Point(40, 280);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(32, 13);
            this.LabelEmail.TabIndex = 4;
            this.LabelEmail.Text = "Email";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // TBNume
            // 
            this.TBNume.Location = new System.Drawing.Point(140, 49);
            this.TBNume.Name = "TBNume";
            this.TBNume.Size = new System.Drawing.Size(200, 20);
            this.TBNume.TabIndex = 6;
            this.TBNume.Validating += new System.ComponentModel.CancelEventHandler(this.TBNume_Validating);
            // 
            // TBCNP
            // 
            this.TBCNP.Location = new System.Drawing.Point(140, 103);
            this.TBCNP.Name = "TBCNP";
            this.TBCNP.Size = new System.Drawing.Size(200, 20);
            this.TBCNP.TabIndex = 7;
            this.TBCNP.Validating += new System.ComponentModel.CancelEventHandler(this.TBCNP_Validating);
            // 
            // TBTelef
            // 
            this.TBTelef.Location = new System.Drawing.Point(140, 226);
            this.TBTelef.Name = "TBTelef";
            this.TBTelef.Size = new System.Drawing.Size(200, 20);
            this.TBTelef.TabIndex = 8;
            this.TBTelef.Validating += new System.ComponentModel.CancelEventHandler(this.TBTelef_Validating);
            // 
            // TBMail
            // 
            this.TBMail.Location = new System.Drawing.Point(140, 273);
            this.TBMail.Name = "TBMail";
            this.TBMail.Size = new System.Drawing.Size(200, 20);
            this.TBMail.TabIndex = 9;
            this.TBMail.Validating += new System.ComponentModel.CancelEventHandler(this.TBMail_Validating);
            // 
            // buton1
            // 
            this.buton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buton1.Location = new System.Drawing.Point(172, 411);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(116, 39);
            this.buton1.TabIndex = 10;
            this.buton1.Text = "button1";
            this.buton1.UseVisualStyleBackColor = false;
            this.buton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(40, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reteaua de telefonie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(40, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Abonament sau cartela?";
            // 
            // CBAbon
            // 
            this.CBAbon.FormattingEnabled = true;
            this.CBAbon.Items.AddRange(new object[] {
            "Abonament",
            "Cartela"});
            this.CBAbon.Location = new System.Drawing.Point(172, 324);
            this.CBAbon.Name = "CBAbon";
            this.CBAbon.Size = new System.Drawing.Size(168, 21);
            this.CBAbon.TabIndex = 13;
            // 
            // CBRet
            // 
            this.CBRet.FormattingEnabled = true;
            this.CBRet.Items.AddRange(new object[] {
            "Telekom",
            "Vodafone",
            "Digi",
            "Orange"});
            this.CBRet.Location = new System.Drawing.Point(172, 362);
            this.CBRet.Name = "CBRet";
            this.CBRet.Size = new System.Drawing.Size(168, 21);
            this.CBRet.TabIndex = 14;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(485, 471);
            this.Controls.Add(this.CBRet);
            this.Controls.Add(this.CBAbon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buton1);
            this.Controls.Add(this.TBMail);
            this.Controls.Add(this.TBTelef);
            this.Controls.Add(this.TBCNP);
            this.Controls.Add(this.TBNume);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelTelef);
            this.Controls.Add(this.LabelDataN);
            this.Controls.Add(this.LabelCNP);
            this.Controls.Add(this.LabelNume);
            this.Name = "FormClient";
            this.Text = "FORMULAR CLIENT";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNume;
        private System.Windows.Forms.Label LabelCNP;
        private System.Windows.Forms.Label LabelDataN;
        private System.Windows.Forms.Label LabelTelef;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TBTelef;
        public System.Windows.Forms.TextBox TBNume;
        public System.Windows.Forms.TextBox TBCNP;
        public System.Windows.Forms.TextBox TBMail;
        public System.Windows.Forms.ComboBox CBRet;
        public System.Windows.Forms.ComboBox CBAbon;
    }
}