using System;

namespace OOP
{
    /// <summary>
    /// Funcionario herda pessoa
    /// Todo funcionario é uma pessoa
    /// </summary>
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }

        public string Registro { get; set; }


        public void MostraValores()
        {
            Console.WriteLine($"Admissão: {DataAdmissao.Date}");

            Console.WriteLine($"Registro: {Registro}");

            Console.WriteLine($"Nome: {base.Nome}");

            Console.WriteLine($"Nome: {base.DataNascimento}");
        }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Caio Sousa",
                DataNascimento = Convert.ToDateTime("1991/03/02"),
                DataAdmissao = DateTime.Now,
                Registro = "014406701"
            };

            // Herda funções da classe derivada
            funcionario.CalcularIdade();
        }
    }
}