namespace OOP.Class_x_Objects
{
    /// <summary>
    /// Função de mapear um objeto do mundo real/pessoa/processo.
    /// </summary>
    public class House
    {
        public int Portas { get; set; }

        public int Valor { get; set; }

        public int Vagas { get; set; }

        public int MetrosQuadrados { get; set; }
    }

    public class Object
    {
        public Object()
        {
            // Definição de objeto.
            // Aloca um instancia de uma classe representado por um objeto.
            var house = new House()
            {
                Portas = 2,
                Vagas = 100,
                MetrosQuadrados = 50,
                Valor = 15000
            };
        }
    }
}