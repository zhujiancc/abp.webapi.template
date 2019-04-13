using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zians.Books.Dtos
{
    [AutoMapTo(typeof(Book))]
    public class CreateUpdateBookDto : EntityDto<int>
    {
    }
}
