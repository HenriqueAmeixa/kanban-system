using BoardService.Domain.Entities;
using BoardService.Application.DTOs.KanbanTask;
using AutoMapper;

namespace BoardService.Application.Profiles
{
    public class KanbanTaskProfile : Profile
    {
        public KanbanTaskProfile()
        {
            CreateMap<KanbanTask, KanbanTaskSelectDTO>().ReverseMap();
            CreateMap<KanbanTask, KanbanTaskCreateDTO>().ReverseMap();
            CreateMap<KanbanTask, KanbanTaskUpdateDTO>().ReverseMap();
            CreateMap<KanbanTask, KanbanTaskDeleteDTO>().ReverseMap();
        }
    }
}
