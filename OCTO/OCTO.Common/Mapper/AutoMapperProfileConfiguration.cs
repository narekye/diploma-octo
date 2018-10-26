using AutoMapper;
using OCTO.BLL.Models;
using OCTO.BLL.Models.Filters;
using OCTO.DAL.Filters;
using OCTO.DAL.Models;

namespace OCTO.Common.Mapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            CreateMap<Account, AccountModel>();
            CreateMap<Contact, ContactModel>();

            CreateMap<AccountFilter, AccountFilterModel>();
            CreateMap<ContactFilter, ContactFilterModel>();
        }
    }
}
