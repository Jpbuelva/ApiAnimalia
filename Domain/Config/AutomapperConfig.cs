using AutoMapper;

namespace Domain.Config
{
    public class AutomapperConfig
    {
        public static IMapper CreateMapper()
        {
            var config = CreateConfiguration();
            return config.CreateMapper();
        }

        public static MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<Factoring, FactoringDTO>().ReverseMap();
                //cfg.CreateMap<SpCollectionFactoring, GroupCollectionModel>()
                // .ForMember(dest => dest.AccountingDate, o => o.MapFrom(src => src.AccountingDate.ToShortDateString()))
                // .ForMember(dest => dest.DatePay, o => o.MapFrom(src => src.PayDate))
                // .ForMember(dest => dest.OriginId, o => o.MapFrom(src => src.OriginCode))
                // .ForMember(dest => dest.PaidValue, o => o.MapFrom(src => src.AppliedValue))
                // .ForMember(dest => dest.WayToPayId, o => o.MapFrom(src => src.PayWayCode))
                // .ForMember(dest => dest.Group, o => o.MapFrom(src => src.Group))
                //.ReverseMap();
            });

            return config;
        }
    }
}
