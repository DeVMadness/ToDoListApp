using AutoMapper;
using BLL.Services.AssignmentService.Abstraction;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService assignmentService;
        private readonly IMapper mapper;
        private readonly ILogger<AssignmentController> logger;

        public AssignmentController(IAssignmentService assignmentService, IMapper mapper, ILogger<AssignmentController> logger)
        {
            this.assignmentService = assignmentService;
            this.mapper = mapper;
            this.logger = logger;
        }


        [HttpGet]
        public async Task<ActionResult<List<AssignmentResponse>>> GetAllAssignments()
        {
            var assignments = await assignmentService.GetAllAssignmentsAsync();

            return Ok(mapper.Map<List<AssignmentResponse>>(assignments));
        }
    }
}
