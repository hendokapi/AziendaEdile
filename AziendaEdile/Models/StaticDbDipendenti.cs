namespace AziendaEdile.Models
{
    public static class StaticDbDipendenti
    {
        private static int _maxId = 3;
        private static List<Dipendente> _dipendenti = [
            new Dipendente() {DipendenteId = 1, Nome = "Pinco", Cognome = "Pallino", Indirizzo = "Via Corso", CodiceFiscale = "ASDFASDFQWERQWER", Coniugato = true, NumFigli = 3, Mansione = "Developer"},
            new Dipendente() {DipendenteId = 2, Nome = "Mario", Cognome = "Rossi", Indirizzo = "Via della Repubblica", CodiceFiscale = "ASDFQWERZXCVUIOP", Coniugato = true, NumFigli = 1, Mansione = "Manager"},
            new Dipendente() {DipendenteId = 3, Nome = "Pinco", Cognome = "Pallino", Indirizzo = "Via Corso", CodiceFiscale = "ZXCVASDFFGHEWRTG", Coniugato = false, NumFigli = 0, Mansione = "Pansatore"},
        ];

        public static List<Dipendente> GetAll()
        {
            return _dipendenti;
        }

        public static Dipendente? GetById(int? id)
        {
            if (id is null) return null;

            foreach (var dipendente in _dipendenti)
            {
                if (dipendente.DipendenteId == id) return dipendente;
            }

            return null;
        }

        public static Dipendente Add(Dipendente dipendente)
        {
            _maxId++;
            dipendente.DipendenteId = _maxId;
            _dipendenti.Add(dipendente);
            return dipendente;
        }
    }
}
