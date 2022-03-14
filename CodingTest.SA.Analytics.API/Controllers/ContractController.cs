using CodingTest.SA.Analytics.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.API.Controllers
{
    public class ContractController : Controller
    {
        private readonly IContractService _contractService;
        private readonly ILogger<ContractController> _logger;

        public ContractController(IContractService contractService, ILogger<ContractController> logger)
        {
            _contractService = contractService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var result = await _contractService.GetAllAsync();
            }
            catch (Exception ex)
            {
                //log
                _logger.LogError(ex.Message);
            }
            return View();
        }
    }
}
