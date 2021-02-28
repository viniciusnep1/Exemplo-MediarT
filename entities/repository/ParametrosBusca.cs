namespace financeiro_service.Core.Repository
{
    public class ParametrosBusca
    {
        public int Pagina { get; set; }

        public int TamanhoPagina { get; set; }

        public string Ordem { get; set; }

        public bool Decrescente { get; set; }
    }
}
