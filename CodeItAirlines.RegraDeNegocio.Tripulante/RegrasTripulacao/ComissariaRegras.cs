using System.Collections.Generic;
using System.Linq;
using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Entidades;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.RegrasTripulacao
{
    public class ComissariaRegras : TripulanteRegras
    {
        private static string ocorrenciaComissariasComPiloto = "É política da empresa que nenhuma comissária pode ficar sozinha com o piloto\n";

        public ComissariaRegras(List<TripulanteDto> listaTripulantes) : base(listaTripulantes){}

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
                    return ocorrenciaComissariasComPiloto;
            }
            return "";
        }

        public override bool PodeDirigir()
        {
            return false;
        }
    }
}
