using CQRS_example.DataAccess.Interfaces;
using CQRS_example.Models;
using CQRS_example.Queries.Students;
using MediatR;

namespace CQRS_example.Handlers.Students
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentDataAccess _data;
        public GetStudentListHandler(IStudentDataAccess data)
        {
            _data = data;
        }
        public Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudents());
        }
    }
}
