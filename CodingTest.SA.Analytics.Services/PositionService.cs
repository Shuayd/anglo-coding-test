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
    public class PositionService: IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;

        public PositionService(IPositionRepository positionRepository, IMapper mapper)
        {
            _positionRepository = positionRepository;
            _mapper = mapper;
        }

        public async Task<List<PositionDto>> GetAllAsync()
        {
            var result = await _positionRepository.GetAsync();
            return _mapper.Map<List<PositionDto>>(result);
        }
    }
}
