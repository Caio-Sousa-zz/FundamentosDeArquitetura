using System;

namespace DesignPatterns.AbstractFactory
{
    // Client Class
    public class AutoSocorroClient
    {
        private readonly Veiculo _veiculo;
        private readonly Guincho _guincho;

        public AutoSocorroClient(AutoSocorroFactory factory, Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Modelo, veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        public void RealizarAtendimento()
        {
            _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorroClient CriarAutoSocorro(Veiculo veiculo)
        {
            switch (veiculo.Porte)
            {
                case Porte.Pequeno:
                    return new AutoSocorroClient(new SocorroVeiculoPequenoFactory(), veiculo);
                case Porte.Medio:
                    return new AutoSocorroClient(new SocorroVeiculoMedioFactory(), veiculo);
                case Porte.Grande:
                    return new AutoSocorroClient(new SocorroVeiculoGrandeFactory(), veiculo);
                default:
                    throw new ApplicationException("Não foi possível identificar o veículo");
            }
        }
    }
}