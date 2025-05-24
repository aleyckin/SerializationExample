using IService.Interfaces;
using System.Windows.Forms;
using View;

namespace SerializationTest
{
    public partial class MainForm : Form
    {
        private readonly IPatientService _patientService;
        Guid patientId = Guid.Empty;

        public MainForm(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
        }

        public async void MainForm_Load(object sender, EventArgs e)
        {
            await RefreshDataGridAsync();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patientId = Guid.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (patientId == Guid.Empty)
            {
                throw new Exception("Не удалось выбрать пациента.");
            }
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await RefreshDataGridAsync();
        }

        private async Task RefreshDataGridAsync()
        {
            var patients = await _patientService.GetAllPatients();
            dataGridView.DataSource = null;
            dataGridView.DataSource = patients;
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await _patientService.DeletePatient(patientId);
            await RefreshDataGridAsync();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var result = new PatientCreate(_patientService);
            if (result.ShowDialog() == DialogResult.OK)
            {
                await RefreshDataGridAsync();
            }
        }

        private async void buttonAge_Click(object sender, EventArgs e)
        {
            var patients = await _patientService.GetPatientOlderThan((int)numericUpDown.Value);
            dataGridView.DataSource = null;
            dataGridView.DataSource = patients;
        }

        private async void buttonRoom_Click(object sender, EventArgs e)
        {
            var numberOfRoom = await _patientService.GetMostPopulatedRoom();
            MessageBox.Show($"Номер самой заполненной палаты: {numberOfRoom}.");
        }
    }
}
