using CQRS_example.DataAccess.Interfaces;
using MediatR;
using static CQRS_example.Commands.ClassCommand;

namespace CQRS_example.Handlers.ClassStudents
{
    public class DeleteClassHandler : IRequestHandler<DeleteClassCommand>
    {
        private readonly IClassDataAccess _data;

        public DeleteClassHandler(IClassDataAccess data)
        {
            _data = data;
        }

        public Task Handle(DeleteClassCommand request, CancellationToken cancellationToken)
        {
            _data.DeleteClass(request.Id);
            return Task.FromResult(Unit.Value);
        }
    }
}
