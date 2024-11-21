using CQRS_example.DataAccess;
using CQRS_example.Models;
using CQRS_example.Queries;
using MediatR;

namespace CQRS_example.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
    {
        private readonly IDataAccess _data;
        public GetStudentByIdHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudentById(request.Id));
        }
    }
}
