namespace API.Automapper
{
    public interface IControllerMappingService
    {
        TDestination Map<TDestination>(object source);
    }
}
