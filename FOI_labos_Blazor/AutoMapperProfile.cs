using AutoMapper;
using FOI_labos_Blazor.Data.Models;

namespace FOI_labos_Blazor.Shared;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<TodoDto, Todo>()
            .ReverseMap();
    }
}