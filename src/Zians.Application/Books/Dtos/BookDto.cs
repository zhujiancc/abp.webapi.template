using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Zians.Books.Dtos
{
    [AutoMapFrom(typeof(Book))]
    public class BookDto : EntityDto<int>
    {
    }
}
