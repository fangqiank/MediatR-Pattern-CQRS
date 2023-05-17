using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> _people = new();

        public DemoDataAccess()
        {
            _people.Add(new PersonModel
            {
                Id = 1,
                FirstName = "Zhang",
                LastName = "San"
            });

            _people.Add(new PersonModel
            {
                Id = 2,
                FirstName = "Li",
                LastName = "Si"
            });
        }

        public List<PersonModel> GetPeople() => _people;

        public PersonModel InsertPerson(string FirstName, string LastName)
        {
            PersonModel p = new()
            {
                FirstName = FirstName,
                LastName = LastName,
                Id = _people.Max(x => x.Id) + 1
            };
            _people.Add(p);
            return p;
        }
    }
}
