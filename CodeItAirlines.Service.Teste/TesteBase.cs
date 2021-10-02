using AutoMapper;
using CodeItAirlines.CrossCutting;

namespace CodeItAirlines.Service.Teste
{
    public class TesteBase
    {
        public IMapper _mapper { get; set; }

        public TesteBase()
        {
            AutoMapperBase.ConfigurarAutoMapper();
            _mapper = AutoMapperBase.Mapper();
        }

    }
}
