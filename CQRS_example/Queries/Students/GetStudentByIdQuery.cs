using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Queries.Students
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        public int Id { get; set; }
        public GetStudentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
