using Domain;
using IService.Dtos;

namespace IService.Interfaces
{
    public interface IPatientService
    {
        public Task<List<Patient>> GetAllPatients();
        public Task AddPatient(PatientDtoForCreate patientDto);
        public Task DeletePatient(Guid patientId);
    }
}
