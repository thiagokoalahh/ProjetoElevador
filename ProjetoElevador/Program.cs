// Autor: Thiago Silva Araújo Santos

using ProjetoElevador.View;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Instânciando a view para iniciar o elevador.
            ElevadorView elevador = new ElevadorView();

            // Método inicial.
            elevador.Menu();

        }
    }
}
