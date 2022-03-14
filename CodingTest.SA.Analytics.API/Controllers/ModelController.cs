using CodingTest.SA.Analytics.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.API.Controllers
{
    public class ModelController : Controller
    {
        private readonly IModelService _modelService;
        private readonly ILogger<ModelController> _logger;

        public ModelController(IModelService modelService, ILogger<ModelController> logger)
        {
            _modelService = modelService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var result = await _modelService.GetAllAsync();
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
