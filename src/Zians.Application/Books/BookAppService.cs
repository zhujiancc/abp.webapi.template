using Abp.Application.Services.Dto;
using System;
using System.Threading.Tasks;
using Zians.Books.Dtos;

namespace Zians.Books
{
    public class BookAppService : IBookAppService
    {
        public Task<BookDto> Create(CreateUpdateBookDto input)
        {
            throw new NotImplementedException();
        }

        public Task Delete(EntityDto<int> input)
        {
            throw new NotImplementedException();
        }

        public Task<BookDto> Get(EntityDto<int> input)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<BookDto>> GetAll(PagedAndSortedResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<BookDto> Update(CreateUpdateBookDto input)
        {
            throw new NotImplementedException();
        }
    }
}
