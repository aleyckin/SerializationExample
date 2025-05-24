namespace SerializationTest
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            labelAge = new Label();
            numericUpDown = new NumericUpDown();
            buttonAge = new Button();
            labelAgeButton = new Label();
            buttonRoom = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(144, 101);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1063, 469);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(318, 634);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(486, 634);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(66, 634);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(207, 34);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Обновить/Сбросить";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(1041, 634);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(238, 25);
            labelAge.TabIndex = 5;
            labelAge.Text = "Введите возраст пациентов";
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(1071, 675);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(180, 31);
            numericUpDown.TabIndex = 6;
            // 
            // buttonAge
            // 
            buttonAge.Location = new Point(743, 672);
            buttonAge.Name = "buttonAge";
            buttonAge.Size = new Size(228, 34);
            buttonAge.TabIndex = 7;
            buttonAge.Text = "Сформировать список";
            buttonAge.UseVisualStyleBackColor = true;
            buttonAge.Click += buttonAge_Click;
            // 
            // labelAgeButton
            // 
            labelAgeButton.AutoSize = true;
            labelAgeButton.Location = new Point(712, 634);
            labelAgeButton.Name = "labelAgeButton";
            labelAgeButton.Size = new Size(286, 25);
            labelAgeButton.TabIndex = 8;
            labelAgeButton.Text = "Получить пациентов старше чем:";
            // 
            // buttonRoom
            // 
            buttonRoom.Location = new Point(432, 706);
            buttonRoom.Name = "buttonRoom";
            buttonRoom.Size = new Size(245, 35);
            buttonRoom.TabIndex = 9;
            buttonRoom.Text = "Получить номер палаты";
            buttonRoom.UseVisualStyleBackColor = true;
            buttonRoom.Click += buttonRoom_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 767);
            Controls.Add(buttonRoom);
            Controls.Add(labelAgeButton);
            Controls.Add(buttonAge);
            Controls.Add(numericUpDown);
            Controls.Add(labelAge);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView);
            Name = "MainForm";
            Text = "Главная форма";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonRefresh;
        private Label labelAge;
        private NumericUpDown numericUpDown;
        private Button buttonAge;
        private Label labelAgeButton;
        private Button buttonRoom;
    }
}
