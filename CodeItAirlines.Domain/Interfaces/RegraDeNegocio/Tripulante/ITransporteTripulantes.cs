using CodeItAirlines.Domain.Dtos;
using System.Collections.Generic;
using static CodeItAirlines.Domain.Entidades.TripulanteEntidade;

namespace CodeItAirlines.Domain.Interfaces.RegraDeNegocio.Tripulante
{
    public interface ITransporteTripulantes
    {
        string EmbarcarTripulante(TripulanteDto tripulante);

        string EmbarcarDoisTripulante(TripulanteDto tripulante1, TripulanteDto tripulante2);

        List<TripulanteDto> DesembargarTripulantes();

        List<TripulanteDto> ObterTripulantesPorTipos(List<TipoTripulanteEnum> tipoTripulante, string ocorrencia);

        List<TripulanteDto> ObterCopiaListaPassageiros();
    }
}
