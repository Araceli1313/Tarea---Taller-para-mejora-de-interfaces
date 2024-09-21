namespace BibliotecaHerecia.Miembros
{
    partial class NuevoMiembro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoMiembro));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCrear = new Button();
            txtBoxNombre = new TextBox();
            txtBoxNumero = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 15);
            label3.Name = "label3";
            label3.Size = new Size(196, 21);
            label3.TabIndex = 11;
            label3.Text = "Crear Nuevo Miembro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 128);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.Location = new Point(60, 73);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 9;
            label1.Text = "Número de Miembro";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(189, 173);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(82, 22);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(158, 123);
            txtBoxNombre.Margin = new Padding(3, 2, 3, 2);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Escriba el nombre del miembro";
            txtBoxNombre.Size = new Size(248, 23);
            txtBoxNombre.TabIndex = 7;
            // 
            // txtBoxNumero
            // 
            txtBoxNumero.Location = new Point(158, 78);
            txtBoxNumero.Margin = new Padding(3, 2, 3, 2);
            txtBoxNumero.Name = "txtBoxNumero";
            txtBoxNumero.PlaceholderText = "Escriba el número del miembro";
            txtBoxNumero.Size = new Size(248, 23);
            txtBoxNumero.TabIndex = 6;
            // 
            // NuevoMiembro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(442, 248);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrear);
            Controls.Add(txtBoxNombre);
            Controls.Add(txtBoxNumero);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "NuevoMiembro";
            Text = "NuevoMiembro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCrear;
        private TextBox txtBoxNombre;
        private TextBox txtBoxNumero;
    }
}