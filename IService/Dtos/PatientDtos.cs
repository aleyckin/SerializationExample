using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Dtos
{
    public record PatientDtoForCreate(string Name, string Description, string Desease, int Age, int NumberOfRoom) { }
}
