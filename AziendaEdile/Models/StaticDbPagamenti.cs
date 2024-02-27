namespace AziendaEdile.Models
{
    public static class StaticDbPagamenti
    {
        private static int _maxId = 3;
        private static List<Pagamento> _pagamenti = [
            new Pagamento() {PagamentoId = 1, Periodo = "Gennaio", Type = "Stipendio", Ammontare = 1200, DipendenteId = 1},
            new Pagamento() {PagamentoId = 2, Periodo = "Gennaio", Type = "Stipendio", Ammontare = 1500, DipendenteId = 1},
            new Pagamento() {PagamentoId = 3, Periodo = "Febbraio", Type = "Altro", Ammontare = 1800, DipendenteId = 3},
        ];

        public static List<Pagamento> GetAll()
        {
            return _pagamenti;
        }

        public static Pagamento? GetById(int? id)
        {
            if (id is null) return null;

            foreach (var pagamento in _pagamenti)
            {
                if (pagamento.PagamentoId == id) return pagamento;
            }

            return null;
        }

        public static Pagamento Add(Pagamento pagamento)
        {
            _maxId++;
            pagamento.PagamentoId = _maxId;
            _pagamenti.Add(pagamento);
            return pagamento;
        }
    }
}
