using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper
{
    class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // mapping for which source and dest prop same
            Mapper.CreateMap<Order, OrderDto>();

            // mapping for which source and dest prop not same
            Mapper.CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.EmpName, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.EmpId, opt => opt.MapFrom(src => src.id));

        }
    }
}
