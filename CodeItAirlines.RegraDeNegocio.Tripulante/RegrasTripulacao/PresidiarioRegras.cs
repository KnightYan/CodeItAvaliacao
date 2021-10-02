using System.Collections.Generic;
using CodeItAirlines.Domain.Dtos;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.RegrasTripulacao
{
    public class PresidiarioRegras : TripulanteRegras
    {
        public PresidiarioRegras(List<TripulanteDto> listaTripulantes) : base(listaTripulantes) {}

        public override string VerificarRegrasEmbarque()
        {
            return VerificarRegrasBase();
        }

        public override bool PodeDirigir()
        {
            return false;
        }
    }
}
