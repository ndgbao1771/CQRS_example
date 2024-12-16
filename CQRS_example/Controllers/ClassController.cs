using CQRS_example.Commands;
using CQRS_example.Models;
using CQRS_example.Queries.ClassStudents;
using CQRS_example.Queries.Students;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static CQRS_example.Commands.ClassCommand;

namespace CQRS_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClassController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetClass()
        {
            var query = new GetClassListQuery();
            var listClass = await _mediator.Send(query);
            return Ok(listClass);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClassById(int id)
        {
            var query = new GetClassByIdQuery(id);
            var listClass = await _mediator.Send(query);
            return listClass != null ? Ok(listClass) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddClass([FromBody] AddClassCommand command)
        {
            if (command == null)
            {
                return BadRequest("Invalid class data.");
            }

            var listClass = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetClassById), new { id = listClass.Id }, listClass);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClass(int id, [FromBody] Class listClass)
        {
            if (listClass == null || listClass.Id != id)
            {
                return BadRequest("Invalid class data.");
            }

            var updatedClass = await _mediator.Send(new UpdateClassCommand(id, listClass));
            return updatedClass != null ? Ok(updatedClass) : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(int id)
        {
            var student = await _mediator.Send(new GetClassByIdQuery(id));
            if (student == null)
            {
                return NotFound();
            }

            await _mediator.Send(new DeleteClassCommand(id));
            return NoContent();
        }
    }
}
