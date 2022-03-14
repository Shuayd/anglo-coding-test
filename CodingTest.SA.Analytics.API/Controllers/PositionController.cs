using CodingTest.SA.Analytics.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.API.Controllers
{
    []
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;
        private readonly ILogger<PositionController> _logger;

        public PositionController(IPositionService positionService, ILogger<PositionController> logger)
        {
            _positionService = positionService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var result = await _positionService.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return View();
        }
    }
}
