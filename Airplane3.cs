using System;
using System.Drawing;
using System.Windows.Forms;

namespace AirplaneAp3
{
    public class Airplane
    {
        private string foto; // Поле для хранения ссылки на фото

        // Свойства
        public string Name { get; set; } // Имя самолета
        public string Model { get; set; } // Модель самолета
        public int Range { get; set; } // Дальность полета
        public decimal FuelConsumption { get; set; } // Потребление горючего
        public DateTime ManufactureDate { get; set; } // Дата производства

        // Статическое поле для смены цвета фона
        public static Color BackColor
        {
            get
            {
                int currentDay = DateTime.Now.DayOfWeek.GetHashCode();
                return (currentDay % 2 == 1) ? Color.LightPink : Color.LightBlue;
            }
        }

        // Конструктор для инициализации нескольких свойств
        public Airplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate)
        {
            Name = name;
            Model = model;
            Range = range;
            FuelConsumption = fuelConsumption;
            ManufactureDate = manufactureDate;
        }

        // Конструктор с инициализацией поля foto
        public Airplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto)
            : this(name, model, range, fuelConsumption, manufactureDate) // Вызов другого конструктора
        {
            this.foto = foto;
        }

        // Метод для показа фото в PictureBox
        public void ShowFoto(PictureBox pictureBox)
        {
            if (!string.IsNullOrEmpty(foto))
            {
                try
                {
                    pictureBox.Image = Image.FromFile(foto);
                    pictureBox.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                }
            }
            else
            {
                pictureBox.Image = null;
                pictureBox.Visible = false;
            }
        }

        // Перегрузка метода для показа фото непосредственно на форме
        public void ShowFoto(Form form)
        {
            if (!string.IsNullOrEmpty(foto))
            {
                try
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(foto),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Fill
                    };
                    form.Controls.Add(pictureBox);
                    pictureBox.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                }
            }
        }

        public override string ToString()
        {
            return $"Самолет: {Name}, Модель: {Model}, Дальность полета: {Range} км, " +
                   $"Потребление горючего: {FuelConsumption} л/100км, " +
                   $"Дата производства: {ManufactureDate.ToShortDateString()}";
        }
    }
}