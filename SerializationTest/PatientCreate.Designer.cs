namespace View
{
    partial class PatientCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            labelName = new Label();
            labelTitle = new Label();
            textBoxDescription = new TextBox();
            textBoxDisease = new TextBox();
            labelDescription = new Label();
            labelDisease = new Label();
            buttonBack = new Button();
            buttonAdd = new Button();
            numericUpDownAge = new NumericUpDown();
            labelAge = new Label();
            labelRoom = new Label();
            numericUpDownRoom = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoom).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(35, 127);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(401, 31);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(35, 99);
            labelName.Name = "labelName";
            labelName.Size = new Size(127, 25);
            labelName.TabIndex = 1;
            labelName.Text = "Имя пациента";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F);
            labelTitle.Location = new Point(25, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(420, 38);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Данные для создания пациента";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(35, 240);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(401, 105);
            textBoxDescription.TabIndex = 3;
            // 
            // textBoxDisease
            // 
            textBoxDisease.Location = new Point(35, 410);
            textBoxDisease.Name = "textBoxDisease";
            textBoxDisease.Size = new Size(401, 31);
            textBoxDisease.TabIndex = 4;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(35, 212);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(92, 25);
            labelDescription.TabIndex = 5;
            labelDescription.Text = "Описание";
            // 
            // labelDisease
            // 
            labelDisease.AutoSize = true;
            labelDisease.Location = new Point(35, 382);
            labelDisease.Name = "labelDisease";
            labelDisease.Size = new Size(78, 25);
            labelDisease.TabIndex = 6;
            labelDisease.Text = "Болезнь";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(324, 684);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(112, 34);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(179, 684);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(35, 508);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(401, 31);
            numericUpDownAge.TabIndex = 9;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(35, 480);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(76, 25);
            labelAge.TabIndex = 10;
            labelAge.Text = "Возраст";
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(31, 576);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(131, 25);
            labelRoom.TabIndex = 11;
            labelRoom.Text = "Номер палаты";
            // 
            // numericUpDownRoom
            // 
            numericUpDownRoom.Location = new Point(35, 604);
            numericUpDownRoom.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownRoom.Name = "numericUpDownRoom";
            numericUpDownRoom.Size = new Size(401, 31);
            numericUpDownRoom.TabIndex = 12;
            // 
            // PatientCreate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 743);
            Controls.Add(numericUpDownRoom);
            Controls.Add(labelRoom);
            Controls.Add(labelAge);
            Controls.Add(numericUpDownAge);
            Controls.Add(buttonAdd);
            Controls.Add(buttonBack);
            Controls.Add(labelDisease);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDisease);
            Controls.Add(textBoxDescription);
            Controls.Add(labelTitle);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Name = "PatientCreate";
            Text = "Создаение пациента";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label labelName;
        private Label labelTitle;
        private TextBox textBoxDescription;
        private TextBox textBoxDisease;
        private Label labelDescription;
        private Label labelDisease;
        private Button buttonBack;
        private Button buttonAdd;
        private NumericUpDown numericUpDownAge;
        private Label labelAge;
        private Label labelRoom;
        private NumericUpDown numericUpDownRoom;
    }
}