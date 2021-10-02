using CodeItAirlines.Domain.Entidades;
using System.Collections.Generic;
using System;
using CodeItAirlines.Domain.Interfaces.Data;

namespace CodeItAirlines.Data.Repositorio
{
    public class TripulantesRepositorio : ITripulantesRepositorio
    {
        //Esta classe e Função é apenas uma abstração do acesso aos dados
        public List<TripulanteEntidade> ObterTodos()
        {
            var listaDeTripulantes = new List<TripulanteEntidade>();

            listaDeTripulantes.Add(GerarPiloto());
            listaDeTripulantes.Add(GerarOficial());
            listaDeTripulantes.Add(GerarOficial());
            listaDeTripulantes.Add(GerarChefeServico());
            listaDeTripulantes.Add(GerarComissaria());
            listaDeTripulantes.Add(GerarComissaria());
            listaDeTripulantes.Add(GerarPresidiario());
            listaDeTripulantes.Add(GerarPolicial());

            return listaDeTripulantes;
        }

        private TripulanteEntidade GerarPiloto()
        {
            var tripulante = GerarTripulante();
            tripulante.TipoTripulante = TripulanteEntidade.TipoTripulanteEnum.Piloto;
            
            return tripulante;
        }

        private TripulanteEntidade GerarOficial()
        {
            var tripulante = GerarTripulante();
            tripulante.TipoTripulante = TripulanteEntidade.TipoTripulanteEnum.Oficial;
            
            return tripulante;
        }

        private TripulanteEntidade GerarChefeServico()
        {
            var tripulante = GerarTripulante();
            tripulante.TipoTripulante = TripulanteEntidade.TipoTripulanteEnum.ChefeServico;
            
            return tripulante;
        }

        private TripulanteEntidade GerarComissaria()
        {
            var tripulante = GerarTripulante();
            tripulante.TipoTripulante = TripulanteEntidade.TipoTripulanteEnum.Comissaria;
            
            return tripulante;
        }

        private TripulanteEntidade GerarPolicial()
        {
            var tripulante = GerarTripulante();
            tripulante.TipoTripulante = TripulanteEntidade.TipoTripulanteEnum.Policial;
            
            return tripulante;
        }

        private TripulanteEntidade GerarPresidiario()
        {
            var tripulante = GerarTripulante();
            tripulante.TipoTripulante = TripulanteEntidade.TipoTripulanteEnum.Presidiario;
            
            return tripulante;
        }

        private TripulanteEntidade GerarTripulante()
        {
            return new TripulanteEntidade
            {
                Id = Guid.NewGuid(),
                Nome = Faker.Name.First()
            };
        }
    }
}
