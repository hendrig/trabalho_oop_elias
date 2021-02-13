namespace trabalho1
{
    public class Fabrica
    {
        public string Identificador;
        public string Nome;
        public IInsumos Insumo;
        public IProdutos Produto;
        //public Fabrica CriarFabrica(insumo, produto);
        // Mostrar identificador e nome
        // Usar Fabrica
        public Fabrica(string identificador, string nome, IProdutos produto, IInsumos insumo)
        {
            Identificador = identificador;
            Nome = nome;
            Produto = produto;
            Insumo = insumo;
        }

        public string MostrarIDeNome()
        {
            return Identificador + ". " + Nome;
        }

        public string Usar()
        {
            return "Usando a fabrica " + Nome;
        }
    }
}