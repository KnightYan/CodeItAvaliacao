using NUnit.Framework;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.Teste
{
    public class TripulanteControleTeste
    {
        [Test]
        public void Eh_Possivel_Obter_Lista_Tripulantes()
        {
            var service = new TripulanteControle();

            var lista = service.ObterListaTripulantes();

            Assert.IsNotNull(lista);
            Assert.IsNotEmpty(lista);
        }
    }
}
