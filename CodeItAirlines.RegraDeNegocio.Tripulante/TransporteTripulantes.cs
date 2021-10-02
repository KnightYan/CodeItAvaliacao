using CodeItAirlines.Domain.Dtos;
using System.Linq;
using System.Collections.Generic;
using CodeItAirlines.RegraDeNegocio.Tripulante.RegrasTripulacao;
using System.ComponentModel;
using CodeItAirlines.Comuns.Exceptions;
using CodeItAirlines.Domain.Interfaces.RegraDeNegocio.Tripulante;
using static CodeItAirlines.Domain.Entidades.TripulanteEntidade;
using CodeItAirlines.Comuns.Extensions;

namespace CodeItAirlines.RegraDeNegocio.Tripulante
{
    public class TransporteTripulantes : ITransporteTripulantes
    {
        private static string ocorrenciaLimiteUltrapassado = "O limite de {0} pessoas no {1} foi ultrapassado!\n";
        private static string ocorrenciaEhNecessarioUmPiloto = "É obrigatorio um piloto no {0}!\n";

        private readonly List<TripulanteDto> _listaTripulantes;
        private readonly TipoTransporteTripulanteEnum _tipoTransporte;
        private readonly int _limitePessoas;

        public TransporteTripulantes(List<TripulanteDto> listaTripulantes, TipoTransporteTripulanteEnum tipoTransporte)
        {
            _listaTripulantes = listaTripulantes;
            _tipoTransporte = tipoTransporte;
            _limitePessoas = DefinirLimitePessoas();
        }

        public string EmbarcarTripulante(TripulanteDto tripulante)
        {
            _listaTripulantes.Add(tripulante);
            var ocorrencia = VerificarRegras();
            if (!ocorrencia.IsNullOrWhiteSpaceOrSpecialFeatures())
            {
                _listaTripulantes.Remove(tripulante);
            }

            return ocorrencia;
        }

        public string EmbarcarDoisTripulante(TripulanteDto tripulante1, TripulanteDto tripulante2)
        {
            _listaTripulantes.Add(tripulante1);
            _listaTripulantes.Add(tripulante2);
            var ocorrencia = VerificarRegras();
            if (!ocorrencia.IsNullOrWhiteSpaceOrSpecialFeatures())
            {
                _listaTripulantes.Remove(tripulante1);
                _listaTripulantes.Remove(tripulante2);
            }

            return ocorrencia;
        }

        public List<TripulanteDto> DesembargarTripulantes()
        {
            var listaTripulantes = new List<TripulanteDto>();
            listaTripulantes = _listaTripulantes.ToList();
            _listaTripulantes.Clear();
            return listaTripulantes;
        }

        public List<TripulanteDto> ObterTripulantesPorTipos(List<TipoTripulanteEnum> tipoTripulantes, string ocorrencia)
        {
            ocorrencia = "";
            var listaTripulantes = new List<TripulanteDto>();
            //listaTripulantes = _listaTripulantes.Where(x => tipoTripulante.Contains(x.TipoTripulante)).ToList();
            foreach (var tipo in tipoTripulantes)
            {
                var tripulante = _listaTripulantes.First(x => tipo.Equals(x.TipoTripulante));
                listaTripulantes.Add(tripulante);
                _listaTripulantes.Remove(tripulante);
            }

            ocorrencia = VerificarRegras();
            if (!ocorrencia.IsNullOrWhiteSpaceOrSpecialFeatures())
            {
                _listaTripulantes.AddRange(listaTripulantes);
                listaTripulantes.Clear();
            }
            return listaTripulantes;
        }

        public List<TripulanteDto> ObterCopiaListaPassageiros()
        {
            var listaTripulantes = new List<TripulanteDto>();
            listaTripulantes = _listaTripulantes.ToList();
            return listaTripulantes;
        }

        private string VerificarRegras()
        {
            string ocorrencias = "";
            if(_listaTripulantes.Count > 0)
            {
                var tripulante = _listaTripulantes.First();
                var regrasTripulante = TripulanteRegrasFactory.IdentificarRegra(tripulante.TipoTripulante, _listaTripulantes);
                ocorrencias += (regrasTripulante.VerificarRegrasEmbarque());
                ocorrencias += (VerificarLimiteTripulantes());
                ocorrencias += (VerificarPossibilidadeDirigir());
            }

            return ocorrencias;
        }

        private string VerificarLimiteTripulantes()
        {
            if (_listaTripulantes.Count > _limitePessoas)
                return string.Format(ocorrenciaLimiteUltrapassado, _limitePessoas, _tipoTransporte.GetDescription());
            return "";
        }

        private string VerificarPossibilidadeDirigir()
        {
            if(_tipoTransporte == TipoTransporteTripulanteEnum.Veiculo)
            {
                foreach(var tripulante in _listaTripulantes)
                {
                    var regrasTripulante = TripulanteRegrasFactory.IdentificarRegra(tripulante.TipoTripulante, _listaTripulantes);
                    if (regrasTripulante.PodeDirigir())
                        return "";
                }

                return string.Format(ocorrenciaEhNecessarioUmPiloto, TipoTransporteTripulanteEnum.Veiculo.GetDescription());
            }

            return "";
        }

        private int DefinirLimitePessoas()
        {
            switch (_tipoTransporte)
            {
                case TipoTransporteTripulanteEnum.Aviao:
                    return 60;
                case TipoTransporteTripulanteEnum.Terminal:
                    return 200;
                case TipoTransporteTripulanteEnum.Veiculo:
                    return 2;
                default:
                    throw new TipoNaoEncontradoException("Tipo de transporte não encontrado");
            }
        }

        public enum TipoTransporteTripulanteEnum
        {
            [Description("Terminal")]
            Terminal,

            [Description("Veículo Smart Fortwo")]
            Veiculo,

            [Description("Avião")]
            Aviao,

            [Description("Valor inválido")]
            ValorInvalidoEnum
        }
    }
}
