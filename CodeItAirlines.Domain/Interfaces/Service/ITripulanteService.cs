using CodeItAirlines.Domain.Dtos;
using System.Collections.Generic;

namespace CodeItAirlines.Domain.Interfaces.Service
{
    public interface ITripulanteService
    {
        List<TripulanteDto> ObterTodos();
    }
}
