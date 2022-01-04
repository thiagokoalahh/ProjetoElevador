using ProjetoElevador.Controller;
using System;

namespace ProjetoElevador.View
{
    internal class ElevadorView
    {
        // Instância do controller
        ElevadorController elevadorController = new ElevadorController();

        // Menu em que o elevador será executado
        public void Menu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            // Chamada do método inicial, definindo o elevador
            elevadorController.Inicializar();
            bool continuar = true;
            Console.Clear();

            // Loop para uso contínuo do programa
            while (continuar)
            {
                // Status atualizado do elevador
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSTATUS ATUALIZADO ELEVADOR");
                Console.Write($"Capacidade: {elevadorController.elevador.Capacidade}");
                Console.Write($"\tAndares: {elevadorController.elevador.Andares}");
                Console.Write($"\n\nAndar atual: {elevadorController.elevador.Andar}");
                Console.Write($"\tPessoas no elevador: {elevadorController.elevador.Pessoas}");
                Console.ForegroundColor = ConsoleColor.White;

                // Menu de opções
                Console.WriteLine("\n\n------MENU ELEVADOR------");
                Console.WriteLine("1 - Entrar");
                Console.WriteLine("2 - Sair");
                Console.WriteLine("3 - Subir");
                Console.WriteLine("4 - Descer");
                Console.WriteLine("5 - Encerrar Elevador");

                Console.Write("\nOpção: ");
                string escolha = Console.ReadLine();

                Console.Clear();

                // Leitura da opção escolhida pelo usuário
                switch (escolha)
                {
                    case "1":
                        elevadorController.Entrar();
                        break;
                    case "2":
                        elevadorController.Sair();
                        break;
                    case "3":
                        elevadorController.Subir();
                        break;
                    case "4":
                        elevadorController.Descer();
                        break;
                    case "5":
                        Console.WriteLine("Elevador encerrado.");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
