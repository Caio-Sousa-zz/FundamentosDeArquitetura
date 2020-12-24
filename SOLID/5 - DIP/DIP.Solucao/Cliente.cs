using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.Solucao
{
    public class Cliente
    {
        public int Id { get; set; }

        public int Nome { get; set; }

        public Email Email { get; set; }

        public CPF Cpf { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
