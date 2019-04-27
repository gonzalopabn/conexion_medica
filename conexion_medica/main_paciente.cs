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
    public partial class main_paciente : Form
    {
        public main_paciente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio_sesion ini = new inicio_sesion();
            ini.abrir();
            this.Close();
        }

        private void main_paciente_Load(object sender, EventArgs e)
        {
            string myC = "datasource=remotemysql.com ;port=3306;username=MtcqKvJRNU;password=8cjzPjeLPp";
            MySqlConnection myConn = new MySqlConnection(myC);

            MySqlCommand sc = new MySqlCommand("select * from MtcqKvJRNU.reportes where id_paciente='" + t_id.Text + "';", myConn);
            MySqlDataReader myR;
            myConn.Open();
            myR = sc.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear(); 
            while (myR.Read() == true)
            {
                dataGridView1.Rows.Add(myR[0], myR[2], myR[3], myR[4], myR[5]);
            }
            myConn.Close();
        }
    }
}
