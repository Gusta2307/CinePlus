using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrintServiceQuery;
using PrintServiceQuery.DTO;
using ServiceCommonCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintApi.Controllers
{
    [ApiController]
    [Route("printers")]
    public class PrintController : ControllerBase
    {
        private readonly ILogger<PrintController> _logger;

        private readonly IPrintQueryService _printerServiceQuery;

        public PrintController(ILogger<PrintController> logger, IPrintQueryService printerServiceQuery)
        {
            _logger = logger;
            _printerServiceQuery = printerServiceQuery;
        }

        [HttpGet]
        public async Task<DataCollection<PrinterDTO>> GetAll()
        {
            return await _printerServiceQuery.GetAllAsync();
        }
    }
}
