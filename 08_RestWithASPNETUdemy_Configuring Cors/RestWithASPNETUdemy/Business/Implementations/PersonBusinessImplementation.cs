using System.Collections.Generic;
using RestWithASPNETUdemy.Data.DTO;
using RestWithASPNETUdemy.Data.DTO.Converter.Implementations;
using RestWithASPNETUdemy.models;
using RestWithASPNETUdemy.Repository;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
         private readonly IRepository<Person> _repository;
         private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }
        public List<PersonDTO> FindAll()
        {
            return _converter.Parse (_repository.FindAll());
        }
        public PersonDTO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id)) ;
        }
        public PersonDTO Create(PersonDTO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }
        public PersonDTO Update(PersonDTO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}