using CQRS_example.DataAccess.Interfaces;
using CQRS_example.Models;
using CQRS_example.Queries.ClassStudents;
using MediatR;

namespace CQRS_example.Handlers.ClassStudents
{
    public class GetClassByIdHandler : IRequestHandler<GetClassByIdQuery, Class>
    {
        private readonly IClassDataAccess _data;

        public GetClassByIdHandler(IClassDataAccess data)
        {
            _data = data;
        }

        public Task<Class> Handle(GetClassByIdQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetClassById(request.Id));
        }
    }
}
