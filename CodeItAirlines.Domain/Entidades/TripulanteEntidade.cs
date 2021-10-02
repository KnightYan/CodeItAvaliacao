using System.ComponentModel;

namespace CodeItAirlines.Domain.Entidades
{
    public class TripulanteEntidade : EntidadeBase
    {
        public string Nome { get; set; }
        public TipoTripulanteEnum TipoTripulante { get; set; }
        public enum TipoTripulanteEnum
        {
            [Description("Piloto")]
            Piloto,

            [Description("Oficial")]
            Oficial,

            [Description("Chefe de serviço")]
            ChefeServico,

            [Description("Comissária")]
            Comissaria,

            [Description("Policial")]
            Policial,

            [Description("Presidiário")]
            Presidiario,

            [Description("Valor inválido")]
            ValorInvalidoEnum
        }
    }
}
