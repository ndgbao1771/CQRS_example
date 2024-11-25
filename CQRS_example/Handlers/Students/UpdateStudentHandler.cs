using CQRS_example.Commands;
using CQRS_example.DataAccess;
using CQRS_example.DataAccess.Interfaces;
using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Handlers.Students
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, Student>
    {
        private readonly IStudentDataAccess _data;

        public UpdateStudentHandler(IStudentDataAccess data)
        {
            _data = data;
        }

        public Task<Student> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.UpdateStudent(request.Id, request.Student));
        }
    }
}
