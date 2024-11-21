﻿using CQRS_example.Commands;
using CQRS_example.Queries;
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
            var students = await _mediator.Send(query);
            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] AddStudentCommand command)
        {
            if (command == null)
            {
                return BadRequest("Invalid student data.");
            }

            var student = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
        }
    }
}