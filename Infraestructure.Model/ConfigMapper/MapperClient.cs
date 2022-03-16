namespace Infraestructure.Model.ConfigMapper
{
    public class MapperClient : IMapperDependency
    {
        public MapperClient()
        {
        }

        #region IMapperDependency implementation

        public AutoMapper.IMapper GetMapper()
        {
            return LocalConfig.Mapper;
        }

        #endregion
    }
}
