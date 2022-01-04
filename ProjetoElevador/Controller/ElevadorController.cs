using ProjetoElevador.Model;
using System;

namespace ProjetoElevador.Controller
{
    internal class ElevadorController
    {
        // Instância do elevador na controller para poder efetivamente fazer a conexão da view com a models.
        public Elevador elevador = new Elevador();

        // Método inicial, definindo as propriedades do elevador.
        public void Inicializar()
        {
            Try:
            try
            {
                Console.Write("Informe a quantidade de andares: ");
                int andares = int.Parse(Console.ReadLine());
                Console.Write("Informe a capacidade do elevador: ");
                int capacidade = int.Parse(Console.ReadLine());

                elevador.Andares = andares;
                elevador.Capacidade = capacidade;

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.WriteLine("Por favor, insira apenas números inteiros.");
                Console.WriteLine();
                goto Try;
            }
        }

        // Adiciona uma pessoa ao elevador, caso não esteja cheio.
        public void Entrar()
        {
            if (elevador.Pessoas < elevador.Capacidade)
            {
                elevador.Pessoas++;
                MensagemOk("Uma pessoa entrou.");
            }
            else
            {
                MensagemErro("O Elevador está cheio. Entrada recusada.");
            }
        }

        // Remove uma pessoa do elevador, caso não esteja vazio.
        public void Sair()
        {
            if (elevador.Pessoas > 0)
            {
                elevador.Pessoas--;
                MensagemOk("Uma pessoa saiu.");
            }
            else
            {
                MensagemErro("O Elevador está vazio.");
            }
        }

        // Faz o elevador subir um andar, caso não esteja no último.
        public void Subir()
        {
            if (elevador.Andar < elevador.Andares)
            {
                elevador.Andar++;
                MensagemOk("O Elevador subiu um andar.");
            }
            else
            {
                MensagemErro("O Elevador já está no último andar.");
            }
        }

        // Faz o elevador descer um andar, caso não esteja no térreo.
        public void Descer()
        {
            if (elevador.Andar > 0)
            {
                elevador.Andar--;
                MensagemOk("O Elevador desceu um andar.");
            }
            else
            {
                MensagemErro("O Elevador já está no térreo.");
            }
        }

        // Mensagens modificadas, auxiliando a visualização se a opção foi ou não executada corretamente.
        private void MensagemErro(string msg)
        {
            Console.Write("[");
            Console.Write("ERRO", Console.ForegroundColor = ConsoleColor.Red);
            Console.Write("]\t", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine(msg);
        }
        private void MensagemOk(string msg)
        {
            Console.Write("[");
            Console.Write("OK", Console.ForegroundColor = ConsoleColor.Green);
            Console.Write("]\t", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine(msg);
        }

    }
}
