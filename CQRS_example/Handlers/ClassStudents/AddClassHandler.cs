using CQRS_example.DataAccess.Interfaces;
using CQRS_example.Models;
using MediatR;
using static CQRS_example.Commands.ClassCommand;

namespace CQRS_example.Handlers.ClassStudents
{
    public class AddClassHandler : IRequestHandler<AddClassCommand, Class>
    {
        private readonly IClassDataAccess _data;

        public AddClassHandler(IClassDataAccess data)
        {
            _data = data;
        }

        public Task<Class> Handle(AddClassCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddClass(request.ClassName));
        }
    }
}
