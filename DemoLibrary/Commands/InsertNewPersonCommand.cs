using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    //public class InsertNewPersonCommand:IRequest<PersonModel>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public InsertNewPersonCommand(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}

    public record InsertNewPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
}
