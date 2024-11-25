using CQRS_example.Commands;
using CQRS_example.Models;
using CQRS_example.Queries.Students;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var query = new GetStudentListQuery();
            var students = await _mediator.Send(query);
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var query = new GetStudentByIdQuery(id);
            var student = await _mediator.Send(query);
            return student != null ? Ok(student) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] AddStudentCommand command)
        {
            if (command == null)
            {
                return BadRequest("Invalid student data.");
            }

            var student = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] Student student)
        {
            if (student == null || student.Id != id)
            {
                return BadRequest("Invalid student data.");
            }

            var updatedStudent = await _mediator.Send(new UpdateStudentCommand(id, student));
            return updatedStudent != null ? Ok(updatedStudent) : NotFound();
        }

        //[HttpPatch("{id}")]
        //public async Task<IActionResult> PatchStudent(int id, [FromBody] JsonPatchDocument<Student> patchDoc)
        //{
        //    if (patchDoc == null)
        //    {
        //        return BadRequest("Invalid patch document.");
        //    }

        //    var student = await _mediator.Send(new GetStudentByIdQuery(id));
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }

        //    patchDoc.ApplyTo(student);
        //    var updatedStudent = await _mediator.Send(new UpdateStudentCommand(id, student));
        //    return Ok(updatedStudent);
        //}

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _mediator.Send(new GetStudentByIdQuery(id));
            if (student == null)
            {
                return NotFound();
            }

            await _mediator.Send(new DeleteStudentCommand(id));
            return NoContent();
        }
    }
}
