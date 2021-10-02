using System.Collections.Generic;
using System.Linq;
using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Entidades;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.RegrasTripulacao
{
    public class PilotoRegras : TripulanteRegras
    {
        private static string ocorrenciaPilotoComComissarias = "É política da empresa que o piloto pode ficar sozinho com as comissárias\n";
        public PilotoRegras(List<TripulanteDto> listaTripulantes) : base(listaTripulantes){}

        public override string VerificarRegrasEmbarque()
        {
            var ocorrencias = VerificarRegrasBase();
            return ocorrencias += VerificarRegrasProprias();
        }

        private string VerificarRegrasProprias()
        {
            if (_listaTripulantes.Count > 1)
            {
                var pilotos = _listaTripulantes.Count(x => x.TipoTripulante == TripulanteEntidade.TipoTripulanteEnum.Piloto);
                var comissarias = _listaTripulantes.Count(x => x.TipoTripulante == TripulanteEntidade.TipoTripulanteEnum.Comissaria);
                if (pilotos > 0 && pilotos + comissarias == _listaTripulantes.Count)
                    return ocorrenciaPilotoComComissarias;
            }
            return "";
        }

        public override bool PodeDirigir()
        {
            return true;
        }
    }
}
