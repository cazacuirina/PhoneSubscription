
namespace PAW_PROIECT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButonClient = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abonamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creareAbonamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.migrareCartelaAbonamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portareDinAltaReteaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareSituatiePlatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oferteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonamenteDisponibileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraOptiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBFisier = new System.Windows.Forms.TextBox();
            this.butonInchide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.TV = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog3 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1177, 218);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nume";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "CNP";
            this.columnHeader7.Width = 131;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Data_nasterii";
            this.columnHeader8.Width = 178;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nr_Telefon";
            this.columnHeader9.Width = 135;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Email";
            this.columnHeader10.Width = 155;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Abonament/Cartela";
            this.columnHeader11.Width = 133;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Retea";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Are Abonament la Telekom?";
            this.columnHeader2.Width = 162;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeClientToolStripMenuItem,
            this.editeazaClientToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 52);
            // 
            // stergeClientToolStripMenuItem
            // 
            this.stergeClientToolStripMenuItem.Name = "stergeClientToolStripMenuItem";
            this.stergeClientToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.stergeClientToolStripMenuItem.Text = "Sterge Client";
            this.stergeClientToolStripMenuItem.Click += new System.EventHandler(this.stergeClientToolStripMenuItem_Click);
            // 
            // editeazaClientToolStripMenuItem
            // 
            this.editeazaClientToolStripMenuItem.Name = "editeazaClientToolStripMenuItem";
            this.editeazaClientToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.editeazaClientToolStripMenuItem.Text = "Editeaza Client";
            this.editeazaClientToolStripMenuItem.Click += new System.EventHandler(this.editeazaClientToolStripMenuItem_Click);
            // 
            // ButonClient
            // 
            this.ButonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButonClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButonClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonClient.Location = new System.Drawing.Point(139, 322);
            this.ButonClient.Name = "ButonClient";
            this.ButonClient.Size = new System.Drawing.Size(135, 56);
            this.ButonClient.TabIndex = 1;
            this.ButonClient.Text = "Adauga Client";
            this.ButonClient.UseVisualStyleBackColor = false;
            this.ButonClient.Click += new System.EventHandler(this.ButonClient_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonamenteToolStripMenuItem,
            this.oferteToolStripMenuItem,
            this.fisiereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1243, 27);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abonamenteToolStripMenuItem
            // 
            this.abonamenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creareAbonamentToolStripMenuItem,
            this.migrareCartelaAbonamentToolStripMenuItem,
            this.portareDinAltaReteaToolStripMenuItem,
            this.vizualizareSituatiePlatiToolStripMenuItem});
            this.abonamenteToolStripMenuItem.Name = "abonamenteToolStripMenuItem";
            this.abonamenteToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.abonamenteToolStripMenuItem.Text = " Configurare Abonamente";
            // 
            // creareAbonamentToolStripMenuItem
            // 
            this.creareAbonamentToolStripMenuItem.Name = "creareAbonamentToolStripMenuItem";
            this.creareAbonamentToolStripMenuItem.Size = new System.Drawing.Size(270, 24);
            this.creareAbonamentToolStripMenuItem.Text = "Creare Abonament Numar Nou";
            this.creareAbonamentToolStripMenuItem.Click += new System.EventHandler(this.creareAbonamentToolStripMenuItem_Click);
            // 
            // migrareCartelaAbonamentToolStripMenuItem
            // 
            this.migrareCartelaAbonamentToolStripMenuItem.Name = "migrareCartelaAbonamentToolStripMenuItem";
            this.migrareCartelaAbonamentToolStripMenuItem.Size = new System.Drawing.Size(270, 24);
            this.migrareCartelaAbonamentToolStripMenuItem.Text = "Migrare cartela -> abonament";
            this.migrareCartelaAbonamentToolStripMenuItem.Click += new System.EventHandler(this.migrareCartelaAbonamentToolStripMenuItem_Click);
            // 
            // portareDinAltaReteaToolStripMenuItem
            // 
            this.portareDinAltaReteaToolStripMenuItem.Name = "portareDinAltaReteaToolStripMenuItem";
            this.portareDinAltaReteaToolStripMenuItem.Size = new System.Drawing.Size(270, 24);
            this.portareDinAltaReteaToolStripMenuItem.Text = "Portare din alta retea";
            this.portareDinAltaReteaToolStripMenuItem.Click += new System.EventHandler(this.portareDinAltaReteaToolStripMenuItem_Click);
            // 
            // vizualizareSituatiePlatiToolStripMenuItem
            // 
            this.vizualizareSituatiePlatiToolStripMenuItem.Name = "vizualizareSituatiePlatiToolStripMenuItem";
            this.vizualizareSituatiePlatiToolStripMenuItem.Size = new System.Drawing.Size(270, 24);
            this.vizualizareSituatiePlatiToolStripMenuItem.Text = "Vizualizare situatie plati";
            this.vizualizareSituatiePlatiToolStripMenuItem.Click += new System.EventHandler(this.vizualizareSituatiePlatiToolStripMenuItem_Click);
            // 
            // oferteToolStripMenuItem
            // 
            this.oferteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonamenteDisponibileToolStripMenuItem,
            this.extraOptiuniToolStripMenuItem});
            this.oferteToolStripMenuItem.Name = "oferteToolStripMenuItem";
            this.oferteToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.oferteToolStripMenuItem.Text = "Oferte - PDF";
            // 
            // abonamenteDisponibileToolStripMenuItem
            // 
            this.abonamenteDisponibileToolStripMenuItem.Name = "abonamenteDisponibileToolStripMenuItem";
            this.abonamenteDisponibileToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.abonamenteDisponibileToolStripMenuItem.Text = "Abonamente disponibile";
            this.abonamenteDisponibileToolStripMenuItem.Click += new System.EventHandler(this.abonamenteDisponibileToolStripMenuItem_Click);
            // 
            // extraOptiuniToolStripMenuItem
            // 
            this.extraOptiuniToolStripMenuItem.Name = "extraOptiuniToolStripMenuItem";
            this.extraOptiuniToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.extraOptiuniToolStripMenuItem.Text = "Extra Optiuni";
            this.extraOptiuniToolStripMenuItem.Click += new System.EventHandler(this.extraOptiuniToolStripMenuItem_Click);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binareToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(155, 23);
            this.fisiereToolStripMenuItem.Text = "Evidenta Plati - Fisiere";
            // 
            // binareToolStripMenuItem
            // 
            this.binareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.deschidereToolStripMenuItem});
            this.binareToolStripMenuItem.Name = "binareToolStripMenuItem";
            this.binareToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.binareToolStripMenuItem.Text = "Binare";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click_1);
            // 
            // deschidereToolStripMenuItem
            // 
            this.deschidereToolStripMenuItem.Name = "deschidereToolStripMenuItem";
            this.deschidereToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.deschidereToolStripMenuItem.Text = "Deschidere";
            this.deschidereToolStripMenuItem.Click += new System.EventHandler(this.deschidereToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem1,
            this.deschidereToolStripMenuItem1});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // salvareToolStripMenuItem1
            // 
            this.salvareToolStripMenuItem1.Name = "salvareToolStripMenuItem1";
            this.salvareToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.salvareToolStripMenuItem1.Text = "Salvare";
            this.salvareToolStripMenuItem1.Click += new System.EventHandler(this.salvareToolStripMenuItem1_Click);
            // 
            // deschidereToolStripMenuItem1
            // 
            this.deschidereToolStripMenuItem1.Name = "deschidereToolStripMenuItem1";
            this.deschidereToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.deschidereToolStripMenuItem1.Text = "Deschidere";
            this.deschidereToolStripMenuItem1.Click += new System.EventHandler(this.deschidereToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(917, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "VIZUALIZARE GRAFICE";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepPink;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1049, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pie Chart Client";
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.label2_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.label2_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumOrchid;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1049, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bar Chart Plati ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TBFisier
            // 
            this.TBFisier.BackColor = System.Drawing.Color.White;
            this.TBFisier.Location = new System.Drawing.Point(25, 264);
            this.TBFisier.Multiline = true;
            this.TBFisier.Name = "TBFisier";
            this.TBFisier.Size = new System.Drawing.Size(463, 294);
            this.TBFisier.TabIndex = 11;
            // 
            // butonInchide
            // 
            this.butonInchide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butonInchide.Location = new System.Drawing.Point(906, 485);
            this.butonInchide.Name = "butonInchide";
            this.butonInchide.Size = new System.Drawing.Size(99, 50);
            this.butonInchide.TabIndex = 12;
            this.butonInchide.Text = "Inchide Lista Contractelor!";
            this.butonInchide.UseVisualStyleBackColor = false;
            this.butonInchide.Click += new System.EventHandler(this.butonInchide_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(919, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Click pe Label ->";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(919, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Drag and Drop Client ->";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 196);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // TV
            // 
            this.TV.Location = new System.Drawing.Point(494, 264);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(395, 294);
            this.TV.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Fuchsia;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Apasa pe imagine!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1045, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 55);
            this.button1.TabIndex = 19;
            this.button1.Text = "Reziliere contract";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog3
            // 
            this.printPreviewDialog3.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog3.Document = this.printDocument3;
            this.printPreviewDialog3.Enabled = true;
            this.printPreviewDialog3.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog3.Icon")));
            this.printPreviewDialog3.Name = "printPreviewDialog3";
            this.printPreviewDialog3.Visible = false;
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.HotPink;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(139, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 59);
            this.button2.TabIndex = 20;
            this.button2.Text = "Vizualizeaza PDF Clienti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(987, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Back To Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Fuchsia;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(139, 480);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 78);
            this.button4.TabIndex = 23;
            this.button4.Text = "Vizualizeaza Datele Centralizate";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1243, 570);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butonInchide);
            this.Controls.Add(this.TBFisier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButonClient);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FORMULAR PRINCIPAL";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button ButonClient;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abonamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creareAbonamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem migrareCartelaAbonamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portareDinAltaReteaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareSituatiePlatiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.TextBox TBFisier;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deschidereToolStripMenuItem1;
        private System.Windows.Forms.Button butonInchide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem oferteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonamenteDisponibileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraOptiuniToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TreeView TV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaClientToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog3;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

