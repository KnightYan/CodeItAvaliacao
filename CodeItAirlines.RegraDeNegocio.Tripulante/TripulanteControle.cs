using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Interfaces.RegraDeNegocio.Tripulante;
using CodeItAirlines.Service.Services;
using System.Collections.Generic;

namespace CodeItAirlines.RegraDeNegocio.Tripulante
{
    public class TripulanteControle : ITripulanteControle
    {
        public List<TripulanteDto> ObterListaTripulantes()
        {
            var tripulanteService = new TripulanteService();
            return tripulanteService.ObterTodos();
        }
    }
}
