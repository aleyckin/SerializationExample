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
        private readonly IPatientService _patientService;
        public PatientCreate(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

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
