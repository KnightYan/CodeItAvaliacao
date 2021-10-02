using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.RegrasTripulacao
{
    public abstract class TripulanteRegras
    {   
        private static string ocorrenciaPresidiarioSozinho = "Por motivos de segurança o presidiário não pode ficar sozinho sem a presença do policial\n";

        protected readonly List<TripulanteDto> _listaTripulantes;

        protected TripulanteRegras(List<TripulanteDto> listaTripulantes)
        {
            _listaTripulantes = listaTripulantes;
        }

        public abstract string VerificarRegrasEmbarque();

        protected string VerificarRegrasBase()
        {
            return VerificarPresidiarioSozinho();
        }

        private string VerificarPresidiarioSozinho()
        {
            if (_listaTripulantes.Any(x => x.TipoTripulante == TripulanteEntidade.TipoTripulanteEnum.Presidiario) &&
               !_listaTripulantes.Any(x => x.TipoTripulante == TripulanteEntidade.TipoTripulanteEnum.Policial))
                return ocorrenciaPresidiarioSozinho;
            return "";
        }

        public abstract bool PodeDirigir();
    }
}
