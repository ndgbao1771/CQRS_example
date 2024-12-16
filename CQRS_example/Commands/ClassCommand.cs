using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Commands
{
    public class ClassCommand
    {
        public record AddClassCommand(string ClassName) : IRequest<Class>;
        public record UpdateClassCommand(int Id, Class Class) : IRequest<Class>;
        public record DeleteClassCommand(int Id) : IRequest;
    }
}
