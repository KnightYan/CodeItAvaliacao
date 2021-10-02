using System.Collections.Generic;
using System.Linq;
using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Entidades;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.RegrasTripulacao
{
    public class ChefeServicoRegras : TripulanteRegras
    {
        private static string ocorrenciaChefeServicoComOficiais = "É política da empresa que o chefe de serviço não pode ficar sozinho com os oficiais\n";
        public ChefeServicoRegras(List<TripulanteDto> listaTripulantes) : base(listaTripulantes){}

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
                    return ocorrenciaChefeServicoComOficiais;
            }
            return "";
        }

        public override bool PodeDirigir()
        {
            return true;
        }
    }
}
