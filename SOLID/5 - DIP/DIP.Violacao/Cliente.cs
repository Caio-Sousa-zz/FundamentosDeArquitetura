using System;

namespace SOLID.DIP.Violacao
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