using AutoMapper;
using GestionDeTareas.API.Models.DTOs.Tasks;

namespace GestionDeTareas.API.Utilities
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {

            CreateMap<TasksCreacionDTO, Models.Tasks>();
        }
    }
}
