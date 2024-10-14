using AutoMapper;
using BoardService.Application.DTOs.Board;
using BoardService.Domain.Entities;

namespace BoardService.Application.Profiles
{
    public class BoardProfile : Profile
    {
        public BoardProfile()
        {
            CreateMap<Board, BoardSelectDTO>().ReverseMap();
            CreateMap<Board, BoardCreateDTO>().ReverseMap();
            CreateMap<Board, BoardUpdateDTO>().ReverseMap();
            CreateMap<Board, BoardDeleteDTO>().ReverseMap();
        }
    }
}
