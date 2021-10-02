using CodeItAirlines.Service.Services;
using NUnit.Framework;

namespace CodeItAirlines.Service.Teste.AutoMapper
{
    public class TripulanteServiceTeste : TesteBase
    {
        [Test]
        public void Eh_Possivel_Obter_Todos()
        {
            var service = new TripulanteService();

            var lista = service.ObterTodos();

            Assert.IsNotNull(lista);
            Assert.IsNotEmpty(lista);
        }
    }
}
