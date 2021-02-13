using System;
using System.Collections.Generic;

namespace trabalho1
{
    class Program
    {
        public static Dictionary<string, Fabrica> fabricas = new Dictionary<string, Fabrica>();

        static void Main(string[] args)
        {
            var opcao = 0;

            while(opcao != 3)
            {
                Console.WriteLine("Fabrica de Fabricas!");
                Console.WriteLine("1. Criar Fabrica");
                Console.WriteLine("2. Usar Fabrica");
                Console.WriteLine("3. Sair");
                Console.WriteLine("Escolha a opção: ");
                var opcaoLida = Console.ReadLine();
                Console.WriteLine("Opção escolhida: " + opcaoLida);

                opcao = Convert.ToInt32(opcaoLida);
                string tipoFabrica;
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Escolha o tipo de Fabrica a ser criada: ");
                        Console.WriteLine("1. Fabrica de Sapatos");
                        Console.WriteLine("2. Fabrica de Eletrodomesticos");
                        tipoFabrica = Console.ReadLine();
                        Console.WriteLine("Digite um numero para identificar a sua Fabrica:");
                        var identificador = Console.ReadLine();
                        Console.WriteLine("Digite um Nome para a sua Fabrica:");
                        var nome = Console.ReadLine();
                        /*
                        Adicionar a leitura dos insumos e dos produtos
                        */
                        fabricas.Add(identificador, new Fabrica(identificador, nome));

                        break;
                    case 2:
                        Console.WriteLine("Digite o identificador da fabrica a ser usada: ");
                        foreach(var f in fabricas)
                        {
                            Console.WriteLine(f.Value.MostrarIDeNome());
                        }
                        var idFabrica = Console.ReadLine();
                        var fabrica = fabricas[idFabrica];
                        Console.WriteLine(fabrica.Usar());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
