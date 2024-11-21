using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Commands
{
    public record AddStudentCommand(string firstName, string lastName, double age) : IRequest<Student>;
}
