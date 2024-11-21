using CQRS_example.DataAccess;
using CQRS_example.Models;
using CQRS_example.Queries;
using MediatR;

namespace CQRS_example.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IDataAccess _data;
        public GetStudentListHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudents());
        }
    }
}
