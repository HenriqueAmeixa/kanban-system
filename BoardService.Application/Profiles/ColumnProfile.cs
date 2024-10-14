using AutoMapper;
using BoardService.Application.DTOs.Column;
using BoardService.Domain.Entities;

namespace BoardService.Application.Profiles
{
    public class ColumnProfile : Profile
    {
        public ColumnProfile()
        {
            CreateMap<Column, ColumnSelectDTO>().ReverseMap();
            CreateMap<Column, ColumnCreateDTO>().ReverseMap();
            CreateMap<Column, ColumnUpdateDTO>().ReverseMap();
            CreateMap<Column, ColumnDeleteDTO>().ReverseMap();
        }
    }
}
