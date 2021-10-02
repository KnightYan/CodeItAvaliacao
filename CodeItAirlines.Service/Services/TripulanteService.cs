using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CodeItAirlines.CrossCutting;
using CodeItAirlines.Data.Repositorio;
using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Interfaces.Service;

namespace CodeItAirlines.Service.Services
{
    public class TripulanteService : ITripulanteService
    {
        private readonly TripulantesRepositorio _repositorio;
        private readonly IMapper _mapper;

        public TripulanteService()
        {
            _repositorio = new TripulantesRepositorio();
            _mapper = AutoMapperBase.Mapper();
        }

        public List<TripulanteDto> ObterTodos()
        {
            var listaEntidade = _repositorio.ObterTodos();
            var listaDto = _mapper.Map<IEnumerable<TripulanteDto>>(listaEntidade);
            return listaDto.ToList();
        }
    }
}
