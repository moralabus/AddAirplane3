namespace AirplaneAp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAirplaneName = new System.Windows.Forms.TextBox();
            this.listBoxAirplanes = new System.Windows.Forms.ListBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonAddAirplane = new System.Windows.Forms.Button();
            this.numericUpDownFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.buttonSelectFoto = new System.Windows.Forms.Button();
            this.radioButtonBoeing = new System.Windows.Forms.RadioButton();
            this.radioButtonAirbus = new System.Windows.Forms.RadioButton();
            this.radioButtonEmbraer = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 185);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 31);
            this.textBox2.TabIndex = 40;
            this.textBox2.Text = "расход топлива";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 31);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "введите дальность";
            // 
            // dateTimePickerManufactureDate
            // 
            this.dateTimePickerManufactureDate.Location = new System.Drawing.Point(189, 226);
            this.dateTimePickerManufactureDate.Name = "dateTimePickerManufactureDate";
            this.dateTimePickerManufactureDate.Size = new System.Drawing.Size(321, 31);
            this.dateTimePickerManufactureDate.TabIndex = 38;
            // 
            // textBoxAirplaneName
            // 
            this.textBoxAirplaneName.Location = new System.Drawing.Point(465, 12);
            this.textBoxAirplaneName.Name = "textBoxAirplaneName";
            this.textBoxAirplaneName.Size = new System.Drawing.Size(321, 31);
            this.textBoxAirplaneName.TabIndex = 37;
            this.textBoxAirplaneName.Text = "Имя самолета";
            // 
            // listBoxAirplanes
            // 
            this.listBoxAirplanes.DataSource = this.listBoxAirplanes.CustomTabOffsets;
            this.listBoxAirplanes.FormattingEnabled = true;
            this.listBoxAirplanes.ItemHeight = 25;
            this.listBoxAirplanes.Location = new System.Drawing.Point(189, 263);
            this.listBoxAirplanes.Name = "listBoxAirplanes";
            this.listBoxAirplanes.Size = new System.Drawing.Size(321, 179);
            this.listBoxAirplanes.TabIndex = 36;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(465, 460);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(321, 39);
            this.buttonSort.TabIndex = 35;
            this.buttonSort.Text = "сортировка самолетов ";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonAddAirplane
            // 
            this.buttonAddAirplane.Location = new System.Drawing.Point(465, 505);
            this.buttonAddAirplane.Name = "buttonAddAirplane";
            this.buttonAddAirplane.Size = new System.Drawing.Size(321, 41);
            this.buttonAddAirplane.TabIndex = 34;
            this.buttonAddAirplane.Text = "добавить летучую бибику";
            this.buttonAddAirplane.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFuelConsumption
            // 
            this.numericUpDownFuelConsumption.Location = new System.Drawing.Point(409, 185);
            this.numericUpDownFuelConsumption.Name = "numericUpDownFuelConsumption";
            this.numericUpDownFuelConsumption.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownFuelConsumption.TabIndex = 33;
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Location = new System.Drawing.Point(409, 148);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownRange.TabIndex = 32;
            this.numericUpDownRange.Tag = "";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(743, 153);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(280, 289);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 41;
            this.pictureBoxFoto.TabStop = false;
            // 
            // buttonSelectFoto
            // 
            this.buttonSelectFoto.Location = new System.Drawing.Point(743, 111);
            this.buttonSelectFoto.Name = "buttonSelectFoto";
            this.buttonSelectFoto.Size = new System.Drawing.Size(280, 36);
            this.buttonSelectFoto.TabIndex = 43;
            this.buttonSelectFoto.Text = "выбрать фото";
            this.buttonSelectFoto.UseVisualStyleBackColor = true;
            // 
            // radioButtonBoeing
            // 
            this.radioButtonBoeing.AutoSize = true;
            this.radioButtonBoeing.Location = new System.Drawing.Point(515, 150);
            this.radioButtonBoeing.Name = "radioButtonBoeing";
            this.radioButtonBoeing.Size = new System.Drawing.Size(152, 29);
            this.radioButtonBoeing.TabIndex = 44;
            this.radioButtonBoeing.TabStop = true;
            this.radioButtonBoeing.Text = "Boeing 737";
            this.radioButtonBoeing.UseVisualStyleBackColor = true;
            // 
            // radioButtonAirbus
            // 
            this.radioButtonAirbus.AutoSize = true;
            this.radioButtonAirbus.Location = new System.Drawing.Point(516, 185);
            this.radioButtonAirbus.Name = "radioButtonAirbus";
            this.radioButtonAirbus.Size = new System.Drawing.Size(160, 29);
            this.radioButtonAirbus.TabIndex = 45;
            this.radioButtonAirbus.TabStop = true;
            this.radioButtonAirbus.Text = "Airbus A320";
            this.radioButtonAirbus.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmbraer
            // 
            this.radioButtonEmbraer.AutoSize = true;
            this.radioButtonEmbraer.Location = new System.Drawing.Point(516, 220);
            this.radioButtonEmbraer.Name = "radioButtonEmbraer";
            this.radioButtonEmbraer.Size = new System.Drawing.Size(166, 29);
            this.radioButtonEmbraer.TabIndex = 46;
            this.radioButtonEmbraer.TabStop = true;
            this.radioButtonEmbraer.Text = "Embraer 190";
            this.radioButtonEmbraer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 580);
            this.Controls.Add(this.radioButtonEmbraer);
            this.Controls.Add(this.radioButtonAirbus);
            this.Controls.Add(this.radioButtonBoeing);
            this.Controls.Add(this.buttonSelectFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePickerManufactureDate);
            this.Controls.Add(this.textBoxAirplaneName);
            this.Controls.Add(this.listBoxAirplanes);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddAirplane);
            this.Controls.Add(this.numericUpDownFuelConsumption);
            this.Controls.Add(this.numericUpDownRange);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerManufactureDate;
        private System.Windows.Forms.TextBox textBoxAirplaneName;
        private System.Windows.Forms.ListBox listBoxAirplanes;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonAddAirplane;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelConsumption;
        private System.Windows.Forms.NumericUpDown numericUpDownRange;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button buttonSelectFoto;
        private System.Windows.Forms.RadioButton radioButtonBoeing;
        private System.Windows.Forms.RadioButton radioButtonAirbus;
        private System.Windows.Forms.RadioButton radioButtonEmbraer;
    }
}

