namespace projeto_empresa.Dto
{
    public class AtualizarProdutoDTO
    {
        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public decimal Preco { get; set; }
        public string Descricao { get; set; }

        public int CategoriaId { get; set; }

    }
}
