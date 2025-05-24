using IService.Interfaces;
using System.Windows.Forms;
using View;

namespace SerializationTest
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// DI контейнер для получения сервиса работы с пациентами.
        /// </summary>
        private readonly IPatientService _patientService;
        Guid patientId = Guid.Empty;

        /// <summary>
        /// Конструктор формы. Инициализирует компоненты и устанавливает сервис пациентов.
        /// </summary>
        public MainForm(IPatientService patientService)
        {
            InitializeComponent();
            _patientService = patientService;
        }

        /// <summary>
        /// Метод, вызываемый при загрузке формы.
        /// </summary>
        public async void MainForm_Load(object sender, EventArgs e)
        {
            await RefreshDataGridAsync();
        }

        /// <summary>
        /// Обработчик кликов по ячейке DataGridView.
        /// </summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patientId = Guid.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (patientId == Guid.Empty)
            {
                throw new Exception("Не удалось выбрать пациента.");
            }
        }

        /// <summary>
        /// Обновляет/сбрасывает данные в DataGridView при нажатии кнопки "Обновить/Сбросить".
        /// </summary>
        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await RefreshDataGridAsync();
        }

        /// <summary>
        /// Метод для обновления/сброса данных в DataGridView.
        /// </summary>
        private async Task RefreshDataGridAsync()
        {
            var patients = await _patientService.GetAllPatients();
            dataGridView.DataSource = null;
            dataGridView.DataSource = patients;
        }

        /// <summary>
        /// Метод удаления выбранного пациента при нажатии кнопки "Удалить".
        /// </summary>
        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            await _patientService.DeletePatient(patientId);
            await RefreshDataGridAsync();
        }

        /// <summary>
        /// Метод добавления нового пациента при нажатии кнопки "Добавить". 
        /// Открывает форму для создания нового пациента и обновляет данные в DataGridView после успешного добавления.
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
        /// Метод отрисовки списка пациентов в DataGridView при нажатии на кнопку "Сформировать список". 
        /// </summary>
        private async void buttonAge_Click(object sender, EventArgs e)
        {
            var patients = await _patientService.GetPatientOlderThan((int)numericUpDown.Value);
            dataGridView.DataSource = null;
            dataGridView.DataSource = patients;
        }

        /// <summary>
        /// Метод выдает номер самой заполненной палаты в MessageBox при нажатии кнопки "Получить номер палаты".
        /// </summary>
        private async void buttonRoom_Click(object sender, EventArgs e)
        {
            var numberOfRoom = await _patientService.GetMostPopulatedRoom();
            MessageBox.Show($"Номер самой заполненной палаты: {numberOfRoom}.");
        }
    }
}
