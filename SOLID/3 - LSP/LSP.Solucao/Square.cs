using System;

namespace SOLID.LSP.Solucao
{
    public class Square : Quadilateral
    {
        public Square(int altura, int largura): base(altura, largura)
        {
            if (largura != altura)
                throw new ArgumentException("Os dois lados do quadrados precisam ser iguais");
        }
    }
}