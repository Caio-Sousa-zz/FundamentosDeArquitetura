namespace SOLID.LSP.Solucao
{
    public abstract class Quadilateral
    {
        public Quadilateral(int width, int height)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; set; }

        public  int Width { get; set; }

        public double Area { get { return Height * Width; } }
    }
}