using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexion_medica
{
    public partial class main_doc : Form
    {
        public main_doc()
        {
            InitializeComponent();
        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo_paciente np = new nuevo_paciente();
            np.Show();
            this.Close(); 

            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio_sesion ini = new inicio_sesion();
            ini.abrir();
            this.Close();
        }
    }
}
