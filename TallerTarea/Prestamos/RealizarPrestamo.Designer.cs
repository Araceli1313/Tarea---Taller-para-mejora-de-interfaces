namespace BibliotecaHerecia.Prestamos
{
    partial class RealizarPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarPrestamo));
            miembrosComboBox = new ComboBox();
            tipoLibroComboBox = new ComboBox();
            librosComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRealizarPrestamo = new Button();
            label5 = new Label();
            fechaDevolucionDatePicker = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // miembrosComboBox
            // 
            miembrosComboBox.FormattingEnabled = true;
            miembrosComboBox.Location = new Point(196, 90);
            miembrosComboBox.Margin = new Padding(3, 2, 3, 2);
            miembrosComboBox.Name = "miembrosComboBox";
            miembrosComboBox.Size = new Size(222, 23);
            miembrosComboBox.TabIndex = 0;
            // 
            // tipoLibroComboBox
            // 
            tipoLibroComboBox.FormattingEnabled = true;
            tipoLibroComboBox.Location = new Point(196, 148);
            tipoLibroComboBox.Margin = new Padding(3, 2, 3, 2);
            tipoLibroComboBox.Name = "tipoLibroComboBox";
            tipoLibroComboBox.Size = new Size(222, 23);
            tipoLibroComboBox.TabIndex = 1;
            tipoLibroComboBox.SelectedValueChanged += tipoLibroComboBox_SelectedValueChanged;
            // 
            // librosComboBox
            // 
            librosComboBox.FormattingEnabled = true;
            librosComboBox.Location = new Point(196, 205);
            librosComboBox.Margin = new Padding(3, 2, 3, 2);
            librosComboBox.Name = "librosComboBox";
            librosComboBox.Size = new Size(222, 23);
            librosComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 92);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Miembro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 150);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Tipo de Libro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 207);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 5;
            label3.Text = "Libro";
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.Location = new Point(230, 338);
            btnRealizarPrestamo.Margin = new Padding(3, 2, 3, 2);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(131, 22);
            btnRealizarPrestamo.TabIndex = 6;
            btnRealizarPrestamo.Text = "Realizar Préstamo";
            btnRealizarPrestamo.UseVisualStyleBackColor = true;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 31);
            label5.Name = "label5";
            label5.Size = new Size(191, 21);
            label5.TabIndex = 30;
            label5.Text = "Realizar un préstamo";
            // 
            // fechaDevolucionDatePicker
            // 
            fechaDevolucionDatePicker.Format = DateTimePickerFormat.Short;
            fechaDevolucionDatePicker.Location = new Point(199, 277);
            fechaDevolucionDatePicker.Margin = new Padding(3, 2, 3, 2);
            fechaDevolucionDatePicker.Name = "fechaDevolucionDatePicker";
            fechaDevolucionDatePicker.Size = new Size(219, 23);
            fechaDevolucionDatePicker.TabIndex = 31;
            // 
            // label4
            // 
            label4.Location = new Point(86, 270);
            label4.Name = "label4";
            label4.Size = new Size(80, 34);
            label4.TabIndex = 32;
            label4.Text = "Fecha de Devolución";
            // 
            // RealizarPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(502, 376);
            Controls.Add(label4);
            Controls.Add(fechaDevolucionDatePicker);
            Controls.Add(label5);
            Controls.Add(btnRealizarPrestamo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(librosComboBox);
            Controls.Add(tipoLibroComboBox);
            Controls.Add(miembrosComboBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "RealizarPrestamo";
            Text = "RealizarPrestamo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox miembrosComboBox;
        private ComboBox tipoLibroComboBox;
        private ComboBox librosComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRealizarPrestamo;
        private Label label5;
        private DateTimePicker fechaDevolucionDatePicker;
        private Label label4;
    }
}