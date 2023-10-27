namespace MinimalApi
{
    public class Cliente
    {
        public Endereco Endereco { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }

    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }
    }

    public class ItemServico
    {
        public int zzRowUi { get; set; }
        public string Descricao { get; set; }
        public string ValorUnitario { get; set; }
        public string Quantidade { get; set; }
        public string Subtotal { get; set; }
    }

    public class TecnicoResponsavel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }

    public class Pagamento
    {
        public string FormaDePagamento { get; set; }
        public string ValorTotalPago { get; set; }
        public DateTime DataPagamento { get; set; }
    }

    public class OrdemServico
    {
        public Cliente Cliente { get; set; }
        public List<ItemServico> ItensServico { get; set; }
        public TecnicoResponsavel TecnicoResponsavel { get; set; }
        public Pagamento Pagamento { get; set; }
        public string Codigo { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal TotalServico { get; set; }
        public DateTime DataConclusao { get; set; }
        public string Status { get; set; }
        public string InfIni { get; set; }
        
    }


}