namespace OOP
{
    /// <summary>
    /// Contrato simples
    /// </summary>
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        public void Adicionar()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Mock para fingir que fazer realizar adição dos dados.
    /// </summary>
    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            throw new System.NotImplementedException();
        }
    }

    public class UsoImplementacao
    {
        public void Processo()
        {
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstacao
    {
        private readonly IRepositorio _repositorio;

        public UsoAbstacao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoAbstacao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstacao(new RepositorioFake());
            repoAbs.Processo();
        }
    }
}