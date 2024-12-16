using CQRS_example.Commands;
using CQRS_example.DataAccess.Interfaces;
using MediatR;

namespace CQRS_example.Handlers.Students
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand>
    {
        private readonly IStudentDataAccess _data;

        public DeleteStudentHandler(IStudentDataAccess data)
        {
            _data = data;
        }

        Task IRequestHandler<DeleteStudentCommand>.Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            _data.DeleteStudent(request.Id);
            return Task.FromResult(Unit.Value);
        }
    }
}
