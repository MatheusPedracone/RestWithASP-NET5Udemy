using System.Collections.Generic;
using RestWithASPNETUdemy.Data.DTO;

namespace RestWithASPNETUdemy.Business
{
    public interface IPersonBusiness
    {
        PersonDTO Create(PersonDTO person);
        PersonDTO FindByID(long id);
        List<PersonDTO> FindAll();
        PersonDTO Update(PersonDTO person);
        void Delete(long id);
    }
}