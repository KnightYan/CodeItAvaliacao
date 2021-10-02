using CodeItAirlines.Domain.Dtos;
using System.Collections.Generic;

namespace CodeItAirlines.Domain.Interfaces.RegraDeNegocio.Tripulante
{
    public interface ITripulanteControle
    {
        List<TripulanteDto> ObterListaTripulantes();
    }
}
