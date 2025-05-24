using IService.Dtos;
using IService.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class PatientCreate : Form
    {
        /// <summary>
        /// DI контейнер для получения сервиса работы с пациентами.
        /// </summary>
        private readonly IPatientService _patientService;

        /// <summary>
        /// Конструктор формы для создания нового пациента.
        /// </summary>
        public PatientCreate(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Назад". Закрывает форму без сохранения изменений.
        /// </summary>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "Добавить". Создает нового пациента и сохраняет его в базе данных.
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PatientDtoForCreate patientDto = new PatientDtoForCreate(
                textBoxName.Text,
                textBoxDescription.Text,
                textBoxDisease.Text,
                (int)numericUpDownAge.Value,
                (int)numericUpDownRoom.Value
            );
            _patientService.AddPatient(patientDto);
            MessageBox.Show("Пациент успешно добавлен!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
