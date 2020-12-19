using System;

namespace OOP
{
    /// <summary>
    /// Polimosrfismo - uma classe pode assumir diversos comportamnetos
    /// </summary>
    public class Cafeteria : Eletrodomestico
    {
        /// <summary>
        /// Pega nome e voltagem e passa para a classe base.
        /// </summary>
        public Cafeteria(string nome, int voltagem) : base(nome, voltagem)
        {


        }

        /// <summary>
        /// Base passa as informações para a classe base.
        /// </summary>
        public Cafeteria() : base("Padrao", 2020)
        {


        }

        public void PrepararCafe()
        {
            AquecerAGua();
            MoerGraos();
            // ETC
        }

        /// <summary>
        /// Ovveride estou sobreescrevendo o comportamento de uma classe base.
        /// </summary>
        public override void Desligar()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            throw new NotImplementedException();
        }

        public override void Testar()
        {

        }

        private static void AquecerAGua() { }

        private static void MoerGraos() { }

    }
}