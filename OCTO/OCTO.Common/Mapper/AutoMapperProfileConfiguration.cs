using AutoMapper;
using OCTO.DAL.Models;

namespace OCTO.Common.Mapper
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            CreateMap<Account, AccountModel>();
        }
    }
}
