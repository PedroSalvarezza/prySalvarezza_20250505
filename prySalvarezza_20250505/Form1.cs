using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prySalvarezza_20250505
{
    public partial class frmSuperheroes : Form
    {
        public frmSuperheroes()
        {
            InitializeComponent();
        }

        private void frmSuperheroes_Load(object sender, EventArgs e)
        {
            cmbSuperheroes.Items.Add("Superman");
            cmbSuperheroes.Items.Add("Batman");
            cmbSuperheroes.Items.Add("Mujer Maravilla");
        }

        private void cmbSuperheroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbSuperheroes.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Superman":
                    imgSuperheroes.Image = Properties.Resources.Superman;
                    break;
                case "Batman":
                    imgSuperheroes.Image = Properties.Resources.Batman;
                    break;
                case "Mujer Maravilla":
                    imgSuperheroes.Image = Properties.Resources.MujerMaravilla;
                    break;
                default:
                    imgSuperheroes.Image = null;
                    break;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            int fuerza = (int)numFuerza.Value;
            int destreza = (int)numDestreza.Value;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor ingrese un nombre para el personaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string datos = $"Nombre: {nombre} - Fuerza: {fuerza} - Destreza: {destreza}";
            string rutaArchivo = Path.Combine(Application.StartupPath, "personajes.txt");
            try
            {
                File.AppendAllText(rutaArchivo, datos + Environment.NewLine);
                MessageBox.Show("Personaje guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                numFuerza.Value = 0;
                numDestreza.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
