namespace DesignPatterns.AbstractFactory
{
    // Fabrica de fabricas
    public abstract class AutoSocorroFactory
    {
        public abstract Guincho CriarGuincho();

        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}