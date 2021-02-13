namespace trabalho1
{
    public class Fabrica
    {
        public string Identificador;
        public string Nome;
        //public Fabrica CriarFabrica(insumo, produto);
        // Mostrar identificador e nome
        // Usar Fabrica
        public Fabrica(string identificador, string nome)
        {
            Identificador = identificador;
            Nome = nome;
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