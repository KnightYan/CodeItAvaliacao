using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Entidades;
using NUnit.Framework;
using System;

namespace CodeItAirlines.Service.Teste
{
    public class TripulanteMapper : TesteBase
    {
        [Test]
        public void Eh_Possivel_mapear_de_entidade_para_dto()
        {
            var entidade = new TripulanteEntidade
            {
                Id = Guid.NewGuid(),
                Nome = Faker.Name.FullName(),
                TipoTripulante = TripulanteEntidade.TipoTripulanteEnum.Piloto
            };

            var dto = _mapper.Map<TripulanteDto>(entidade);
            Assert.AreEqual(dto.Id, entidade.Id);
        }
    }
}