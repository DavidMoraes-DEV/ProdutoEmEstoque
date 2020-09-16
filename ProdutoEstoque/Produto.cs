using System.Globalization;

namespace ProdutoEstoque
{
    class Produto
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double Preco;
        public int Qtd;

        public double ValorTotalEmEstoque()
        {
            return Qtd * Preco;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Qtd += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Qtd -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CI)
                + ", "
                + Qtd
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CI);
        }

        



    }
}
