using Infraestructure.Model.ConfigMapper;

namespace Web.Api.Config
{
    public class AutomapperConfig
    {
        public static void CreateMaps()
        {
            LocalConfig.Mapper = Domain.Config.AutomapperConfig.CreateMapper();
        }
    }
}
