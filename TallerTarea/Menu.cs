using BibliotecaHerecia.Miembros;
using BibliotecaHerecia.Libros;
using BibliotecaHerecia.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaHerecia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelSubMenu1.Visible = false;
            panelSubMenu2.Visible = false;
            panelSubMenu3.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenu1.Visible == true)
                panelSubMenu1.Visible = false;
            if (panelSubMenu2.Visible == true)
                panelSubMenu2.Visible = false;
            if (panelSubMenu3.Visible == true)
                panelSubMenu3.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {

                SubMenu.Visible = true;
            }
        }

        private void btnAdminMiembros_Click(object sender, EventArgs e)
        {
            Form verMiembrosForm = new VerMiembros();
            verMiembrosForm.Show();
        }

        private void btnAdminLibros_Click(object sender, EventArgs e)
        {
            Form verLibrosForm = new VerLibros();
            verLibrosForm.Show();
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            Form realizarPrestamoForm = new RealizarPrestamo();
            realizarPrestamoForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            NuevoMiembro nuevoMiembro = new NuevoMiembro();
            nuevoMiembro.ShowDialog();

        }

        private void btnAdmLibros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bntVisualizacionMiembros_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form verMiembrosForm = new VerMiembros();
            verMiembrosForm.Show();

        }

        private void btnVisualizarLibros_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form verLibrosForm = new VerLibros();
            verLibrosForm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            NuevoLibro nuevoLibro = new NuevoLibro();
            nuevoLibro.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Form realizarPrestamoForm = new RealizarPrestamo();
            realizarPrestamoForm.Show();

        }

        private void bntPrestamos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenu3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
