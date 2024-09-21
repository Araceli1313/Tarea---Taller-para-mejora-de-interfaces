namespace BibliotecaHerecia.Libros
{
    partial class EditarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarLibro));
            label3 = new Label();
            label2 = new Label();
            btnActualizar = new Button();
            txtBoxTitulo = new TextBox();
            label4 = new Label();
            txtBoxAutor = new TextBox();
            label5 = new Label();
            txtBoxAnio = new TextBox();
            label6 = new Label();
            txtBoxGenero = new TextBox();
            label7 = new Label();
            txtBoxISBN = new TextBox();
            labelFormato = new Label();
            txtBoxFormato = new TextBox();
            labelTamanio = new Label();
            txtBoxTamanio = new TextBox();
            labelUbicacion = new Label();
            txtBoxUbicacion = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 17);
            label3.Name = "label3";
            label3.Size = new Size(284, 21);
            label3.TabIndex = 11;
            label3.Text = "Actualizar Información del Libro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 75);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 10;
            label2.Text = "Título";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(172, 417);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 22);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // txtBoxTitulo
            // 
            txtBoxTitulo.Location = new Point(161, 70);
            txtBoxTitulo.Margin = new Padding(3, 2, 3, 2);
            txtBoxTitulo.Name = "txtBoxTitulo";
            txtBoxTitulo.PlaceholderText = "Escriba el título del libro";
            txtBoxTitulo.Size = new Size(248, 23);
            txtBoxTitulo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 124);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 13;
            label4.Text = "Autor";
            // 
            // txtBoxAutor
            // 
            txtBoxAutor.Location = new Point(161, 118);
            txtBoxAutor.Margin = new Padding(3, 2, 3, 2);
            txtBoxAutor.Name = "txtBoxAutor";
            txtBoxAutor.PlaceholderText = "Escriba el nombre del autor";
            txtBoxAutor.Size = new Size(248, 23);
            txtBoxAutor.TabIndex = 12;
            // 
            // label5
            // 
            label5.Location = new Point(62, 168);
            label5.Name = "label5";
            label5.Size = new Size(78, 30);
            label5.TabIndex = 15;
            label5.Text = "Año de Publicación";
            // 
            // txtBoxAnio
            // 
            txtBoxAnio.Location = new Point(161, 172);
            txtBoxAnio.Margin = new Padding(3, 2, 3, 2);
            txtBoxAnio.Name = "txtBoxAnio";
            txtBoxAnio.PlaceholderText = "Escriba el año de publicación del libro";
            txtBoxAnio.Size = new Size(248, 23);
            txtBoxAnio.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 284);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 19;
            label6.Text = "Genero";
            // 
            // txtBoxGenero
            // 
            txtBoxGenero.Location = new Point(161, 279);
            txtBoxGenero.Margin = new Padding(3, 2, 3, 2);
            txtBoxGenero.Name = "txtBoxGenero";
            txtBoxGenero.PlaceholderText = "Escriba el nombre del miembro";
            txtBoxGenero.Size = new Size(248, 23);
            txtBoxGenero.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 232);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 17;
            label7.Text = "ISBN";
            // 
            // txtBoxISBN
            // 
            txtBoxISBN.Location = new Point(161, 226);
            txtBoxISBN.Margin = new Padding(3, 2, 3, 2);
            txtBoxISBN.Name = "txtBoxISBN";
            txtBoxISBN.PlaceholderText = "Escriba el ISBN del libro";
            txtBoxISBN.Size = new Size(248, 23);
            txtBoxISBN.TabIndex = 16;
            // 
            // labelFormato
            // 
            labelFormato.AutoSize = true;
            labelFormato.Location = new Point(62, 334);
            labelFormato.Name = "labelFormato";
            labelFormato.Size = new Size(52, 15);
            labelFormato.TabIndex = 21;
            labelFormato.Text = "Formato";
            // 
            // txtBoxFormato
            // 
            txtBoxFormato.Location = new Point(161, 328);
            txtBoxFormato.Margin = new Padding(3, 2, 3, 2);
            txtBoxFormato.Name = "txtBoxFormato";
            txtBoxFormato.PlaceholderText = "Escriba el formato del libro";
            txtBoxFormato.Size = new Size(248, 23);
            txtBoxFormato.TabIndex = 20;
            // 
            // labelTamanio
            // 
            labelTamanio.AutoSize = true;
            labelTamanio.Location = new Point(62, 386);
            labelTamanio.Name = "labelTamanio";
            labelTamanio.Size = new Size(49, 15);
            labelTamanio.TabIndex = 23;
            labelTamanio.Text = "Tamaño";
            // 
            // txtBoxTamanio
            // 
            txtBoxTamanio.Location = new Point(161, 381);
            txtBoxTamanio.Margin = new Padding(3, 2, 3, 2);
            txtBoxTamanio.Name = "txtBoxTamanio";
            txtBoxTamanio.PlaceholderText = "Escriba el nombre del miembro";
            txtBoxTamanio.Size = new Size(248, 23);
            txtBoxTamanio.TabIndex = 22;
            // 
            // labelUbicacion
            // 
            labelUbicacion.AutoSize = true;
            labelUbicacion.Location = new Point(62, 337);
            labelUbicacion.Name = "labelUbicacion";
            labelUbicacion.Size = new Size(60, 15);
            labelUbicacion.TabIndex = 25;
            labelUbicacion.Text = "Ubicación";
            // 
            // txtBoxUbicacion
            // 
            txtBoxUbicacion.Location = new Point(161, 332);
            txtBoxUbicacion.Margin = new Padding(3, 2, 3, 2);
            txtBoxUbicacion.Name = "txtBoxUbicacion";
            txtBoxUbicacion.PlaceholderText = "Escriba la ubicación del libro";
            txtBoxUbicacion.Size = new Size(248, 23);
            txtBoxUbicacion.TabIndex = 24;
            // 
            // EditarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(441, 456);
            Controls.Add(labelUbicacion);
            Controls.Add(txtBoxUbicacion);
            Controls.Add(labelTamanio);
            Controls.Add(txtBoxTamanio);
            Controls.Add(labelFormato);
            Controls.Add(txtBoxFormato);
            Controls.Add(label6);
            Controls.Add(txtBoxGenero);
            Controls.Add(label7);
            Controls.Add(txtBoxISBN);
            Controls.Add(label5);
            Controls.Add(txtBoxAnio);
            Controls.Add(label4);
            Controls.Add(txtBoxAutor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnActualizar);
            Controls.Add(txtBoxTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditarLibro";
            Text = "EditarLibro";
            Load += EditarLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button btnActualizar;
        private TextBox txtBoxTitulo;
        private Label label4;
        private TextBox txtBoxAutor;
        private Label label5;
        private TextBox txtBoxAnio;
        private Label label6;
        private TextBox txtBoxGenero;
        private Label label7;
        private TextBox txtBoxISBN;
        private Label labelFormato;
        private TextBox txtBoxFormato;
        private Label labelTamanio;
        private TextBox txtBoxTamanio;
        private Label labelUbicacion;
        private TextBox txtBoxUbicacion;
    }
}