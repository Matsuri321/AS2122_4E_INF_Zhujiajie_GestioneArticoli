namespace GestioneArticoli.Library
{
    public class Articolo
    {
        string codice;
        string descrizione;
        string unitaDiMisura;
        double prezzo;

        public string Codice { get { return codice; } }
        public string UnitaDiMisura { get { return unitaDiMisura; } }
        public string Descrizione { get { return descrizione; } }
       
        public double Prezzo { get { return prezzo; } }

        public Articolo(string codice, string descrizione, string unitaDiMisura, double prezzo)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitaDiMisura = unitaDiMisura;
            this.prezzo = prezzo;
        }
    }
}