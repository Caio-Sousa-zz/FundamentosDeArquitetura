using System;

namespace SOLID.LSP.Solucao
{
    public class Rectangle : Quadilateral
    {
        public Rectangle(int altura, int largura): base(altura, largura)
        {
            if (largura == altura)
                throw new ArgumentException("Os dois lados do quadrados precisam ser diferentes");
        }
    }
}