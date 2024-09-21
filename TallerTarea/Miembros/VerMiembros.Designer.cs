namespace BibliotecaHerecia.Miembros
{
    partial class VerMiembros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerMiembros));
            listaMiembros = new FlowLayoutPanel();
            label1 = new Label();
            txtBoxBuscar = new TextBox();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // listaMiembros
            // 
            listaMiembros.Location = new Point(22, 87);
            listaMiembros.Margin = new Padding(3, 2, 3, 2);
            listaMiembros.Name = "listaMiembros";
            listaMiembros.Size = new Size(953, 397);
            listaMiembros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(839, 38);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 2;
            label1.Text = "Agregar Miembro";
            label1.Visible = false;
            label1.Click += iniciarCreacionMiembro_Click;
            // 
            // txtBoxBuscar
            // 
            txtBoxBuscar.Location = new Point(22, 38);
            txtBoxBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBoxBuscar.Name = "txtBoxBuscar";
            txtBoxBuscar.PlaceholderText = "Escriba el nombre del miembro";
            txtBoxBuscar.Size = new Size(361, 23);
            txtBoxBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(410, 36);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(128, 24);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar Miembro";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // VerMiembros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(992, 508);
            Controls.Add(btnBuscar);
            Controls.Add(txtBoxBuscar);
            Controls.Add(label1);
            Controls.Add(listaMiembros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "VerMiembros";
            Text = "VerMiembros";
            Activated += VerMiembros_Activated;
            Load += VerMiembros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel listaMiembros;
        private Label label1;
        private TextBox txtBoxBuscar;
        private Button btnBuscar;
    }
}