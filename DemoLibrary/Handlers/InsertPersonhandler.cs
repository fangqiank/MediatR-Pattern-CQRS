using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class InsertPersonhandler : IRequestHandler<InsertNewPersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;

        public InsertPersonhandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<PersonModel> Handle(
            InsertNewPersonCommand request,
            CancellationToken cancellationToken
            ) => Task.FromResult(_data.InsertPerson(request.FirstName, request.LastName));
    }
}
