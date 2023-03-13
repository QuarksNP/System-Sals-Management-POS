using itlapr.BLL.Dtos;
using itlapr.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlapr.BLL.Extentions
{
    public static class EmployeesExtention
    {
        public static Employees GetEmployeesEntityFromDtoSave(this EmployeesAddDto addDto)
        {
            Employees employees = new Employees()
            {
                firstName = addDto.FirstName,
                lastName = addDto.LastName,
                HireDate = addDto.HireDate,
                title = addDto.title,
                titleOfCourtesy = addDto.titleOfCourtesy,
                address = addDto.address,
                mGrid = addDto.mGrid,
                city = addDto.city,
                country = addDto.country,
                region = addDto.region,
                postalCode = addDto.postalCode,
                phone = addDto.phone
            };

            return employees;
        }
    }
}
