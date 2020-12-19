using System;

namespace OOP
{
    #region Caso 1

    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }

        public string Cpf { get; set; }
    }

    public class TestesHerancaComposicao
    {
        public TestesHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "Joao",
                DataNascimento = DateTime.Now,
                Cpf = "01440370185"
            };

            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Joao",
                    DataNascimento = DateTime.Now,
                },
                Cpf = "12346578958"
            };

            var nomeHerance = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }

    #endregion

    #region Caso 2

    // Repositorio Generico
    public interface IRepository<T>
    {
        void Adicionar(T obj);

        void Excluir(T obj);
    }

    // Repositorio Especializado
    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }

    public class Repositorio<T> : IRepository<T>
    {
        public void Adicionar(T obj)
        {

        }

        public void Excluir(T obj)
        {

        }
    }

    // Traz mas acoplamento do que abstração por composição
    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {

    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepository<Pessoa> _reposiorioPessoa;

        public RepositorioComposicaoPessoa(IRepository<Pessoa> repositorioPessoa)
        {
            _reposiorioPessoa = repositorioPessoa;
        }

        public void Adicionar(Pessoa obj)
        {
            _reposiorioPessoa.Adicionar(obj);
        }
    }

    public class TesteHeranceComposicao2
    {
        public TesteHeranceComposicao2()
        {
            var repoH = new RepositorioHerancaPessoa();
            repoH.Adicionar(new Pessoa());
            repoH.Excluir(new Pessoa());

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoC.Adicionar(new Pessoa());
        }
    }

    #endregion
}