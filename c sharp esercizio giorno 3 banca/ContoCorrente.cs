namespace c_sharp_esercizio_giorno_3_banca
{
    internal class ContoCorrente

    {   // proprietà dle conto corrente 
        public string NomeUtente { get; set; }
        public string CognomeUtente { get; set; }
        public string NumerodiConto { get; set; }

        public int Soldidepositati { get; set; }


        //costruttore

        public ContoCorrente(string nomeUtente, string cognomeUtente, string numerodiConto)
        {
            this.NomeUtente = nomeUtente;
            this.CognomeUtente = cognomeUtente;
            this.NumerodiConto = numerodiConto;
            this.Soldidepositati = 0;
        }

        public void DepositaLaGrana(int denaro)
        {
            this.Soldidepositati += denaro;

        }

        public void RitiraLaGrana(int denaro)
        {
            this.Soldidepositati -= denaro;
        }
    }
}
