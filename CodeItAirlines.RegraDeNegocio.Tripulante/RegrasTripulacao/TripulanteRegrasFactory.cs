using CodeItAirlines.Comuns.Exceptions;
using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Entidades;
using System.Collections.Generic;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.RegrasTripulacao
{
    public class TripulanteRegrasFactory
    {
        public static TripulanteRegras IdentificarRegra(TripulanteEntidade.TipoTripulanteEnum tipoTripulante, List<TripulanteDto> _listaTripulantes)
        {
            switch (tipoTripulante)
            {
                case TripulanteEntidade.TipoTripulanteEnum.Piloto:
                    return new PilotoRegras(_listaTripulantes);
                case TripulanteEntidade.TipoTripulanteEnum.Oficial:
                    return new OficialRegras(_listaTripulantes);
                case TripulanteEntidade.TipoTripulanteEnum.ChefeServico:
                    return new ChefeServicoRegras(_listaTripulantes);
                case TripulanteEntidade.TipoTripulanteEnum.Comissaria:
                    return new ComissariaRegras(_listaTripulantes);
                case TripulanteEntidade.TipoTripulanteEnum.Policial:
                    return new PolicialRegras(_listaTripulantes);
                case TripulanteEntidade.TipoTripulanteEnum.Presidiario:
                    return new PresidiarioRegras(_listaTripulantes);
                default:
                    throw new TipoNaoEncontradoException("Tipo do tripulante não encontrado");
            }
        }
    }
}
