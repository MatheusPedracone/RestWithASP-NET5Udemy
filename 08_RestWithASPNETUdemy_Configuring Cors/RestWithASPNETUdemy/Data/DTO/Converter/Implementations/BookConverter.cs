using System.Collections.Generic;
using RestWithASPNETUdemy.Data.DTO.Converter.Contract;
using RestWithASPNETUdemy.models;

namespace RestWithASPNETUdemy.Data.DTO.Converter.Implementations
{
    public class BookConverter : IParser<BookDTO, Book>, IParser<Book, BookDTO>
    {
        public Book Parse(BookDTO origin)
        {
             if(origin == null) return null;
            return new Book
            {
                Id  = origin.Id,
                Tittle = origin.Tittle,
                Author =  origin.Author,
                Price =  origin.Price,
                LaunchDate= origin.LaunchDate
            };
        }
        public BookDTO Parse(Book origin)
        {
             if(origin == null) return null;
            return new BookDTO
            {
                 Id  = origin.Id,
                Tittle = origin.Tittle,
                Author =  origin.Author,
                Price =  origin.Price,
                LaunchDate= origin.LaunchDate
            };
        }
        public List<Book> Parse(List<BookDTO> origin)
        {
            throw new System.NotImplementedException();
        }
        public List<BookDTO> Parse(List<Book> origin)
        {
            throw new System.NotImplementedException();
        }
    }
}