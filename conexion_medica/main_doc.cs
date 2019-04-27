using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

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

        private void main_doc_Load(object sender, EventArgs e)
        {
            string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
            MySqlConnection myConn = new MySqlConnection(myC);

            MySqlCommand sc = new MySqlCommand("select * from MtcqKvJRNU.paciente;", myConn);
            MySqlDataReader myR;
            myConn.Open();
            myR = sc.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (myR.Read() == true)
            {
                dataGridView1.Rows.Add(myR[1], myR[2], myR[3]);
            }
            myConn.Close();
        }

        private void verDatosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datos_doc dd = new datos_doc();
            dd.Show();
            this.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
