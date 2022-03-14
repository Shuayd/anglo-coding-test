using AutoMapper;
using CodingTest.SA.Analytics.DataAccess.Models;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;
using CodingTest.SA.Analytics.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.Services
{
    public class NewTradeActionService : INewTradeActionService
    {
        private readonly INewTradeActionRepository _newTradeActionRepository;
        private readonly IMapper _mapper;
        public NewTradeActionService(INewTradeActionRepository newTradeActionRepository, IMapper mapper)
        {
            _newTradeActionRepository = newTradeActionRepository;
            _mapper = mapper;
        }

        public async Task<List<NewTradeActionDto>> GetAllAsync()
        {
            var result = await _newTradeActionRepository.GetAsync();
            return _mapper.Map<List<NewTradeActionDto>>(result);
        }
    }
}
