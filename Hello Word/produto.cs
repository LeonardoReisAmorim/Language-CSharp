namespace Hello_Word
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;

        }
        
        public Produto()
        {

        }

        public double valortotalestoque()
        {
            return Preco * Quantidade;
        }

        public int addprodutos(int qt)
        {
            return Quantidade + qt;
        }

        public int removeproduto(int qt)
        {
            return Quantidade - qt;
        }
    }
}