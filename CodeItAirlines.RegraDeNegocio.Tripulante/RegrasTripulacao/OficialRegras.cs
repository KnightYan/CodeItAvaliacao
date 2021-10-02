using System.Collections.Generic;
using System.Linq;
using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Entidades;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.RegrasTripulacao
{
    public class OficialRegras : TripulanteRegras
    {
        private static string ocorrenciaOficiaisComChefeServico = "É política da empresa que nenhum oficial pode ficar sozinho com o chefe de serviço\n";
        public OficialRegras(List<TripulanteDto> listaTripulantes) : base(listaTripulantes){}

        public override string VerificarRegrasEmbarque()
        {
            var ocorrencias = VerificarRegrasBase();
            return ocorrencias += VerificarRegrasProprias();
        }

        private string VerificarRegrasProprias()
        {
            if (_listaTripulantes.Count > 1)
            {
                var chefeServico = _listaTripulantes.Count(x => x.TipoTripulante == TripulanteEntidade.TipoTripulanteEnum.ChefeServico);
                var oficiais = _listaTripulantes.Count(x => x.TipoTripulante == TripulanteEntidade.TipoTripulanteEnum.Oficial);
                if (chefeServico > 0 && chefeServico + oficiais == _listaTripulantes.Count)
                    return ocorrenciaOficiaisComChefeServico;
            }
            return "";
        }

        public override bool PodeDirigir()
        {
            return false;
        }
    }
}
