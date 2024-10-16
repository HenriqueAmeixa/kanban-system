

using AutoMapper;
using BoardService.Application.DTOs.UserBoard;
using BoardService.Application.Interfaces;
using BoardService.Domain.Entities;
using BoardService.Domain.Interfaces;

namespace BoardService.Application.Services
{
    public class UserBoardService : IUserBoardService
    {
        private readonly IUserBoardRepository _userBoardRepository;
        private readonly IMapper _mapper;

        public UserBoardService(IUserBoardRepository userBoardRepository, IMapper mapper)
        {
            _userBoardRepository = userBoardRepository;
            _mapper = mapper;
        }

        public async Task<UserBoardSelectDTO> GetByIdAsync(int id)
        {
            var userBoard = await _userBoardRepository.GetByIdAsync(id);
            return _mapper.Map<UserBoardSelectDTO>(userBoard);
        }

        public async Task CreateAsync(UserBoardCreateDTO userBoardCreateDTO)
        {
            var userBoard = _mapper.Map<UserBoard>(userBoardCreateDTO);
            await _userBoardRepository.CreateAsync(userBoard);
        }

        public async Task UpdateAsync(UserBoardUpdateDTO userBoardUpdateDTO)
        {
            var userBoard = _mapper.Map<UserBoard>(userBoardUpdateDTO);
            await _userBoardRepository.UpdateAsync(userBoard);
        }

        public async Task DeleteAsync(int id)
        {
            await _userBoardRepository.DeleteAsync(id);
        }
    }
}
