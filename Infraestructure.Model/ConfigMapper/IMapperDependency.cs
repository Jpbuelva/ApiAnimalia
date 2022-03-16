using AutoMapper;

namespace Infraestructure.Model.ConfigMapper
{
    public interface IMapperDependency
    {
        IMapper GetMapper();
    }
}
