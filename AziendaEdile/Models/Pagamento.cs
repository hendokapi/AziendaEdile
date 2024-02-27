namespace AziendaEdile.Models
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }
        public string Periodo { get; set; }
        public string Type { get; set; }
        public int Ammontare { get; set; }
        public int DipendenteId { get; set; }
    }
}
