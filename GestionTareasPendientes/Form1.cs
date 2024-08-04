using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                lstTareas.Items.Add(txtTarea.Text);
                txtTarea.Clear();

            }
            else
            {
                MessageBox.Show("Ingrese una tarea", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                lstTareas.Items.Remove(lstTareas.SelectedItem);

            }
            else
            {
                MessageBox.Show("Elija la tarea que desea eliminar", "Ninguna tarea selecionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
