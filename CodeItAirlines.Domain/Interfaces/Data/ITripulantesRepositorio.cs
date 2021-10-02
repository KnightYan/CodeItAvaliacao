using CodeItAirlines.Domain.Entidades;
using System.Collections.Generic;

namespace CodeItAirlines.Domain.Interfaces.Data
{
    public interface ITripulantesRepositorio
    {
        List<TripulanteEntidade> ObterTodos();
    }
}
