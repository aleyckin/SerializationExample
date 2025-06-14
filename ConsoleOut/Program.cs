﻿using Domain;
using IService.Dtos;
using IService.Interfaces;
using Service;

PatientService patientService = new();
List<Patient> patients = new();

while (true)
{
    Console.WriteLine("Меню");
    Console.WriteLine("" +
        "1. Добавить новую запись \n" +
        "2. Удалить запись \n" +
        "3. Получить список всех записей \n");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Введите имя пациента: ");
            string name = Console.ReadLine();

            Console.Write("Введите описание: ");
            string description = Console.ReadLine();

            Console.Write("Введите название болезни: ");
            string disease = Console.ReadLine();

            Console.Write("Введите возраст пациента: ");
            int age = 0;
            try
            {
                age = int.Parse(Console.ReadLine());
            }
            catch { 
                Console.WriteLine("Нужно ввести число.\n");
                break;
            }

            Console.Write("Введите номер палаты(от 1 до 5): ");
            int numberOfRoom = 0;
            try
            {
                age = int.Parse(Console.ReadLine());
                if (age < 1  || age > 5)
                {
                    Console.WriteLine("Номер палаты не может быть меньше 1 или больше 5.\n");
                }
            }
            catch
            {
                Console.WriteLine("Нужно ввести число.\n");
                break;
            }

            PatientDtoForCreate patientDto = new PatientDtoForCreate(name, description, disease, age, numberOfRoom);
            await patientService.AddPatient(patientDto);
            break;

        case "2":
            patients = await patientService.GetAllPatients();
            Console.WriteLine();

            Console.Write("Введите name пациента: ");
            string nameForSearch = Console.ReadLine();

            Guid patientId = patients
                .Where(x => x.Name == nameForSearch)
                .Select(x => x.Id)
                .FirstOrDefault();

            await patientService.DeletePatient(patientId);
            break;

        case "3":
            patients = await patientService.GetAllPatients();

            foreach (Patient patient in patients)
            {
                Console.WriteLine("Список пациентов: \n" +
                    $"Id: {patient.Id}\n" +
                    $"Name: {patient.Name}\n" +
                    $"Description: {patient.Description}\n" +
                    $"Disease: {patient.Disease}\n");
            }

            break;

        default:
            {
                Console.WriteLine("Команда не опознана.\n");
                break;
            }
    }
}