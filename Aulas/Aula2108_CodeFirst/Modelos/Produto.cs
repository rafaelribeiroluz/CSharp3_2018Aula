namespace Aula2108_CodeFirst.Modelos
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal Imposto { get; set; }

        // Relacionamento Produto <-> Categoria

        //Foreigkey
        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria{ get; set; }

       

    }
}
