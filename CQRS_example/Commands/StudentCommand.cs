using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Commands
{
    public record AddStudentCommand(string FirstName, string LastName, double Age) : IRequest<Student>;

    public record UpdateStudentCommand(int Id, Student Student) : IRequest<Student>;

    public record DeleteStudentCommand(int Id) : IRequest;
}
