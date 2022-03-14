using CodingTest.SA.Analytics.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.Services.Interfaces
{
    public interface INewTradeActionService
    {
        Task<List<NewTradeActionDto>> GetAllAsync();
    }
}
