using Domain;
using IService.Dtos;
using IService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service
{
    public class PatientService : IPatientService
    {
        private readonly string desktopPath;
        private readonly string filePath;

        public PatientService() 
        {
            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            filePath = Path.Combine(desktopPath, "Task1/patients.json");
            CreateFileIfNotExist();
        }

        public async Task AddPatient(PatientDtoForCreate patientDto)
        {
            List<Patient> patients = await GetAllPatients();
            patients.Add(new Patient
            {
                Id = Guid.NewGuid(),
                Name = patientDto.Name,
                Description = patientDto.Description,
                Disease = patientDto.Desease,
                Age = patientDto.Age,
                NumberOfRoom = patientDto.NumberOfRoom,
            });

            await CreateJsonFile(patients);
            Console.WriteLine("Пациент успешно добавлен!\n");
        }

        public async Task DeletePatient(Guid patientId)
        {
            List<Patient> patients = await GetAllPatients();
            Patient patient = patients
                .Where(x => x.Id == patientId)
                .FirstOrDefault();

            if (patient == null)
            {
                Console.WriteLine("Пациент с таким именем не найден.\n");
                return;
            }

            patients.Remove(patient);

            await CreateJsonFile(patients);
            Console.WriteLine("Пациент успешно удалён!\n");
        }

        public async Task<List<Patient>> GetAllPatients()
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                List<Patient> patients = new List<Patient>();
                try
                {
                    patients = await JsonSerializer.DeserializeAsync<List<Patient>>(fs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Список пациентов пуст.\n");
                }

                return patients;
            }
        }

        public async Task<int> GetMostPopulatedRoom()
        {
            var patients = await GetAllPatients();
            int numberOfRoom = patients
                .GroupBy(x => x.NumberOfRoom)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            return numberOfRoom;
        }

        public async Task<List<Patient>> GetPatientOlderThan(int age)
        {
            List<Patient> patients = await GetAllPatients();
            patients = (from patient in patients
                       where patient.Age > age
                       select patient).ToList();
                      
            return patients;
        }

        private void CreateFileIfNotExist()
        {
            if (!File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create)) { };
            }
        }

        private async Task CreateJsonFile(List<Patient> patients)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                await JsonSerializer.SerializeAsync<List<Patient>>(fs, patients, options);
            }
        }
    }
}
