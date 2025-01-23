using SmartNeighborhoodAPI.Helpers.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Person, PersonDto>().ReverseMap();
    }
}
