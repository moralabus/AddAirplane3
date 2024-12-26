using AirplaneAp3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AirplaneAp3
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private string selectedFotoPath; // Переменная для хранения выбранного пути к фото
        private string selectedModel = "Boeing 737"; // Начальное значение для модели

        public Form1()
        {
            InitializeComponent();
            buttonAddAirplane.Click += buttonAddAirplane_Click; // Обработчик для добавления самолета
            buttonSelectFoto.Click += buttonSelectFoto_Click; // Обработчик для выбора фото
            buttonSort.Click += buttonSortByFuelConsumption_Click_1; // Обработчик для сортировки
            this.BackColor = Airplane.BackColor;
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";


            // Привязываем список к ListBox
            bindingSource.DataSource = new List<Airplane>();
            listBoxAirplanes.DataSource = bindingSource;
            listBoxAirplanes.DisplayMember = "Name"; // Убедитесь, что отображается нужное свойство

            // Привязка радиокнопок к выбранной модели
            radioButtonBoeing.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonAirbus.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonEmbraer.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                selectedModel = radioButton.Text;
            }
        }

        private void buttonSelectFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFotoPath = openFileDialog1.FileName; // Сохраняем путь к выбранному фото
                pictureBoxFoto.Image = Image.FromFile(selectedFotoPath); // Отображаем фото
            }
        }

        private void buttonAddAirplane_Click(object sender, EventArgs e)
        {
            // Получаем данные с формы
            string airplaneName = textBoxAirplaneName.Text?.Trim();
            // string model = comboBoxModel.SelectedItem?.ToString(); // Убираем ComboBox
            int range = (int)numericUpDownRange.Value;
            decimal fuelConsumption = numericUpDownFuelConsumption.Value;
            DateTime manufactureDate = dateTimePickerManufactureDate.Value;

            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(airplaneName))
            {
                MessageBox.Show("Эй, не забывай заполнять все поля, пожалуйста!");
                return;
            }

            if (char.IsLower(airplaneName[0]))
            {
                airplaneName = char.ToUpper(airplaneName[0]) + airplaneName.Substring(1);
            }

            // Создаем объект самолета 
            Airplane newAirplane = new Airplane(airplaneName, selectedModel, range, fuelConsumption, manufactureDate, selectedFotoPath);

            // Добавляем в список через BindingSource
            bindingSource.Add(newAirplane);

            // Очищаем элементы формы
            textBoxAirplaneName.Clear();
            // comboBoxModel.SelectedIndex = -1; // Убираем ComboBox
            numericUpDownRange.Value = 0;
            numericUpDownFuelConsumption.Value = 0;
            dateTimePickerManufactureDate.Value = DateTime.Now;
            pictureBoxFoto.Image = null; // Сбрасываем изображение
            selectedFotoPath = null; // Сбрасываем путь к изображению
        }

        private void buttonSortByFuelConsumption_Click_1(object sender, EventArgs e)
        {
            SortAirplanesByFuelConsumption();
        }

        private void SortAirplanesByFuelConsumption()
        {
            var sortedAirplanes = ((List<Airplane>)bindingSource.DataSource)
                                   .OrderBy(a => a.FuelConsumption)
                                   .ToList();
            bindingSource.DataSource = sortedAirplanes; // Обновляем BindingSource
        }
    }
}
