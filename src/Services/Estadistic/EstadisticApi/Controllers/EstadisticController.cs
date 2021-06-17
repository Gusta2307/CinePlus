using EstadisticServicesQueries;
using EstadisticServicesQueries.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceCommonCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstadisticApi.Controllers
{
    [ApiController]
    [Route("estadistics")]
    public class EstadisticController : ControllerBase
    {
        private readonly ILogger<EstadisticController> _logger;

        private readonly IEstadisticQueryService _estadisticServiceQuery;

        public EstadisticController(ILogger<EstadisticController> logger, IEstadisticQueryService estadisticServiceQuery)
        {
            _logger = logger;
            _estadisticServiceQuery = estadisticServiceQuery;
        }

        [HttpGet]
        public async Task<DataCollection<EstadisticDTO>> GetAll()
        {
            return await _estadisticServiceQuery.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<EstadisticDTO> Get(int id)
        {
            return await _estadisticServiceQuery.GetAsync(id);
        }
    }
}
