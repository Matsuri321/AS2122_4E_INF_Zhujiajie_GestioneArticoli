﻿namespace AS2122_4E_INF_Zhujiajie_GestioneArticoli
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAggiungiModifica = new System.Windows.Forms.Button();
            this.cmbUnitadiMisura = new System.Windows.Forms.ComboBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAggiungiModifica);
            this.groupBox1.Controls.Add(this.cmbUnitadiMisura);
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.txtCodice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "dettagli articolo ";
            // 
            // btnAggiungiModifica
            // 
            this.btnAggiungiModifica.Location = new System.Drawing.Point(107, 199);
            this.btnAggiungiModifica.Name = "btnAggiungiModifica";
            this.btnAggiungiModifica.Size = new System.Drawing.Size(167, 31);
            this.btnAggiungiModifica.TabIndex = 8;
            this.btnAggiungiModifica.Text = "Aggiungi/Modifica articolo ";
            this.btnAggiungiModifica.UseVisualStyleBackColor = true;
            this.btnAggiungiModifica.Click += new System.EventHandler(this.btnAggiungiModifica_Click);
            // 
            // cmbUnitadiMisura
            // 
            this.cmbUnitadiMisura.FormattingEnabled = true;
            this.cmbUnitadiMisura.Items.AddRange(new object[] {
            "NR",
            "KG",
            "Q",
            "T"});
            this.cmbUnitadiMisura.Location = new System.Drawing.Point(120, 105);
            this.cmbUnitadiMisura.Name = "cmbUnitadiMisura";
            this.cmbUnitadiMisura.Size = new System.Drawing.Size(194, 23);
            this.cmbUnitadiMisura.TabIndex = 7;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(102, 144);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(212, 23);
            this.txtPrezzo.TabIndex = 6;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(107, 69);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(207, 23);
            this.txtDescrizione.TabIndex = 5;
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(107, 33);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(207, 23);
            this.txtCodice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prezzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unita di misura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrizione ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(450, 23);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(159, 23);
            this.cmbTipo.TabIndex = 1;
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(450, 68);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(227, 274);
            this.lstVisualizza.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(21, 370);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(62, 15);
            this.lblArticoli.TabIndex = 4;
            this.lblArticoli.Text = "Articoli (0)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 412);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "AS2122, 4E, INF, Zhu jia jie, Lab 2.2, 18/05/2022";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAggiungiModifica;
        private ComboBox cmbUnitadiMisura;
        private TextBox txtPrezzo;
        private TextBox txtDescrizione;
        private TextBox txtCodice;
        private ComboBox cmbTipo;
        private ListBox lstVisualizza;
        private Button button1;
        private Label lblArticoli;
    }
}