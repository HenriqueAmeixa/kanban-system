using AutoMapper;
using BoardService.Application.DTOs.UserBoard;
using BoardService.Domain.Entities;

namespace BoardService.Application.Profiles
{
    public class UserBoardProfile : Profile
    {
        public UserBoardProfile()
        {
            CreateMap<UserBoard, UserBoardSelectDTO>().ReverseMap();
            CreateMap<UserBoard, UserBoardCreateDTO>().ReverseMap();
            CreateMap<UserBoard, UserBoardUpdateDTO>().ReverseMap();
            CreateMap<UserBoard, UserBoardDeleteDTO>().ReverseMap();
        }
    }
}
