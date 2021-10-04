﻿using System.Collections.Generic;
using RestWithASPNETUdemy.Data.DTO;
using RestWithASPNETUdemy.Data.DTO.Converter.Implementations;
using RestWithASPNETUdemy.models;
using RestWithASPNETUdemy.Repository;

namespace RestWithASPNETUdemy.Business.Implementations
{
     public class BookBusinessImplementation : IBookBusiness
    {

        private readonly IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }
        public List<BookDTO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        public BookDTO FindByID(long id)
        {
            return _converter.Parse( _repository.FindByID(id));
        }

        public BookDTO Create(BookDTO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public BookDTO Update(BookDTO book)
        {
             var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}