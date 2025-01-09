using AutoMapper;
using BLL.Services.StatusService.Abstraction;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        private readonly IStatusService statusService;
        private readonly IMapper mapper;
        private readonly ILogger<StatusController> logger;

        public StatusController(IStatusService statusService, IMapper mapper, ILogger<StatusController> logger)
        {
            this.statusService = statusService;
            this.mapper = mapper;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<StatusResponse>>> GetAllStatuses()
        {
            var statuses = await statusService.GetAllStatusAsync();

            return Ok(mapper.Map<List<StatusResponse>>(statuses));
        }
    }
}
