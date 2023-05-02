using API.Models;
using AutoMapper;
using DAL.Models;

namespace API.Automapper
{
    public class ControllerMappingService : IControllerMappingService
    {
        public Mapper mapper;

        public ControllerMappingService()
        {
            var config = new MapperConfiguration
                (cfg =>
                {
                    cfg.CreateMap<Employees, EmployeesModel>();
                });
            mapper = new Mapper(config);
        }

        public TDestination Map<TDestination>(object source)
        {
            return mapper.Map<TDestination>(source);
        }
    }
}
