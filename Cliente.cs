using System;
using System.Data.SqlClient;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public DateTime DataCadastro { get; set; }

    public string AdicionarCliente()
    {
        if (!Email.Contains("@"))
            return "Cliente com e-mail invalido";

        if (CPF.Length != 11)
            return "Cliente com CPF invalido";

        using (var cn = SqlConnection())
        {

        }
    }
}