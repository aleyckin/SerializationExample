using IService.Interfaces;
using System.Windows.Forms;
using View;

namespace SerializationTest
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// DI ��������� ��� ��������� ������� ������ � ����������.
        /// </summary>
        private readonly IPatientService _patientService;
        Guid patientId = Guid.Empty;

        /// <summary>
        /// ����������� �����. �������������� ���������� � ������������� ������ ���������.
        /// </summary>
        public MainForm(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
        }

        /// <summary>
        /// �����, ���������� ��� �������� �����.
        /// </summary>
        public async void MainForm_Load(object sender, EventArgs e)
        {
            await RefreshDataGridAsync();
        }

        /// <summary>
        /// ���������� ������ �� ������ DataGridView.
        /// </summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patientId = Guid.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (patientId == Guid.Empty)
            {
                throw new Exception("�� ������� ������� ��������.");
            }
        }

        /// <summary>
        /// ���������/���������� ������ � DataGridView ��� ������� ������ "��������/��������".
        /// </summary>
        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await RefreshDataGridAsync();
        }

        /// <summary>
        /// ����� ��� ����������/������ ������ � DataGridView.
        /// </summary>
        private async Task RefreshDataGridAsync()
        {
            var patients = await _patientService.GetAllPatients();
            dataGridView.DataSource = null;
            dataGridView.DataSource = patients;
        }

        /// <summary>
        /// ����� �������� ���������� �������� ��� ������� ������ "�������".
        /// </summary>
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await _patientService.DeletePatient(patientId);
            await RefreshDataGridAsync();
        }

        /// <summary>
        /// ����� ���������� ������ �������� ��� ������� ������ "��������". 
        /// ��������� ����� ��� �������� ������ �������� � ��������� ������ � DataGridView ����� ��������� ����������.
        /// </summary>
        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var result = new PatientCreate(_patientService);
            if (result.ShowDialog() == DialogResult.OK)
            {
                await RefreshDataGridAsync();
            }
        }

        /// <summary>
        /// ����� ��������� ������ ��������� � DataGridView ��� ������� �� ������ "������������ ������". 
        /// </summary>
        private async void buttonAge_Click(object sender, EventArgs e)
        {
            var patients = await _patientService.GetPatientOlderThan((int)numericUpDown.Value);
            dataGridView.DataSource = null;
            dataGridView.DataSource = patients;
        }

        /// <summary>
        /// ����� ������ ����� ����� ����������� ������ � MessageBox ��� ������� ������ "�������� ����� ������".
        /// </summary>
        private async void buttonRoom_Click(object sender, EventArgs e)
        {
            var numberOfRoom = await _patientService.GetMostPopulatedRoom();
            MessageBox.Show($"����� ����� ����������� ������: {numberOfRoom}.");
        }
    }
}
