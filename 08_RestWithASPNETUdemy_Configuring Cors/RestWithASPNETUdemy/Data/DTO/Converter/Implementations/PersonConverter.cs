using System.Collections.Generic;
using System.Linq;
using RestWithASPNETUdemy.Data.DTO.Converter.Contract;
using RestWithASPNETUdemy.models;

namespace RestWithASPNETUdemy.Data.DTO.Converter.Implementations
{
    public class PersonConverter : IParser<PersonDTO, Person>, IParser<Person, PersonDTO>
    {
        public Person Parse(PersonDTO origin)
        {
            if(origin == null) return null;
            return new Person
            {
                Id  = origin.Id,
                FirstName = origin.FirstName,
                LastName =  origin.LastName,
                Address =  origin.Address,
                Gender= origin.Gender
            };
        }
        public PersonDTO Parse(Person origin)
        {
             if(origin == null) return null;
            return new PersonDTO
            {
                Id  = origin.Id,
                FirstName = origin.FirstName,
                LastName =  origin.LastName,
                Address =  origin.Address,
                Gender= origin.Gender
            };
        }
        public List<PersonDTO> Parse(List<Person> origin)
        {
             if(origin == null) return null;
            return origin.Select(item => Parse(item)).ToList(); 
        } 
        public List<Person> Parse(List<PersonDTO> origin)
        {
            if(origin == null) return null;
            return origin.Select(item => Parse(item)).ToList(); 
        }
    }
}