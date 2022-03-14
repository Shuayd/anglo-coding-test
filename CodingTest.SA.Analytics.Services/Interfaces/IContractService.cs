using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.Services.Interfaces
{
    public interface IContractService
    {
        Task<List<ContractDto>> GetAllAsync();
    }
}
