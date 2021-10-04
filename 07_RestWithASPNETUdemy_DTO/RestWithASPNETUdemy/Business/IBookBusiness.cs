using RestWithASPNETUdemy.Data.DTO;
using RestWithASPNETUdemy.models;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IBookBusiness
    {
        BookDTO Create(BookDTO book);
        BookDTO FindByID(long id);
        List<BookDTO> FindAll();
        BookDTO Update(BookDTO book);
        void Delete(long id);
    }
}
