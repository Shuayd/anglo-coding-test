using AutoMapper;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;
using CodingTest.SA.Analytics.Services.Interfaces;
using CodingTest.SA.Analytics.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.Services
{
    public class ModelResultService : IModelResultService
    {
        private readonly IModelResultRepository _modelResultRepository;
        private readonly IMapper _mapper;
        public ModelResultService(IModelResultRepository modelResultRepository, IMapper mapper)
        {
            _modelResultRepository = modelResultRepository;
            _mapper = mapper;
        }

        public async Task<List<ModelResultDto>> GetAllAsync()
        {
            var result = await _modelResultRepository.GetAsync(null, null, "Contract,Position,NewTradeAction");
            return _mapper.Map<List<ModelResultDto>>(result);
        }
    }
}
