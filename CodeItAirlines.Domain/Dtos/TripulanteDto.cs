using CodeItAirlines.Comuns.Extensions;
using CodeItAirlines.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CodeItAirlines.Domain.Dtos
{
    public class TripulanteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Bitmap Imagem { get; set; }
        public TripulanteEntidade.TipoTripulanteEnum TipoTripulante { get;set; }
        public string NomeComCargo
        {
            get
            {
                return TipoTripulante.GetDescription() + " " + Nome;
            }
        }

        public override bool Equals(object obj)
        {
            var dto = obj as TripulanteDto;
            return dto != null &&
                   Id.Equals(dto.Id);
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<Guid>.Default.GetHashCode(Id);
        }
    }
}
