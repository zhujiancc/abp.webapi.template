using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Zians.Books.Dtos;

namespace Zians.Books
{
    public interface IBookAppService :
       IAsyncCrudAppService< //Defines CRUD methods
           BookDto, //Used to show books
           int, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting on getting a list of books
           CreateUpdateBookDto, //Used to create a new book
           CreateUpdateBookDto> //Used to update a book
    {

    }
}
