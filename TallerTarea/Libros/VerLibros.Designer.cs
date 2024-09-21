namespace BibliotecaHerecia.Libros
{
    partial class VerLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerLibros));
            btnBuscar = new Button();
            txtBoxBuscar = new TextBox();
            label1 = new Label();
            listaLibros = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(404, 30);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 24);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar Libro";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(16, 32);
            txtBoxBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Escriba el nombre del libro";
            txtBoxBuscar.Size = new Size(361, 23);
            txtBoxBuscar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(833, 32);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 7;
            label1.Text = "Agregar Libro";
            label1.Visible = false;
            label1.Click += iniciarCreacionLibro_Click;
            // 
            // listaLibros
            // 
            listaLibros.Location = new Point(16, 81);
            listaLibros.Margin = new Padding(3, 2, 3, 2);
            listaLibros.Name = "listaLibros";
            listaLibros.Size = new Size(953, 397);
            listaLibros.TabIndex = 5;
            // 
            // VerLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 500);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(label1);
            Controls.Add(listaLibros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "VerLibros";
            Text = "VerLibros";
            Activated += VerLibros_Activated;
            Load += VerLibros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private TextBox txtBoxBuscar;
        private Label label1;
        private FlowLayoutPanel listaLibros;
    }
}