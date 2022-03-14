using CodingTest.SA.Analytics.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.Services.Interfaces
{
    public interface IModelResultService
    {
        Task<List<ModelResultDto>> GetAllAsync();
    }
}
