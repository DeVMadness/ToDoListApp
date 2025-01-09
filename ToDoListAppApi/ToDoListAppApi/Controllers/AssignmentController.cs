using AutoMapper;
using BLL.Services.AssignmentService.Abstraction;
using Domain.Models;
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

        [HttpGet("{id}")]

        public async Task<ActionResult<AssignmentResponse>> GetAssignmentById(int id)
        {
            var assignment = await assignmentService.GetAssignmentByIdAsync(id);

            if (assignment == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<AssignmentResponse>(assignment));
        }

        [HttpGet("status/{statusId}")]
        public async Task<ActionResult<List<AssignmentResponse>>> GetAssignmentsByStatus(int statusId)
        {
            var assignments = await assignmentService.GetAssignmentsByStatusAsync(statusId);

            return Ok(mapper.Map<List<AssignmentResponse>>(assignments));
        }

        [HttpPost]
        public async Task<ActionResult<AssignmentResponse>> CreateAssignment([FromBody] AssignmentRequest assignmentRequest)
        {
            var assignment = mapper.Map<Assignment>(assignmentRequest);
            var createdAssignment = await assignmentService.CreateAssignmentAsync(assignment);
            var assignmentResponse = mapper.Map<AssignmentResponse>(createdAssignment);

            return CreatedAtAction(nameof(GetAssignmentById), new { id = assignmentResponse.Id }, assignmentResponse);
        }

        [HttpPut]
        public async Task<ActionResult<AssignmentResponse>> UpdateAssignment([FromBody] AssignmentUpdateRequest assignmentUpdateRequest)
        { 
            var assignment = mapper.Map<Assignment>(assignmentUpdateRequest);
            var updatedAssignment = await assignmentService.UpdateAssignmentAsync(assignmentUpdateRequest.Id, assignment);
            var assignmentResponse = mapper.Map<AssignmentResponse>(updatedAssignment);

            return Ok(assignmentResponse);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAssignment(int id)
        {
            await assignmentService.DeleteAssignmentById(id);

            return NoContent();
        }
    }
}
