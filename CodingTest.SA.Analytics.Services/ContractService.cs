using AutoMapper;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;
using CodingTest.SA.Analytics.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.Services
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _contractRepository;
        private readonly IMapper _mapper;
        public ContractService(IContractRepository contractRepository, IMapper mapper)
        {
            _contractRepository = contractRepository;
            _mapper = mapper;
        }

        public async Task<List<ContractDto>> GetAllAsync()
        {
            var result = await _contractRepository.GetAsync();
            return _mapper.Map<List<ContractDto>>(result);
        }
    }
}
