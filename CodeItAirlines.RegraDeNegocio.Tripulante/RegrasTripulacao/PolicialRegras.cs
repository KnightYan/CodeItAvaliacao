using System.Collections.Generic;
using CodeItAirlines.Domain.Dtos;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.RegrasTripulacao
{
    public class PolicialRegras : TripulanteRegras
    {
        public PolicialRegras(List<TripulanteDto> listaTripulantes) : base(listaTripulantes) {}

        public override string VerificarRegrasEmbarque()
        {
            return VerificarRegrasBase();
        }

        public override bool PodeDirigir()
        {
            return true;
        }
    }
}
