using CQRS_example.Commands;
using CQRS_example.DataAccess.Interfaces;
using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Handlers.Students
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly IStudentDataAccess _data;
        public AddStudentHandler(IStudentDataAccess data)
        {
            _data = data;
        }
        public Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddStudent(request.FirstName, request.LastName, request.Age));
        }
    }
}
