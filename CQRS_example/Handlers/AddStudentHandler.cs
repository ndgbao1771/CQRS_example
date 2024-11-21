using CQRS_example.Commands;
using CQRS_example.DataAccess;
using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Handlers
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly IDataAccess _data;
        public AddStudentHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddStudent(request.firstName, request.lastName, request.age));
        }
    }
}
