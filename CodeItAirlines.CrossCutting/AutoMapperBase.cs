using AutoMapper;
using CodeItAirlines.CrossCutting.Mapeamento;

namespace CodeItAirlines.CrossCutting
{
    public class AutoMapperBase
    {
        private static IMapper _mapper;  
        public static IMapper Mapper()
        {
            if (_mapper == null)
                ConfigurarAutoMapper();
            return _mapper;
        }
        
        public static void ConfigurarAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EntidadeParaDto());
            });

            _mapper = config.CreateMapper();
        }
    }
}
