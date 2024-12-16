using CQRS_example.DataAccess.Interfaces;
using CQRS_example.Models;
using CQRS_example.Queries.Students;
using MediatR;

namespace CQRS_example.Handlers.Students
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
    {
        private readonly IStudentDataAccess _data;

        public GetStudentByIdHandler(IStudentDataAccess data)
        {
            _data = data;
        }

        public Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudentById(request.Id));
        }
    }
}
