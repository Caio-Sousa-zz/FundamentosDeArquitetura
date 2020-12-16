using System;

namespace OOP
{
    /// <summary>
    /// Abastract proibe que alguem instancie Eletrodomestico por conta propria.
    /// Essa classe pode somente ser herdada por ela ser abstract.
    /// </summary>
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;


        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        /// <summary>
        /// Metodo abstrado não é obrigado a implementar o comportamento.
        /// A classe que for implementar ira gerar o comportamento dele.
        /// </summary>
        public abstract void Ligar();


        public abstract void Desligar();
    }

    public abstract class Shape
    {
        public abstract int GetArea();

        public int GetHeight() => 10;
    }

    public class Square : Shape
    {
        public override int GetArea()
        {
            Console.WriteLine($"Altura: {base.GetHeight()}");

            throw new NotImplementedException();
        }
    }
}