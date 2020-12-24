using System;

namespace SOLID.ISP.Violacao
{
    class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            throw new NotImplementedException("metodo não serve para nada.");
        }

        public void SalvarBanco()
        {
           //salva
        }

        public void ValidarDados()
        {
          //valida
        }
    }
}