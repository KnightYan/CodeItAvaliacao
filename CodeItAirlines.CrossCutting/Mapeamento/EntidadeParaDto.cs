using System;
using AutoMapper;
using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.Domain.Entidades;

namespace CodeItAirlines.CrossCutting.Mapeamento
{
    public class EntidadeParaDto : Profile
    {
        public EntidadeParaDto()
        {
            CreateMap<TripulanteDto, TripulanteEntidade>()
                .ReverseMap();
        }
    }
}
