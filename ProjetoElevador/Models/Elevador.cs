namespace ProjetoElevador.Model
{
    // Classe Elevador, guardando o status do elevador.
    internal class Elevador
    {
        /* Andares guarda a quantidade de andares que o prédio possui;
         * Andar guarda o andar em que o elevador se encontra;
         * Capacidade indica a quantidade de pessoas que o elevador suporta;
         * Pessoas indica quantas pessoas estão no elevador no momento.
         */

        public int Andares { get; set; }
        public int Andar { get; set; }
        public int Capacidade { get; set; }
        public int Pessoas { get; set; }

    }
}
