using CodeItAirlines.Data.Repositorio;
using NUnit.Framework;
using System.Linq;
using static CodeItAirlines.Domain.Entidades.TripulanteEntidade;

namespace CodeItAirlines.Data.Teste.Repositorio
{
    public class TripulantesRepositorioTeste
    {
        private static int totalPilotosEsperado = 1;
        private static int totalChefesServicoEsperado = 1;
        private static int totalComissariasEsperado = 2;
        private static int totalOficiaisEsperado = 2;
        private static int totalPresidiariosEsperado = 1;
        private static int totalPoliciaisEsperado = 1;

        [Test]
        public void Eh_Possivel_Obter_Todos()
        {
            var service = new TripulantesRepositorio();

            var lista = service.ObterTodos();

            Assert.IsNotNull(lista);
            Assert.IsNotEmpty(lista);
        }

        [Test]
        public void Lista_Passageiros_Esta_Correta()
        {
            var service = new TripulantesRepositorio();

            var lista = service.ObterTodos();

            int totalPilotos = lista.Count(x => x.TipoTripulante == TipoTripulanteEnum.Piloto);
            int totalChefesServico = lista.Count(x => x.TipoTripulante == TipoTripulanteEnum.ChefeServico);
            int totalComissarias = lista.Count(x => x.TipoTripulante == TipoTripulanteEnum.Comissaria);
            int totalOficiais = lista.Count(x => x.TipoTripulante == TipoTripulanteEnum.Oficial);
            int totalPresidiarios = lista.Count(x => x.TipoTripulante == TipoTripulanteEnum.Presidiario);
            int totalPoliciais = lista.Count(x => x.TipoTripulante == TipoTripulanteEnum.Policial);

            Assert.AreEqual(totalPilotos, totalPilotosEsperado);
            Assert.AreEqual(totalChefesServico, totalChefesServicoEsperado);
            Assert.AreEqual(totalComissarias, totalComissariasEsperado);
            Assert.AreEqual(totalOficiais, totalOficiaisEsperado);
            Assert.AreEqual(totalPresidiarios, totalPresidiariosEsperado);
            Assert.AreEqual(totalPoliciais, totalPoliciaisEsperado);
        }
    }
}
