    using GestioneArticoli.Library;
    namespace AS2122_4E_INF_Zhujiajie_GestioneArticoli
    {
    public partial class frmMain : Form
    {
        Dictionary<string, Articolo> articoli = new Dictionary<string, Articolo>();
        public frmMain()
        {
            InitializeComponent();
        }



        private void btnAggiungiModifica_Click(object sender, EventArgs e)
        {
            var a = new Articolo(txtCodice.Text, txtDescrizione.Text, cmbUnitadiMisura.Text, Convert.ToDouble(txtPrezzo.Text));
            if (articoli.ContainsKey(a.Codice))
            {
                articoli[a.Codice] = a;
            }
            else
            {
                articoli.Add(a.Codice, a);
            }
              
            lblArticoli.Text = $"Articoli({articoli.Count})";
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            lstVisualizza.Items.Clear();
            switch (cmbTipo.Text)
            {
                case "Visualizza articoli":
                    foreach (KeyValuePair<string, Articolo> art in articoli)
                    {
                        lstVisualizza.Items.Add(art.Value.Visualizzazione());
                    }
                    break;
             
            }
        }

        











        private void label2_Click(object sender, EventArgs e)
        {

        }

        

      
    }
}